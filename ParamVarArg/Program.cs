using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Test
{
    static int sum(params int[] nos)
    {
        int total = 0;
        for (int i = 0; i < nos.Length; i++)
        {
            total = total + nos[i];
        }
        return total;
    }
    static void printCities(params string[] cities)
    {
    }
    static void Main()
    {
        printCities("a", "d", "e");
        Console.WriteLine(sum(10, 20, 30));
        Console.WriteLine(sum());
        Console.WriteLine(sum(10, 20, 30, 66, 77));
        Console.WriteLine(sum(new int[] { 1, 2, 3 }));
    }
}

