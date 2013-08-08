using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Emp
/// </summary>
public class Emp
{
    public int Id { get; set; }
    public string Name { get; set; }

    public static List<Emp> GetEmps()
    {
        return new List<Emp>()
        {
            new Emp(){ Id=1, Name="Amar"},
            new Emp(){ Id=11, Name="Amar"},
            new Emp(){ Id=21, Name="Amar"},
        };
    }

}