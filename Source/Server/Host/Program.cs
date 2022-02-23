using Storage.Host;
using System;
using System.ServiceModel;

namespace Host;

internal class Program
{
    static void Main(string[] args)
    {
        using var host = new ServiceHost(typeof(Service));
        host.Open();
        Console.WriteLine("Хост стартовал!");

        foreach(var uri in host.BaseAddresses)
            Console.WriteLine(uri.AbsoluteUri);

        Console.ReadLine();
    }
}
