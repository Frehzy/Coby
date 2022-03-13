using System;

namespace FaceRecognition.Entities;

public class Resolution
{
    private readonly int _divisor;

    public int X { get; private set; }

    public int Y { get; private set; }

    public string FullResolution => $"{X}:{Y} [{ImageProportions}]";

    public string ImageProportions => $"{Math.Round((double)(X / _divisor))}:{Math.Round((double)(Y / _divisor))}";

    public Resolution(int x, int y)
    {
        X = x;
        Y = y;
        _divisor = GetCommonDivisor(X, Y);
    }

    private int GetCommonDivisor(int x, int y)
    {
        while (x != 0 && y != 0)
        {
            if (x > y)
                x %= y;
            else
                y %= x;
        }

        return x | y;
    }
}