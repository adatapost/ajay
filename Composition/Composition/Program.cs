using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composition
{
    public class Subject
    {
        public string Name { get; set; }
        public int TotalMarks { get; set; }
    }
    public class Exam
    {
        public Subject Subject { get; set; }
        public string Date { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Exam exam = new Exam()
            {
                Date = "1/1/2002",
                Subject = new Subject()
                {
                     Name = "Maths",
                      TotalMarks = 100
                }
            };


            Exam exm = new Exam();
            exm.Subject = new Subject()  { TotalMarks = 100, Name = "Eng" };
            exm.Date = "1/1/2002";

        }
    }
}
