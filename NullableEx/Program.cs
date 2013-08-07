using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NullableEx
{
    class Program
    {
        static void Main(string[] args)
        {
            int? n = 10;
            if(n.HasValue)
               Console.WriteLine(n.Value);
            // ?? - coalesce operator
            int value = n ?? 0;
            Console.WriteLine(value);

            int no = default(int);
            Console.WriteLine(no);
            for (float i = default(float); i <= 10; i++)
            {

            }
        }
    }
}
