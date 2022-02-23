using System;

namespace Storage.Entities.EntityCreater;

internal class Credentials : ICredentials
{
    public Guid WaiterId { get; }

    public Credentials(Guid waiterId) =>
        WaiterId = waiterId;
}