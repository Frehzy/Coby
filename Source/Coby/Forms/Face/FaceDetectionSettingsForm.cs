using FaceRecognition;
using FaceRecognition.Entities;
using FaceRecognition.Enums;
using MaterialSkin.Controls;
using Office.Helper;
using System;

namespace Coby.Forms.Face;

public partial class FaceDetectionSettingsForm : MaterialForm
{
    public FaceDetectionSettingsForm()
    {
        InitializeComponent();
        _ = FormHelper.CreateMaterialSkinManager(this);
        LoadSettings();
    }

    private void LoadSettings()
    {
        CamerasComboBox.DataSource = WebcamHelper.TakeAllWebCamera();
        var resolutions = WebcamHelper.GetResolutions();
        ResolutionsComboBox.DataSource = resolutions;
        ResolutionsComboBox.DisplayMember = "FullResolution";
        MethodComboBox.DataSource = Enum.GetValues(typeof(FaceDetectMethodEnum));
    }

    private void SaveButton_Click(object sender, EventArgs e)
    {
        FaceDetectionSettings.CameraIndex = CamerasComboBox.SelectedIndex;
        FaceDetectionSettings.MaxFaceDetect = MaxFaceDetectValueSlider.Value / 100;
        FaceDetectionSettings.Resolution = ResolutionsComboBox.SelectedItem as Resolution;
        FaceDetectionSettings.FaceDetectMethod = (FaceDetectMethodEnum)MethodComboBox.SelectedItem;
        Close();
    }
}