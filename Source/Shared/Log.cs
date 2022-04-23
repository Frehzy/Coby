using Newtonsoft.Json;
using NLog;
using System;
using System.Diagnostics;

namespace Shared;

public class Log
{
    private static readonly Logger _logger = LogManager.GetCurrentClassLogger();

    public static string ProgramName => $"[{Process.GetCurrentProcess().MainModule.ModuleName}]";

    public static void Warn(string message) { _logger.Warn($"{ProgramName}\n{message}"); Console.WriteLine(message); }

    public static void Info(string message) { _logger.Info($"{ProgramName}\n{message}"); Console.WriteLine(message); }

    public static void Error(string message) { _logger.Error($"{ProgramName}\n{message}"); Console.WriteLine(message); }

    public static void Fatal(string message) { _logger.Fatal($"{ProgramName}\n{message}"); Console.WriteLine(message); }

    public static string SerializeInstance<T>(T instance) =>
        JsonConvert.SerializeObject(instance, Formatting.Indented);
}