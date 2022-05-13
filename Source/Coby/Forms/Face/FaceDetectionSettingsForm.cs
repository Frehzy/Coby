using FaceRecognition;
using FaceRecognition.Entities;
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
        LoadConfiguration();
        LoadSaveSettings();
    }

    private void LoadConfiguration()
    {
        CamerasComboBox.DataSource = WebcamHelper.TakeAllWebCamera();
        var resolutions = WebcamHelper.GetResolutions();
        ResolutionsComboBox.DataSource = resolutions;
        ResolutionsComboBox.DisplayMember = nameof(Resolution.FullResolution);
    }

    private void LoadSaveSettings()
    {
        CamerasComboBox.SelectedIndex = FaceDetectionSettings.CameraIndex;
        MaxFaceDetectValueSlider.Value = Convert.ToInt32(FaceDetectionSettings.MaxFaceDetect * 100);
        ResolutionsComboBox.SelectedItem = FaceDetectionSettings.Resolution;
    }

    private void SaveButton_Click(object sender, EventArgs e)
    {
        FaceDetectionSettings.CameraIndex = CamerasComboBox.SelectedIndex;
        FaceDetectionSettings.MaxFaceDetect = (double)Math.Round(decimal.Divide(MaxFaceDetectValueSlider.Value, 100), 2);
        FaceDetectionSettings.Resolution = ResolutionsComboBox.SelectedItem as Resolution;
        Close();
    }
}