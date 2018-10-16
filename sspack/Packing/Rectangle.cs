using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct Rectangle
{
    private Rect _rect;

    public int X
    {
        get { return (int) _rect.x; }
        set { _rect.x = value; }
    }

    public int Y
    {
        get { return (int) _rect.y; }
        set { _rect.y = value; }
    }

    public int Width
    {
        get { return (int) _rect.width; }
        set { _rect.width = value; }
    }

    public int Height
    {
        get { return (int) _rect.height; }
        set { _rect.height = value; }
    }

    public int Right
    {
        get { return (int) _rect.x + (int) _rect.width; }
    }

    public int Bottom
    {
        get { return (int) _rect.y + (int) _rect.height; }
    }

    public Rectangle(int x, int y, int width, int height)
    {
        _rect = new Rect(x, y, width, height);
    }

    public bool IntersectsWith(Rectangle rectangle)
    {
        return _rect.Overlaps(rectangle._rect);
    }
}
