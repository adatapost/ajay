using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

#region Method Parameters
class MethorPara
{
    static void CalledByValue(int n)
    {
        n = 10;
    }
    static void CalledByOut(out int n)
    {

        n = 10;
    }
    static void CalledByRef(ref int n)
    {
        n = 10;
    }
    static void Main()
    {
        int i = 1;
        CalledByValue(i);
        Console.WriteLine(i);

        CalledByOut(out i);
        Console.WriteLine(i);
        CalledByRef(ref i);
        Console.WriteLine(i);

    }
}
#endregion