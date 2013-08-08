using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Emp : IComparable<Emp>
{
    public int ID { get; set; }
    public string Name { get; set; }
   public int CompareTo(Emp other)
    {
        if (ID == other.ID) return 0;
        if (ID > other.ID) return 1;
        return -1;
    }
}

class Test
{
    static void Main1()
    {
        SortedSet<Emp> emps = new SortedSet<Emp>();
        emps.Add(new Emp() { ID=1, Name="A" });
        emps.Add(new Emp() { ID = 4, Name = "A" });
        emps.Add(new Emp() { ID = 2, Name = "B" });

        foreach (var emp in emps)
            Console.WriteLine(emp.ID + " " + emp.Name);
    }

    static void Main()
    {
        Dictionary<string, List<string>> country = new Dictionary<string, List<string>>();
        country.Add("India", new List<string>() {"Guj","Raj" });
        country.Add("USA", new List<string>() { "Alb"});

        country["USA"].Add("Ocl");
        country["India"].Add("Mah");

        foreach (var c in country)
        {
            Console.WriteLine(c.Key);
            foreach (var s in c.Value)
            {
                Console.WriteLine("\t" + s);
            }
        }

    }
}