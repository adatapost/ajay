using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class MyCollection : IEnumerable<int>
{
    int[] no = { 11, 22, 33, 44 };
    public IEnumerator<int> GetEnumerator()
    {
        foreach (var n in no)
            yield return n;
    }

    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return no.GetEnumerator();
    }
}

class MainApp
{
    static void Main1()
    {
        MyCollection collection = new MyCollection();
        foreach (var t in collection)
        {
            Console.WriteLine(t);
        }
    }

    public delegate bool Filter<T>(T value);
    static IEnumerable<int> GetInts()
    {
        int[] nos = { 11, 2, 4, 55, 66, 8, 55, 33, 44, 22 };
        foreach (var t in nos)
            yield return t;
    }
    static IEnumerable<int> GetInts(Filter<int> condition)
    {
        int[] nos = { 11, 2, 4, 55, 66, 8, 55, 33, 44, 22 };
        foreach (var t in nos)
        {
            if(condition(t))
               yield return t;
        }
    }
    static void Main()
    {
        foreach (var t in GetInts())
            Console.WriteLine(t);

        Filter<int> above20 = (x) => x > 20;
        Filter<int> between10And40 = (x) => x >= 10 && x <= 40;
        Console.WriteLine("Above 20");
        foreach (var t in GetInts(above20))
            Console.WriteLine(t);
        Console.WriteLine("10 to 40");
        foreach (var t in GetInts(between10And40))
            Console.WriteLine(t);

        
    }
}