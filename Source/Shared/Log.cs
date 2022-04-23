using NLog;
using System;
using System.Diagnostics;
using System.Linq;

namespace Shared;

public class Log
{
    private static readonly Logger _logger = LogManager.GetCurrentClassLogger();

    public static string ProgramName => $"[{Process.GetCurrentProcess().MainModule.ModuleName}]";

    public static void Warn(string message) { _logger.Warn(ProgramName + message); Console.WriteLine(message); }

    public static void Info(string message) { _logger.Info(ProgramName + message); Console.WriteLine(message); }

    public static void Error(string message) { _logger.Error(ProgramName + message); Console.WriteLine(message); }

    public static void Fatal(string message) { _logger.Fatal(ProgramName + message); Console.WriteLine(message); }

    public static string GetFormatProperties<T>(T q)
    {
        var properties = q.GetType().GetProperties();
        var result = properties.Select(x => $"{x.Name}: {x.GetValue(q, null)}");
        return string.Join(Environment.NewLine, result);
    }
}