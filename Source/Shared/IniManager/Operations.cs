using System.IO;
using System.Reflection;

namespace Shared.IniManager;

public static class Operations
{
    public static string GetIniFilePath() =>
        Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Settings.ini";

    public static Settings GetSettings(Manager manager)
    {
        var sections = nameof(Settings);
        return manager.GetEntitiesBySection<Settings>(sections);
    }
}