using FaceRecognition.Entities;

namespace Coby.Forms.Face;

internal static class FaceDetectionSettings
{
    public static int CameraIndex = 0;

    public static double MaxFaceDetect = 0.8;

    public static Resolution Resolution = new(640, 480);
}