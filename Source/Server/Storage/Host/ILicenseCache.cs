using Shared.Dto.Enities;
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
    License AddLicense(License license);

    [OperationContract]
    bool RemoveLicense(Guid licenseId);
}