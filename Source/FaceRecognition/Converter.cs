using System;
using System.Drawing;
using System.IO;

namespace FaceRecognition;

public static class Converter
{
    public static string ConvertToBase64(Image face)
    {
        ImageConverter _imageConverter = new();
        var xByte = (byte[])_imageConverter.ConvertTo(face, typeof(byte[]));
        return Convert.ToBase64String(xByte);
    }

    public static Image ConvertToImage(string base64)
    {
        byte[] imageBytes = Convert.FromBase64String(base64);
        using var ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
        return Image.FromStream(ms, true);
    }
}