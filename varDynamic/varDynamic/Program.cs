using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace varDynamic
{
  
    class Program
    {
        static void Main(string[] args)
        {
            dynamic n = 10;
            
            var emp = new 
            {
                 No = n,
                 Name = "Rajesh",
                 JoinDate = DateTime.Parse("12/31/2002")
            };

            Console.WriteLine(emp.No + " " + emp.Name + emp.JoinDate);

            
        }
    }
}
