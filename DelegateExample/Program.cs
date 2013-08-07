using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public delegate void SampleDel(int a,int b);
public delegate void TestDel();

class Test
{
     
    static void Main1()
    {
        SampleDel add = delegate(int x, int y)
        {
            Console.WriteLine(x + y);
        };
        SampleDel mul = delegate(int x, int y)
        {
            Console.WriteLine(x * y);
        };

        TestDel Line = () => Console.WriteLine("=====================");
        SampleDel Series = (no1, no2) =>
        {
            for (int i = no1; i <= no2; i++)
            {
                Console.WriteLine(i);
            }
        };
        Line();
        Series(3, 7);
        Calc(add);
        Calc(mul);
    }
    static void Calc(SampleDel task)
    {
        task(4, 5);
    }
    
}