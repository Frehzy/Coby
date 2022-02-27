using System;

namespace Storage.Entities.Implementation;

public class Credentials
{
    public Guid WaiterId { get; }

    public Credentials() { }

    public Credentials(Guid waiterId) =>
        WaiterId = waiterId;
}