using Shared;
using System;
using System.Drawing;

namespace Storage.DataBase;

public class WaiterFace
{
    public Guid Id { get; set; }

    public string Face { get; set; }

    public WaiterFace() { }

    public WaiterFace(Guid waiterId, string base64Face)
    {
        Id = waiterId;
        Face = base64Face;
    }

    public WaiterFace(Guid waiterId, Image face)
    {
        Id = waiterId;
        Face = ConvertToBase64(face);
    }

    public string ConvertToBase64(Image face) => Base64ImageConverter.ConvertToBase64(face);

    public Image ConvertToImage(string base64) => Base64ImageConverter.ConvertToImage(base64);
}