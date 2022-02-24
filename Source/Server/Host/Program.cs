﻿using Storage;
using Storage.Host;
using System;
using System.ServiceModel;
using System.Threading;

namespace Host;

internal class Program
{
    static void Main(string[] args)
    {
        if (IsSingleInstance())
        {
            var serviceAddress = "127.0.0.1:10000";
            var serviceName = "CobyServer";

            var host = new ServiceHost(typeof(Service), new Uri($"net.tcp://{serviceAddress}/{serviceName}"));
            var serverBinding = new NetTcpBinding();
            serverBinding.Security.Mode = SecurityMode.None;
            host.AddServiceEndpoint(typeof(IService), serverBinding, "");
            host.Open();

            Log.Info("Сервер запущен по следующим адресам:");
            foreach (var uri in host.BaseAddresses)
                Log.Info(uri.AbsoluteUri);

            Console.ReadKey();
            host.Close();
        }
        else
            Log.Fatal("Только один экземпляр сервера может быть запущен.");

        Log.Info("Сервер выключен.");
    }

    static bool IsSingleInstance()
    {
        try
        {
            Mutex.OpenExisting("CobyServerMutex");
        }
        catch
        {
            _ = new Mutex(true, "CobyServerMutex");
            return true;
        }
        return false;
    }
}
