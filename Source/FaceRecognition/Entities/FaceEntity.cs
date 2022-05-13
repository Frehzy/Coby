using Emgu.CV;
using Emgu.CV.Structure;
using FaceRecognition.Enums;
using System;
using System.Drawing;

namespace FaceRecognition.Entities;

public class FaceEntity
{
    public Guid WaiterId { get; set; }

    public string Name { get; private set; }

    public string Password { get; private set; }

    public Image DefaultFace { get; private set; }

    public Image<Gray, byte> Face { get; private set; }

    public double DetectValue { get; private set; }

    public FaceDetectStatusEnum FaceDetectStatus { get; private set; }

    public MCvAvgComp MCvAvgComp { get; private set; }

    public FaceEntity(Guid waiterId, string name, string password, Image face, double detectValue = default)
    {
        if (face is null)
            throw new ArgumentNullException(nameof(face));

        WaiterId = waiterId;
        Name = name;
        Password = password;
        DefaultFace = face;
        Face = new Image<Gray, byte>(new Bitmap(face));
        DetectValue = detectValue;
    }

    public void SetDetectValue(double value) => DetectValue = Math.Round(value, 2);

    public void SetMCvAvgComp(MCvAvgComp value) => MCvAvgComp = value;

    public void SetStatus(FaceDetectStatusEnum status) => FaceDetectStatus = status;
}