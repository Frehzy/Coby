using Shared.Dto.Enities;
using Shared.Dto.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Storage.DataBase.Converter;

internal static class WaiterConverter
{
    public static Waiter Converter(WaiterDB waiter, List<WaiterFacesDB> faces) =>
        new(waiter.Id, waiter.Name, waiter.Password, ConvertPermissionStatus(waiter.PermissionStatus), WaiterSessionStatus.Closed)
        {
            Faces = GetFacesByWaiterId(waiter.Id, faces)
        };

    private static PermissionStatus ConvertPermissionStatus(bool permissionStatus) =>
        permissionStatus ? PermissionStatus.Admin : PermissionStatus.Waiter;

    private static List<Image> GetFacesByWaiterId(Guid waiterId, List<WaiterFacesDB> face) =>
        face.Where(x => x.Id.Equals(waiterId)).Select(x => x.ConvertToImage()).ToList();
}