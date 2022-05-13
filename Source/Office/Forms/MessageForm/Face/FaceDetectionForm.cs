﻿using FaceRecognition;
using FaceRecognition.Entities;
using FaceRecognition.Transcription;
using MaterialSkin.Controls;
using Office.Helper;
using Shared.Dto.Enities;
using Storage.DataBase;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Office.Forms.MessageForm.Face;

public partial class FaceDetectionForm : MaterialForm
{
    private readonly Waiter _waiter;
    private readonly DetectFace _detectFace;
    private readonly Func<Guid, Image, WaiterFace> _addWaiterFace;

    public FaceDetectionForm(Waiter waiter,
                             int cameraIndex,
                             double maxFaceDetect,
                             Resolution resolution,
                             Func<Guid, Image, WaiterFace> addWaiterFace)
    {
        InitializeComponent();
        _waiter = waiter;
        _detectFace = new(cameraIndex, CameraBox, maxFaceDetect, resolution.X, resolution.Y);
        _addWaiterFace = addWaiterFace;
        _ = FormHelper.CreateMaterialSkinManager(this);
        _detectFace.Start();
    }

    private void AddFaceButton_Click(object sender, EventArgs e) =>
        _detectFace.AddFace(_waiter.Id, Transctiption.Front(_waiter.Name), default, _detectFace.ScreenFace());

    private void SaveButton_Click(object sender, EventArgs e)
    {
        var faces = _detectFace.Faces;
        if (faces.Count <= 0)
            return;

        if (MaterialMessageBox.Show($"Сохранить лица в базу данных? Количество: {faces.Count}. Нет - очистить все добавленные сейчас лица.",
                                    default,
                                    MessageBoxButtons.YesNo,
                                    FlexibleMaterialForm.ButtonsPosition.Center) is DialogResult.Yes)
        {
            faces.ForEach(x => _addWaiterFace(_waiter.Id, x.DefaultFace));
            _detectFace?.Dispose();
            Close();
        }
        else
            _detectFace.ClearAllFace();
    }

    private void FaceDetectionForm_FormClosing(object sender, FormClosingEventArgs e) =>
        _detectFace?.Dispose();
}