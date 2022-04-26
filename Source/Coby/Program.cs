﻿using Coby.ClientOperation;
using Coby.Forms;
using Shared;
using System;
using System.ServiceModel;
using System.Threading;
using System.Windows.Forms;

namespace Coby;

internal static class Program
{
    static void Main()
    {
        var client = CreateClient();

        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new LoginForm(client));
    }

    static IClient CreateClient()
    {
        while (true)
        {
            try
            {
                return new Client();
            }
            catch (EndpointNotFoundException ex)
            {
                Log.Error($"Failed to instantiate client. Exception: {ex}");
            }
            catch (Exception ex)
            {
                Log.Error($"Unknown exception: {ex}");
            }
            Thread.Sleep(TimeSpan.FromSeconds(5));
        }
    }
}