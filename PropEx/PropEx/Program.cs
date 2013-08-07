using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Point
{
    public int X { get; set; }
    public int Y { get; set; }
}
public class Rect
{
    public Point Location { get; set; }
    public Point Size { get; set; }
}

class MainApp
{
    static void Main()
    {
        Rect rect = new Rect()
        {
            Size = new Point() { X = 190, Y = 20 },
            Location = new Point() { X = 100, Y = 200 }
        };

        Console.WriteLine(rect.Location.X + " " + rect.Location.Y);
        Console.WriteLine(rect.Size.X + " " + rect.Size.Y);
    }
}