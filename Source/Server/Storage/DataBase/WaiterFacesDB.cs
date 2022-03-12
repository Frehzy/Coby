using Shared;
using System;
using System.Drawing;

namespace Storage.DataBase;

internal class WaiterFacesDB
{
    public Guid Id { get; set; }

    public string Face { get; set; }

    public WaiterFacesDB() { }

    public WaiterFacesDB(Guid waiterId, string base64Face)
    {
        Id = waiterId;
        Face = base64Face;
    }

    public Image ConvertToImage() => Base64ImageConverter.ConvertToImage(Face);
}