using Shared.Dto.Enities;
using Storage.Entities.Implementation;

namespace Storage.Entities.Factory;

internal static class LicenceFactory
{
    public static LicenseDto CreateDto(License licence) =>
        new()
        {
            Id = licence.Id,
        };

    public static License Create(LicenseDto licenseDto) =>
        new(licenseDto.Id);
}