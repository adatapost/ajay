using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Test
{
    static void Main()
    {
        var query = from e in Emp.GetEmps()
                    from d in Dept.GetDepts()
                    where e.Dept == d.DeptName
                    select e;
        foreach (var e in query)
        {
            Console.WriteLine(e.FirstName + " "+ e.LastName);
        }
    }


    static void Main7()
    {
        string[] words = {"this","is","that","is","that","those","this","that" };

        var query = from w in words
                    group w by w into wordgrup
                    select wordgrup;
        foreach (var k in query)
            Console.WriteLine(k.Key + "  : " + k.Count());

        string str = "asbash hwejwewhewe";
        var query1 = from c in str
                    group c by c into gc
                    select gc;
        foreach (var k in query1)
            Console.WriteLine(k.Key + "  : " + k.Count());

        var query2 = from e in Emp.GetEmps()
                     group e by e.Dept into g
                     select g;
        foreach (var d in query2)
            Console.WriteLine(d.Key + " : " + d.Count() + "  : ");

    }
    static void Main17()
    {
        var query = from e in Emp.GetEmps()
                    group e.Salary  by e.Dept into deptGroup
                    select deptGroup;

        foreach (var dept in query)
        {
            Console.WriteLine(dept.Key);
            foreach (var e in dept)
            {
                Console.WriteLine("\t" + e);
            }
        }
    }
    static void Main6()
    {
        var query = from e in Emp.GetEmps()
                    group e by e.Dept into deptGroup
                    select deptGroup;

        foreach (var dept in query)
        {
            Console.WriteLine(dept.Key);
            foreach (var e in dept)
            {
                Console.WriteLine("\t" + e.FirstName + " " + e.LastName);
            }
        }
    }
    static void Main5()
    {
        var query = from e in Emp.GetEmps()
                    orderby e.Dept descending
                    select e;
        foreach (var e in query)
            Console.WriteLine(e.FirstName + " " + e.LastName   + " " + e.Salary + " " + e.Dept);
    }
    static void Main4()
    {
        var query = from e in Emp.GetEmps()
                    select new Person
                    {
                         Name = e.FirstName + " " + e.LastName
                    };

        foreach (var p in query)
            Console.WriteLine(p.Name);
    }
    static void Main3()
    {
        string[] cities = { "Meh", "Patan", "Rajkot", "surat" };

        var query = from city in cities
                    select new
                        {
                            City = city,
                            UpperName  = city.ToUpper(),
                            LowerName = city.ToLower(),
                            Length = city.Length
                        };
                            
        foreach (var city in query)
            Console.WriteLine(city.City + " "+ city.Length + " " + city.UpperName);
    }
    static void Main1()
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