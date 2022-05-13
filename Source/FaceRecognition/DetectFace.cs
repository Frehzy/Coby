using AForge.Video;
using AForge.Video.DirectShow;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using FaceRecognition.Entities;
using FaceRecognition.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaceRecognition;

public class DetectFace : INotifyPropertyChanged, IDisposable
{
    private readonly HaarCascade _haar = new("haarcascade_frontalface_default.xml");
    private readonly int _cameraIndex;
    private readonly PictureBox _cameraBox;
    private readonly int _resolutionX;
    private readonly int _grayResolutionX;
    private readonly int _resolutionY;
    private readonly int _grayResolutionY;
    private readonly FilterInfoCollection _filter;

    private VideoCaptureDevice _device;
    private MCvFont _font = new(FONT.CV_FONT_HERSHEY_TRIPLEX, 0.6d, 0.6d);
    private Image<Gray, byte> _resultFrame;
    private FaceEntity _foundFace;
    private double _maxFaceDetectValue;

    public event PropertyChangedEventHandler PropertyChanged;

    private delegate Task<Image> FaceDelegate(object sender, NewFrameEventArgs e);
    private readonly FaceDelegate _faceEventDelegate;

    public double MaxFaceDetectValue
    {
        get => _maxFaceDetectValue;
        private set
        {
            if (value >= 1)
                _maxFaceDetectValue = 0.99;
            else if (value <= 0)
                _maxFaceDetectValue = 0.01;
            else
                _maxFaceDetectValue = value;
        }
    }

    public FaceEntity FoundFace
    {
        get => _foundFace;
        private set
        {
            _foundFace = value;
            OnPropertyChanged(nameof(FoundFace));
        }
    }

    public List<FaceEntity> Faces { get; private set; } = new();

    public DetectFace(int cameraIndex,
                      PictureBox cameraBox,
                      double maxFaceDetectValue,
                      int resolutionX,
                      int resolutionY)
    {
        _cameraIndex = cameraIndex;
        _cameraBox = cameraBox;
        _resolutionX = resolutionX;
        _grayResolutionX = (int)Math.Ceiling(Convert.ToDouble(_resolutionX / 5));
        _resolutionY = resolutionY;
        _grayResolutionY = (int)Math.Ceiling(Convert.ToDouble(_resolutionY / 5));
        _filter = new FilterInfoCollection(FilterCategory.VideoInputDevice);
        _device = new VideoCaptureDevice(_filter[_cameraIndex].MonikerString);

        MaxFaceDetectValue = maxFaceDetectValue;

        _faceEventDelegate = Device_NewFrame;
        _device.NewFrame += (sender, e) =>
        {
            _cameraBox.Image = _faceEventDelegate(sender, e).Result;
        };
    }

    public void Start() =>
        _device.Start();

    private async Task<Image> Device_NewFrame(object sender, NewFrameEventArgs e)
    {
        using Image<Bgr, byte> frame = new(new Bitmap(e.Frame, new Size(_resolutionX, _resolutionY)));
        using Image<Gray, byte> grayFace = frame.Convert<Gray, byte>();
        MCvAvgComp[][] facesDetectedNow = grayFace.DetectHaarCascade(_haar,
                                                                     1.2,
                                                                     10,
                                                                     HAAR_DETECTION_TYPE.SCALE_IMAGE,
                                                                     new Size(_grayResolutionX, _grayResolutionY));
        string name = string.Empty;
        var faceEntities = await SemaphoreAsync.RunSemaphoreAsync(facesDetectedNow.First(),
                                                   GetFaceByMaxValue,
                                                   Environment.ProcessorCount * 2);

        if (faceEntities.Where(x => x is not null).Count() > 0)
        {
            FoundFace = faceEntities.OrderByDescending(x => x.DetectValue).First();
            if (FoundFace.DetectValue >= MaxFaceDetectValue)
            {
                MCvTermCriteria termCriterias = new(Faces.Count, 0.001);
                var faces = Faces.Select(x => x.Face).ToArray();
                var names = Faces.Select(x => x.Name).ToArray();
                EigenObjectRecognizer recognizer = new(faces, names, 1500, ref termCriterias);

                name = recognizer.Recognize(_resultFrame);
                frame.Draw(name,
                           ref _font,
                           new Point(FoundFace.MCvAvgComp.rect.X - 2, FoundFace.MCvAvgComp.rect.Y - 2),
                           new Bgr(Color.Red));

                FoundFace.SetStatus(FaceDetectStatusEnum.Detect);
            }
        }

        if (facesDetectedNow.First().Length == 0)
            FoundFace?.SetStatus(FaceDetectStatusEnum.Nothing);
        else if (facesDetectedNow.First().Length == 1 && name == string.Empty)
            FoundFace?.SetStatus(FaceDetectStatusEnum.NotExist);

        return frame.ToBitmap();

        async Task<FaceEntity> GetFaceByMaxValue(MCvAvgComp facesDetectionFrameNow)
        {
            _resultFrame = frame.Copy(facesDetectionFrameNow.rect).Convert<Gray, byte>().Resize(100, 100, INTER.CV_INTER_CUBIC);
            frame.Draw(facesDetectionFrameNow.rect, new Bgr(Color.Green), 3);

            List<FaceEntity> copyFaces = new();
            copyFaces.AddRange(Faces);
            copyFaces.ForEach(x => x.SetMCvAvgComp(facesDetectionFrameNow));

            var calculateMatchFaces = await SemaphoreAsync.RunSemaphoreAsync(copyFaces,
                                                                             CalculateMatchTemplate,
                                                                             Environment.ProcessorCount * 2);

            return calculateMatchFaces.OrderByDescending(x => x.DetectValue).FirstOrDefault();

            Task<FaceEntity> CalculateMatchTemplate(FaceEntity face)
            {
                _resultFrame.MatchTemplate(face.Face, TM_TYPE.CV_TM_CCOEFF_NORMED)
                            .MinMax(out _, out double[] maxValues, out _, out _);

                face.SetDetectValue(maxValues.First());
                return Task.FromResult(face);
            }
        }
    }

    public void Stop()
    {
        if (_device.IsRunning)
        {
            _device.SignalToStop();
            _device = null;
        }
    }

    public void AddFace(Guid waiterId, string name, string password, Image face) =>
        Faces.Add(new(waiterId, name, password, face));

    public Image ScreenFace() =>
        _resultFrame?.Resize(100, 100, INTER.CV_INTER_CUBIC).ToBitmap();

    public void ClearAllFace()
    {
        if (Faces.Count > 0)
            Faces.Clear();
    }

    public void Dispose()
    {
        Unsubscribe(_faceEventDelegate);

        if (_device is not null)
            Stop();

        _cameraBox.Dispose();
        _filter.Clear();

        static void Unsubscribe(FaceDelegate faceDelegate)
        {
            foreach (var d in faceDelegate.GetInvocationList())
                faceDelegate -= (FaceDelegate)d;
        }
    }

    protected void OnPropertyChanged(string propertyName) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}