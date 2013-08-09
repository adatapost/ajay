using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Test
{
    static void Main()
    {
        //1. Select or Identify the Datasource
        int[] nos = { 22, 3, 1, 4, 5, -66, 7, 8, 44 };

        //2. Define the query (LINQ) or expression
        int m = 1;

        IEnumerable<int> query = from no in nos
                                 where no>m
                                 select no;
        //3. Execute the "query" or "expresion"
        //   Deffered execution of query

        m = 30;
        foreach (var no in query)
        {
            Console.WriteLine(no);
        }
        m = 10;
        foreach (var no in query)
        {
            Console.WriteLine(no);
        }
    }
}