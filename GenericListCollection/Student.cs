using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Student
{
    public int Roll { get; set; }
    public string Name { get; set; }
}

public class Students : List<Student> { }

public class StudentCompareByRoll : IEqualityComparer<Student>
{
    public bool Equals(Student x, Student y)
    {
        return x.Roll == y.Roll;
    }

    public int GetHashCode(Student obj)
    {
        throw new NotImplementedException();
    }
}

