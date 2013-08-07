using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Maths
{
    public   const int VALUE = 10;
    public readonly int MAX = 10;

    public Maths(int max)
    {
        MAX = max;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Maths.VALUE);

        Maths maths = new Maths(902);
        Console.WriteLine(maths.MAX);
      //  maths.MAX = 29;
    }
}

