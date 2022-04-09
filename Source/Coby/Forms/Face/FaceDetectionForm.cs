using Coby.ClientOperation;
using FaceRecognition;
using FaceRecognition.Entities;
using FaceRecognition.Enums;
using FaceRecognition.Transcription;
using MaterialSkin.Controls;
using Office.Helper;
using Shared.Dto.Enities;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Coby.Forms.Face;

public partial class FaceDetectionForm : MaterialForm
{
    private readonly IClient _client;
    private readonly DetectFace _detectFace;
    private FaceEntity _foundFace;

    public FaceDetectionForm(IClient client)
    {
        InitializeComponent();
        _client = client;
        _detectFace = new(FaceDetectionSettings.CameraIndex,
                          CameraBox,
                          FaceDetectionSettings.MaxFaceDetect,
                          FaceDetectionSettings.Resolution.X,
                          FaceDetectionSettings.Resolution.Y,
                          FaceDetectionSettings.FaceDetectMethod);
        _ = FormHelper.CreateMaterialSkinManager(this);
        var waiters = _client.GetByCacheOperation.Waiter.GetWaiters();
        _client.GetByCacheOperation.WaiterFace.GetWaiterFaces()
                                              .ForEach(x =>
                                              {
                                                  var waiter = waiters.First(y => y.Id.Equals(x.Id));
                                                  _detectFace.AddFace(waiter.Id,
                                                                      Transctiption.Front(waiter.Name),
                                                                      waiter.Password,
                                                                      x.ConvertToImage(x.Face));
                                              });
        _detectFace.Start();
        _detectFace.PropertyChanged += FoundFacePropertyChanged;
    }

    public Credentials GetCredentials() =>
        ShowDialog() is DialogResult.OK
            ? _client.LicenseOperation.GetCredentials(_foundFace.Password, out _)
            : default;

    private void FoundFacePropertyChanged(object sender, PropertyChangedEventArgs e)
    {
        if (e.PropertyName is nameof(_detectFace.FoundFace) && _detectFace.FoundFace?.FaceDetectStatus is FaceDetectStatusEnum.Detect)
        {
            _foundFace = _detectFace.FoundFace;
            DialogResult = DialogResult.OK;
        }
    }

    private void FaceDetectionForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        Enabled = false;
        _detectFace.PropertyChanged -= FoundFacePropertyChanged;
        _detectFace?.Dispose();
    }

    private void ExitButton_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel;
        Close();
    }
}