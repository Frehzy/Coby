using FaceRecognition;
using FaceRecognition.Entities;
using FaceRecognition.Enums;
using MaterialSkin.Controls;
using Office.ClientOperation;
using Office.Helper;
using Shared.Dto.Enities;
using Storage.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Office.Forms.MessageForm.Face;

public partial class AddWaiterFaceForm : MaterialForm
{
    private readonly IClient _client;
    private readonly Waiter _waiter;
    private readonly List<WaiterFace> _waiterFace;

    public AddWaiterFaceForm(Guid waiterId, IClient client)
    {
        InitializeComponent();
        _client = client;
        _waiter = _client.GetByCacheOperation.Waiter.GetWaiterById(waiterId);
        _waiterFace = _client.GetByCacheOperation.WaiterFace.GetWaiterFaceById(waiterId);
        _ = FormHelper.CreateMaterialSkinManager(this);
        CheckExistenceFaces();
        LoadInfo(_waiter, WaiterTextBox);
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

    private void CheckExistenceFaces()
    {
        if (_waiterFace.Count <= 0)
            return;

        if (MaterialMessageBox.Show("Лицо уже добавлено. Удалить существующее?", default, MessageBoxButtons.YesNo, FlexibleMaterialForm.ButtonsPosition.Center) is DialogResult.Yes)
            _client.Remover.RemoveWaiterFacesById(_waiter.Id);
        else
            Close();
    }

    private void LoadInfo(Waiter waiter, MaterialMultiLineTextBox2 textBox)
    {
        var properties = waiter.GetType().GetProperties();
        var result = properties.Select(x => $"{x.Name}: {x.GetValue(waiter, null)}");
        textBox.Text = string.Join(Environment.NewLine, result);
    }

    private void SaveButton_Click(object sender, EventArgs e)
    {
        var cameraIndex = CamerasComboBox.SelectedIndex;
        var maxFaceDetect = (double)(MaxFaceDetectValueSlider.Value / 100);
        var resolution = ResolutionsComboBox.SelectedItem as Resolution;
        var method = MethodComboBox.SelectedItem as Enum;

        var faceDetectionForm = new FaceDetectionForm(_waiter,
                                                      cameraIndex,
                                                      maxFaceDetect,
                                                      resolution,
                                                      (FaceDetectMethodEnum)method,
                                                      _client.Creater.AddWaiterFacesById);
        faceDetectionForm.Show();
        Enabled = false;
        faceDetectionForm.FormClosing += (sender, e) =>
        {
            Enabled = true;
            Close();
        };
    }
}