using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Emp
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Dept { get; set; }
    public double Salary { get; set; }

    public static List<Emp> GetEmps()
    {
        return new List<Emp>()
           {
     new Emp() { FirstName = "Raj", Salary=333, LastName = "Patel", Dept = "Acc"},
     new Emp() { FirstName = "Man", Salary=77, LastName = "Patel", Dept = "Prd"},
     new Emp() { FirstName = "Ram", Salary =999, LastName = "Shah", Dept = "Acc"},
      new Emp() { FirstName = "Ram1", Salary =999, LastName = "Shah", Dept = "Prd"},
       new Emp() { FirstName = "Ram2", Salary =999, LastName = "Shah", Dept = "Acc"},
        new Emp() { FirstName = "Ram3", Salary =999, LastName = "Shah", Dept = "Prd"},
         new Emp() { FirstName = "Ram4", Salary =999, LastName = "Shah", Dept = "Acc"},
            };
    }
}