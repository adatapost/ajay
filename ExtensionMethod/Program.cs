using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Test
{
    static void Main()
    {
        string str = "The       re d         sun";
        Console.WriteLine(str.WordCount());
        int no = 10;
        Console.WriteLine(no.Square());
        decimal value = 1000;
        Console.WriteLine(value.Square());

        int[] ar = { 11, 22, 3, 4, 55 };
        Console.WriteLine(ar.Sum());
    }
}
public static class MyExtension
{
    public static int WordCount(this string str)
    {
        return str.Split(new string[] { " ", "\n", "\t" }, StringSplitOptions.RemoveEmptyEntries).Length;
    }
    public static ValueType Square(this ValueType n)
    {
        return n;
    }
    public static int Sum(this int[] ar)
    {
        int s = 0;
        foreach (var t in ar)
            s = s + t;
        return s;
    }
}

 