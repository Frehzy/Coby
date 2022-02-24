using Storage.Entities.Interface;
using System;

namespace Storage.Entities.Implementation;

public class License : ILicense
{
    public Guid WaiterId { get; }

    public License(Guid waiterId) =>
        WaiterId = waiterId;
}