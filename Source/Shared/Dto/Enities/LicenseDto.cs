using System;

namespace Shared.Dto.Enities;

public record LicenseDto
{
    public Guid Id { get; init; }

    public LicenseDto() { }

    public LicenseDto(Guid waiterId) =>
        Id = waiterId;
}