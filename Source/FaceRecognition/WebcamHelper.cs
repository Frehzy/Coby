using AForge.Video.DirectShow;
using FaceRecognition.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace FaceRecognition;

public static class WebcamHelper
{
    private static List<Resolution> _resolutions = new();

    public static List<string> TakeAllWebCamera()
    {
        FilterInfoCollection filter = new(FilterCategory.VideoInputDevice);
        List<string> listCamera = new();
        listCamera.AddRange(from FilterInfo f in filter
                            select f.Name.ToString());

        return listCamera.Count >= 1
            ? listCamera
            : throw new NullReferenceException("No cameras found.");
    }

    public static List<Resolution> GetResolutions()
    {
        if (_resolutions.Count() > 0)
            return _resolutions;

        int i = 0;
        DEVMODE vDevMode = new();
        while (EnumDisplaySettings(null, i++, ref vDevMode))
            _resolutions.Add(new(vDevMode.dmPelsWidth, vDevMode.dmPelsHeight));

        _resolutions = _resolutions.GroupBy(x => new { x.X, x.Y })
                           .Select(g => g.First()).ToList();

        return _resolutions;
    }

    [DllImport("user32.dll")]
    public static extern bool EnumDisplaySettings(
             string deviceName, int modeNum, ref DEVMODE devMode);
}