namespace Shared.Dto.Enums;

public enum RequestStatus
{
    EntityAlreadyExists = 0,
    EntityNotFound = 1,
    DeniedPermission = 2,
    OK = 3,
    Unknown = 4
}