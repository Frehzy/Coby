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
    private readonly double _maxFaceDetectValue;
    private readonly int _resolutionX;
    private readonly int _resolutionY;
    private readonly FilterInfoCollection _filter;

    private VideoCaptureDevice _device;
    private MCvFont _font = new(FONT.CV_FONT_HERSHEY_TRIPLEX, 0.6d, 0.6d);
    private Image<Gray, byte> _resultFrame;
    private FaceEntity _foundFace;

    private delegate Image FaceDelegate(object sender, NewFrameEventArgs e);
    private FaceDelegate _syncFaceDelegate;
    private FaceDelegate _asyncFaceDelegate;

    public event PropertyChangedEventHandler PropertyChanged;

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
                      int resolutionY,
                      FaceDetectMethodEnum methodType)
    {
        _cameraIndex = cameraIndex;
        _cameraBox = cameraBox;
        _maxFaceDetectValue = maxFaceDetectValue;
        _resolutionX = resolutionX;
        _resolutionY = resolutionY;
        _filter = new FilterInfoCollection(FilterCategory.VideoInputDevice);
        _device = new VideoCaptureDevice(_filter[_cameraIndex].MonikerString);

        _syncFaceDelegate = Device_NewFrame;
        _asyncFaceDelegate = Device_NewFrame_Parallel;

        _device.NewFrame += (sender, e) =>
        {
            _cameraBox.Image = methodType is FaceDetectMethodEnum.Sync
                ? _syncFaceDelegate(sender, e)
                : _asyncFaceDelegate(sender, e);
        };
    }

    public void Start() =>
        _device.Start();

    private Image Device_NewFrame_Parallel(object sender, NewFrameEventArgs e)
    {
        using Image<Bgr, byte> frame = new(new Bitmap(e.Frame, new Size(_resolutionX, _resolutionY)));
        using Image<Gray, byte> grayFace = frame.Convert<Gray, byte>();
        int size = (int)Math.Ceiling(Convert.ToDouble(_resolutionX / 5));
        MCvAvgComp[][] facesDetectedNow = grayFace.DetectHaarCascade(_haar,
                                                                     1.2,
                                                                     10,
                                                                     HAAR_DETECTION_TYPE.SCALE_IMAGE,
                                                                     new Size(size, size));
        string name = default;
        Parallel.ForEach(facesDetectedNow[0], (f, state) =>
        {
            _resultFrame = frame.Copy(f.rect).Convert<Gray, byte>().Resize(100, 100, INTER.CV_INTER_CUBIC);
            frame.Draw(f.rect, new Bgr(Color.Green), 3);
            if (Faces.Count > 0)
            {
                FoundFace = TryGetFaceByMaxValue(_maxFaceDetectValue);
                if (FoundFace?.DetectValue >= _maxFaceDetectValue)
                {
                    MCvTermCriteria termCriterias = new(Faces.Count, 0.001);
                    var faces = Faces.Select(x => x.Face).ToArray();
                    var names = Faces.Select(x => x.Name).ToArray();
                    EigenObjectRecognizer recognizer = new(faces, names, 1500, ref termCriterias);

                    name = recognizer.Recognize(_resultFrame);
                    frame.Draw(name, ref _font, new Point(f.rect.X - 2, f.rect.Y - 2), new Bgr(Color.Red));
                    FoundFace.SetStatus(FaceDetectStatusEnum.Detect);

                    state.Stop();
                }
            }
        });
        if (facesDetectedNow.First().Length == 0)
            FoundFace?.SetStatus(FaceDetectStatusEnum.Nothing);
        else if (facesDetectedNow.First().Length == 1 && name == string.Empty)
            FoundFace?.SetStatus(FaceDetectStatusEnum.NotExist);

        return frame.ToBitmap();
    }

    private Image Device_NewFrame(object sender, NewFrameEventArgs e)
    {
        using Image<Bgr, byte> frame = new(new Bitmap(e.Frame, new Size(_resolutionX, _resolutionY)));
        using Image<Gray, byte> grayFace = frame.Convert<Gray, byte>();
        int size = (int)Math.Ceiling(Convert.ToDouble(_resolutionX / 5));
        MCvAvgComp[][] facesDetectedNow = grayFace.DetectHaarCascade(_haar,
                                                                     1.2,
                                                                     10,
                                                                     HAAR_DETECTION_TYPE.SCALE_IMAGE,
                                                                     new Size(size, size));
        string name = default;
        foreach (var f in facesDetectedNow.First())
        {
            _resultFrame = frame.Copy(f.rect).Convert<Gray, byte>().Resize(100, 100, INTER.CV_INTER_CUBIC);
            frame.Draw(f.rect, new Bgr(Color.Green), 3);
            if (Faces.Count > 0)
            {
                FoundFace = TryGetFaceByMaxValue(_maxFaceDetectValue);
                if (FoundFace?.DetectValue >= _maxFaceDetectValue)
                {
                    MCvTermCriteria termCriterias = new(Faces.Count, 0.001);
                    var faces = Faces.Select(x => x.Face).ToArray();
                    var names = Faces.Select(x => x.Name).ToArray();
                    EigenObjectRecognizer recognizer = new(faces, names, 1500, ref termCriterias);

                    name = recognizer.Recognize(_resultFrame);
                    frame.Draw(name, ref _font, new Point(f.rect.X - 2, f.rect.Y - 2), new Bgr(Color.Red));
                    FoundFace.SetStatus(FaceDetectStatusEnum.Detect);

                    break;
                }
            }
        }
        if (facesDetectedNow.First().Length == 0)
            FoundFace?.SetStatus(FaceDetectStatusEnum.Nothing);
        else if (facesDetectedNow.First().Length == 1 && name == string.Empty)
            FoundFace?.SetStatus(FaceDetectStatusEnum.NotExist);

        return frame.ToBitmap();
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
        Unsubscribe(_syncFaceDelegate);
        Unsubscribe(_asyncFaceDelegate);

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

    protected void OnPropertyChanged(PropertyChangedEventArgs e) =>
        PropertyChanged?.Invoke(this, e);

    protected void OnPropertyChanged(string propertyName) =>
        OnPropertyChanged(new PropertyChangedEventArgs(propertyName));

    private FaceEntity TryGetFaceByMaxValue(double maxFaceValue)
    {
        foreach (var face in Faces)
        {
            _resultFrame.MatchTemplate(face.Face, TM_TYPE.CV_TM_CCOEFF_NORMED)
                   .MinMax(out _, out double[] maxValues, out _, out _);

            face.SetDetectValue(maxValues.First());
            if (face.DetectValue >= maxFaceValue)
                return face;
        }
        return default;
    }
}