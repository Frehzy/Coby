using Storage.Host;
using System;
using System.ServiceModel;

namespace Host;

internal class Program
{
    static void Main(string[] args)
    {
        var serviceAddress = "127.0.0.1:10000";
        var serviceName = "CobyServer";

        var host = new ServiceHost(typeof(Service), new Uri($"net.tcp://{serviceAddress}/{serviceName}"));
        var serverBinding = new NetTcpBinding();
        serverBinding.Security.Mode = SecurityMode.None;
        host.AddServiceEndpoint(typeof(IService), serverBinding, "");
        host.Open();

        Console.WriteLine("Server started:");
        foreach (var uri in host.BaseAddresses)
            Console.WriteLine(uri.AbsoluteUri);

        Console.ReadKey();
    }
}
