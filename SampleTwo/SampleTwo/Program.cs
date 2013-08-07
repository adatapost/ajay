using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SampleTwo
{
    public class Student
    {
        public int Roll { get; set; }
        public string Name { get; set; }

        public Student()
        {
            Name = string.Empty ; // "" or string.Empty empty string

        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Student std = new Student();
            std.Roll = 10;
            Console.WriteLine(std.Roll);
            Console.WriteLine(string.IsNullOrEmpty(std.Name));
            Console.WriteLine(std.Name.Length );


            Student stdOne = new Student()
            {
                 Name = "AA",
                 Roll = 10
            };
            Console.WriteLine(stdOne.Roll + "  " + stdOne.Name);
        }
    }
}

