using Shared;
using Shared.IniManager;
using Storage.Host;
using System;
using System.ServiceModel;
using System.Threading;

namespace Host;

internal class Program
{
    static void Main(string[] args)
    {
        var mutex = new Mutex(false, "CobyServerMutex");
        if (IsSingleInstance(mutex))
        {
            try
            {
                var manager = new Manager(Operations.GetIniFilePath());
                var settings = Operations.GetSettings(manager);

                var serviceAddress = "127.0.0.1:10000";
                var serviceName = "CobyServer";

                var host = new ServiceHost(typeof(Service), new Uri($"net.tcp://{serviceAddress}/{serviceName}/{settings.OrganizationId}"));
                var serverBinding = new NetTcpBinding();
                serverBinding.Security.Mode = SecurityMode.None;
                host.AddServiceEndpoint(typeof(IService), serverBinding, "");
                host.Description.Behaviors.Find<ServiceBehaviorAttribute>().IncludeExceptionDetailInFaults = true;
                host.Open();

                var client = SetCache(serviceAddress, serviceName, settings);

                Log.Info("The server is running on the following ip-addresses:");
                foreach (var uri in host.BaseAddresses)
                    Log.Info(uri.AbsoluteUri);

                Console.ReadKey();

                client.Close();
                host.Close();
            }
            catch (Exception ex)
            {
                Log.Fatal(ex);
            }
        }
        else
            Log.Fatal(new Exception("Only one server instance can be running."));

        Log.Info("Server is down.");
        mutex.ReleaseMutex();
    }

    private static ChannelFactory<IService> SetCache(string serviceAddress, string serviceName, Settings settings)
    {
        var factory = CreateClient();
        var client = factory.CreateChannel();
        client.SetCache();
        return factory;

        ChannelFactory<IService> CreateClient()
        {
            var tcpUri = new Uri($"net.tcp://{serviceAddress}/{serviceName}/{settings.OrganizationId}");
            var address = new EndpointAddress(tcpUri);
            var clientBinding = new NetTcpBinding();
            clientBinding.Security.Mode = SecurityMode.None;
            clientBinding.MaxReceivedMessageSize = 2097152;
            clientBinding.MaxBufferPoolSize = 2097152;
            clientBinding.MaxBufferSize = 2097152;
            ChannelFactory<IService> factory = new(clientBinding, address);
            return factory;
        }
    }

    static bool IsSingleInstance(Mutex mutex) => mutex.WaitOne(TimeSpan.Zero);
}
