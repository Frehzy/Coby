using System;

namespace Storage.Entities;

public interface ILicense
{
    Guid WaiterId { get; }

    IDisposable GetLicense(Guid waiterId);
}