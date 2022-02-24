using Storage.Cache;
using Storage.Operations.License;
using Storage.Operations.Order;

namespace Storage.Operations;

public class AllOperations
{
    public ILicenseOperation LicenseOperation { get; }
    public IOrderOperation OrderOperation { get; }

    public AllOperations(AllCache cache)
    {
        LicenseOperation = new LicenseOperation(cache);
        OrderOperation = new OrderOperation(cache);
    }
}
