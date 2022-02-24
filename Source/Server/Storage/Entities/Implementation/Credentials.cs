using Storage.Entities.Interface;
using System;

namespace Storage.Entities.Implementation;

public class Credentials : ICredentials
{
    public Guid WaiterId { get; }

    public Credentials(Guid waiterId) =>
        WaiterId = waiterId;
}