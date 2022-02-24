using System;

namespace Storage.Entities.Interface;

public interface ILicense
{
    Guid WaiterId { get; }
}