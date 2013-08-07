using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

 


public class Student
{
    public int Roll { get; set; }
    public string Name { get; set; }
 
    public override bool Equals(object obj)
    {
        // Student refObj = obj as Student;
        // return Roll == refObj.Roll && Name.Equals(refObj.Name);
        return GetHashCode() == obj.GetHashCode();
    }

    public override int GetHashCode()
    {
        int hash = 0;
        hash = Roll.GetHashCode();
        if (Name != null)
            hash += Name.GetHashCode();
        return hash;
    }
    public override string ToString()
    {
        return Roll + " " + Name;
    }
      
}

class Test
{
    static void Main2()
    {
        int no = 10;
        float amount = 10.10f;
        Console.WriteLine(no.GetHashCode());
        Console.WriteLine(amount.GetHashCode());
        Console.WriteLine("Hello".GetHashCode());
    }
    static void Main()
    {
        Student s1 = new Student() {  Roll= 1, Name ="A"};
        Student s2 = new Student() { Roll = 1, Name = "A" };
        
        if (s2.Equals(s1))
            Console.WriteLine("Eq");
        else
            Console.WriteLine("Un");


        //Array of objects

        Student[] students =
        {
             new Student(){Roll = 1,Name ="R"},
             new Student(){Roll = 2,Name ="Q"},
             new Student(){Roll = 9,Name ="P"},
        };

        Console.WriteLine(Array.IndexOf(students, new Student(){ Roll=9,Name="P"}));

        //Dump the object data using ToString()
        foreach (var student in students)
            Console.WriteLine(student);
        Comparison<Student> byName = (x, y) => x.Name.CompareTo(y.Name);
      // Array.Sort(students,  (p,q) => p.Name.CompareTo(q.Name));
        Array.Sort(students, byName);
        foreach (var student in students)
            Console.WriteLine(student);
    }
}
class ByRollGen : System.Collections.Generic.IComparer<Student>
{
    public int Compare(Student x, Student y)
    {
        return x.Roll - y.Roll;
    }
}
class ByRoll : System.Collections.IComparer
{
    public int Compare(object x, object y)
    {
        return (x as Student).Roll - (y as Student).Roll;
    }
}
class ByName : System.Collections.IComparer
{
    public int Compare(object x, object y)
    {
        return (x as Student).Name.CompareTo((y as Student).Name);
    }
}