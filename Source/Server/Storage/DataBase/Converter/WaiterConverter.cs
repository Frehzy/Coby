using Shared.Dto.Enities;
using Shared.Dto.Enums;

namespace Storage.DataBase.Converter;

internal static class WaiterConverter
{
    public static Waiter Converter(WaiterDB waiter) =>
        new(waiter.Id, waiter.Name, waiter.Password, ConvertPermissionStatus(waiter.PermissionStatus), WaiterSessionStatus.Closed);

    private static PermissionStatus ConvertPermissionStatus(bool permissionStatus) =>
        permissionStatus ? PermissionStatus.Admin : PermissionStatus.Waiter;
}