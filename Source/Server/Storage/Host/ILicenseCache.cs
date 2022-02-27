using Shared.Dto.Enities;
using Storage.Entities.Implementation;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace Storage.Host;

[ServiceContract]
public interface ILicenseCache
{
    [OperationContract]
    List<License> GetLicensesCache();

    [OperationContract]
    LicenseDto AddLicense(License license);

    [OperationContract]
    bool RemoveLicense(Guid licenseId);

}