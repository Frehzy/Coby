using System;

namespace Shared.Dto.Enities;

public class Credentials
{
    public Guid WaiterId { get; set; }

    public Credentials() { }

    public Credentials(Guid waiterId) =>
        WaiterId = waiterId;
}