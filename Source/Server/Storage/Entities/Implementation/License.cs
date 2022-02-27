using System;

namespace Storage.Entities.Implementation;

public class License
{
    public Guid Id { get; set; }

    public License() { }

    public License(Guid waiterId) =>
        Id = waiterId;
}