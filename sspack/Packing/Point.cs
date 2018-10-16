using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct Point
{
    public int X;
    public int Y;

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
}


public struct Size
{
    public int Width;
    public int Height;

    public Size(int width, int height)
    {
        Width = width;
        Height = height;
    }
}

public enum FailCode
{
    Success = 0,
    FailedParsingArguments = 1,
    ImageExporter,
    MapExporter,
    NoImages,
    ImageNameCollision,

    FailedToLoadImage,
    FailedToPackImage,
    FailedToCreateImage,
    FailedToSaveImage,
    FailedToSaveMap
}
