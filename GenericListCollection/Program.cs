using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Test
{
    static void Main()
    {
        Students students = new Students();
        students.Add(new Student() { Roll = 10, Name = "Raj" });
        students.Add(new Student() { Roll = 20, Name = "Man" });
        
        Student search = new Student() { Roll = 10, Name = "Raj" };

        Console.WriteLine(students.Contains(search,new StudentCompareByRoll()));
        students.Remove(search);
        foreach (var t in students)
        {
            Console.WriteLine(t.Roll + " " + t.Name);
        }
    }
    static void Main3()
    {
        List<Student> students = new List<Student>();
        students.Add(new Student() { Roll=10, Name="Raj" });
        students.Add(new Student() { Roll = 20, Name = "Man" });


        Student search = new Student() {  Roll = 10, Name="Raj"};

        Console.WriteLine(students.Contains(search));
        foreach (var t in students)
        {
            Console.WriteLine(t.Roll + " " + t.Name);
        }
    }

    static void Main1()
    {
        List<string> cities = new List<string>()
        {
            "Meh","Pat","Raj","Sut"
        };
        cities.Add("Pal");
        cities.Insert(0, "Vis");

        Console.WriteLine(cities[0]);
        Console.WriteLine(cities.Contains("Meh"));
        Console.WriteLine(cities.Remove("Raj") ? "Removed" : "Not Exist");
        
        foreach (var city in cities)
            Console.WriteLine(city);

    }
}