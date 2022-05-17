using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Shared.IniManager;

public class Manager
{
    public string FilePath { get; private set; }

    public Manager(string filePath) =>
        FilePath = filePath;

    public void Write(string section, string key, string value) =>
        WritePrivateProfileString(section, key, value.ToLower(), FilePath);

    public string Read(string section, string key)
    {
        StringBuilder SB = new(8192);
        GetPrivateProfileString(section, key, "", SB, 8192, FilePath);
        return SB.ToString();
    }

    public List<string> GetKeys(string section)
    {
        byte[] buffer = new byte[8192];

        GetPrivateProfileSection(section, buffer, 8192, FilePath);
        string[] tmp = Encoding.ASCII.GetString(buffer).Trim('\0').Split('\0');

        List<string> result = new();

        foreach (string entry in tmp)
            result.Add(entry.Substring(0, entry.IndexOf("=")));

        return result;
    }

    public T GetEntitiesBySection<T>(string section)
    {
        var keys = GetKeys(section);
        var instance = Activator.CreateInstance(typeof(T));
        var properties = typeof(T).GetProperties().Where(x => keys.Contains(x.Name));

        foreach (var prop in properties)
        {
            var data = Read(section, prop.Name);
            object dataValue = Guid.TryParse(data, out Guid guid) ? guid : data;
            prop.SetValue(instance, Convert.ChangeType(dataValue, prop.PropertyType));
        }

        return (T)instance;
    }

    [DllImport("kernel32")]
    private static extern long WritePrivateProfileString(string section,
                                                         string key,
                                                         string val,
                                                         string filePath);

    [DllImport("kernel32")]
    private static extern int GetPrivateProfileString(string section,
                                                      string key,
                                                      string def,
                                                      StringBuilder retVal,
                                                      int size,
                                                      string filePath);

    [DllImport("kernel32")]
    private static extern int GetPrivateProfileSection(string section,
                                                       byte[] buffer,
                                                       int size,
                                                       string fileName);
}