using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace First
{
    public class Student
    {
        //fields must be private

        int roll;            //default access is private 
        private string name;
        private static string school;


        //instance constructor

        public Student(int roll, string name)
        {
            if (roll >= 1 && roll <= 100)
            {
                this.roll = roll;
            }

            this.name = name == null ? "" : name;
        }

        public Student(String name, int roll) :
            this(roll, name) // To select another construct
        { }                    //   of "same" class

        public Student() : this(0, "") { }

        // static constructor
        // cannot use "access" modifier -- it must be private
        // and it will be called atmost once when we access any
        // memeber of that class very first

        static Student()
        {
            school = "The ABC School";
        }

        // Instance methods
        // These methods also called "data-wrapper" or
        // Data encapsulation methods
        public int GetRoll() { return roll; }
        public String GetName() { return name; }
        public void SetRoll(int roll) { this.roll = roll; }
        public void SetName(String name) { this.name = name; }

        //static method
        public static string GetSchool() { return school; }
        public static void SetSchool(String school)
        {
            Student.school = school;
        }

        //Extra methods
        public void Print()
        {
            string info = string.Format(@"
Roll : {0}
Name : {1}", roll, name);
            Console.WriteLine(info);
        }

    }

}
