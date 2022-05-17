using Newtonsoft.Json;
using NLog;
using Shared.Dto.Exceptions;
using System;
using System.Diagnostics;

namespace Shared;

public class Log
{
    private static readonly Logger _logger = LogManager.GetCurrentClassLogger();

    public static string ProgramName => $"[{Process.GetCurrentProcess().MainModule.ModuleName}]";

    public static void Warn(string message) { _logger.Warn($"{ProgramName}\n{message}"); Console.WriteLine(message); }

    public static void Info(string message) { _logger.Info($"{ProgramName}\n{message}"); Console.WriteLine(message); }

    public static void Error(Exception ex)
    {
        _logger.Error($"{ProgramName}\n" +
            $"Message: {ex.Message}\n" +
            $"InnerException: {ex?.InnerException}\n" +
            $"StackTrace: {ex?.StackTrace}\n" +
            $"FullException: {ex}");

        Console.WriteLine(ex);
    }

    public static void Error(EntityUsingException ex)
    {
        _logger.Error($"{ProgramName}\n" +
            $"EntityId: {ex.EntityId}\n" +
            $"EntityType: {ex.EntityType}\n" +
            $"Message: {ex.Message}\n" +
            $"InnerException: {ex?.InnerException}\n" +
            $"StackTrace: {ex?.StackTrace}\n" +
            $"BaseException: {ex.GetBaseException()}\n" +
            $"FullException: {ex}");

        Console.WriteLine(ex);
    }

    public static void Fatal(Exception ex)
    {
        _logger.Fatal($"{ProgramName}\n" +
            $"Message: {ex.Message}\n" +
            $"InnerException: {ex?.InnerException}\n" +
            $"StackTrace: {ex?.StackTrace}\n" +
            $"FullException: {ex}");

        Console.WriteLine(ex);
    }

    public static void Fatal(EntityUsingException ex)
    {
        _logger.Fatal($"{ProgramName}\n" +
            $"EntityId: {ex.EntityId}\n" +
            $"EntityType: {ex.EntityType}\n" +
            $"Message: {ex.Message}\n" +
            $"InnerException: {ex?.InnerException}\n" +
            $"StackTrace: {ex?.StackTrace}\n" +
            $"BaseException: {ex.GetBaseException()}\n" +
            $"FullException: {ex}");

        Console.WriteLine(ex);
    }

    public static string SerializeInstance<T>(T instance) =>
        JsonConvert.SerializeObject(instance, Formatting.Indented);
}