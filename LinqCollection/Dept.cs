using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Dept
{
    public string DeptName { get; set; }
    public string Location { get; set; }

    public static List<Dept> GetDepts()
    {
        return new List<Dept>()
        {
            new Dept() { DeptName= "Acc", Location="Meh" },
            new Dept() { DeptName= "Prd", Location="Ahm" },
            new Dept() { DeptName= "HR", Location="Mum" },
        };
    }
}