using System;

namespace Shared.Dto.Enities;

public class License
{
    public Guid Id { get; set; }

    public License() { }

    public License(Guid waiterId) =>
        Id = waiterId;
}