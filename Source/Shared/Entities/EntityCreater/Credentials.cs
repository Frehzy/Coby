using System;

namespace Storage.Entities.EntityCreater;

public class Credentials : ICredentials
{
    public Guid WaiterId { get; }

    public Credentials(Guid waiterId) =>
        WaiterId = waiterId;
}