using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CollectionAndControls
{
    public class Emp
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public static List<Emp> GetEmps()
        {
            return new List<Emp>()
            {
                new Emp(){ Id=10, Name= "Amar"},
                new Emp(){ Id=11, Name= "Akash"},
                new Emp(){ Id=13, Name= "Ashok"},
            };
        }
    }
}
