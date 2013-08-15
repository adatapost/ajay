using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class ExtensionMethods
{
    static void Main()
    {
      /*  int n = default(int);
        Console.WriteLine(n);*/

        int[] nos = { 11, 22, 33, 44 };

        var value = nos.Where(x => x == 5).ToList();
        Console.WriteLine(value.Count);

        var value1 = nos.Where(x => x == 111).SingleOrDefault();

    }
    static void Main4()
    {
        int[] nos = { 2, 1, 2, 4, 5, 6, 7, 8, 9, 4, 5, 3, 5, 6, 2 };

        var firstFive = nos.Take(5);
        foreach (var t in firstFive)
            Console.WriteLine(t);

        foreach (var t in nos.Skip(5).Take(5))
            Console.WriteLine(t);
    }
    static void Main3()
    {
        int[] nos = { 2, 1, 2, 4, 5, 6, 7, 8, 9, 4, 5, 3, 5, 6, 2 };

        foreach (var t in nos.OrderBy(x => x))
            Console.WriteLine(t);

        var result = nos.GroupBy(x => x).ToList();
        Console.WriteLine("-----");
        foreach (var t in result)
            Console.WriteLine(t.Key + " " + t.Count());


    }
    static void Main2()
    {
        int[] nos = { 3, 4, 5, 66, 7, 88, 9 };
        var result = nos.Where((x) => x > 20)
                         .Select((y) => new
                         {
                             No = y,
                             Square = y * y,
                             Cube = y * y * y
                         }).ToList();

        foreach (var t in result)
        {
            Console.WriteLine(t.No + " " + t.Square + " " + t.Cube);
        }
    }
    static void Main1()
    {
        int[] nos = { 3, 4, 5, 66, 7, 88, 9 };

        Func<int,bool> above20 = (x) => x >20;
        var query = nos.Where(above20);
        foreach (var no in query)
            Console.WriteLine(no);
    }
}


class Test
{
    static void Main8()
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