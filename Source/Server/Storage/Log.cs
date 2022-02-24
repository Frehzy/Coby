using NLog;
using System;
using System.Diagnostics;

namespace Storage;

public class Log
{
    private static readonly Logger _logger = LogManager.GetCurrentClassLogger();

    public static string ProgramName => $"[{Process.GetCurrentProcess().MainModule.ModuleName}]";

    public static void Warn(string message) { _logger.Warn(ProgramName + message); Console.WriteLine(message); }

    public static void Info(string message) { _logger.Info(ProgramName + message); Console.WriteLine(message); }

    public static void Error(string message) { _logger.Error(ProgramName + message); Console.WriteLine(message); }

    public static void Fatal(string message) { _logger.Fatal(ProgramName + message); Console.WriteLine(message); }
}