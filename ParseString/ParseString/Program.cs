using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParseString
{
    class Program
    {
        static void Main()
        {
            DateTime date = DateTime.Now;

            date = date.AddDays(-10);
            Console.WriteLine(date);

            TimeSpan ts = DateTime.Now - DateTime.Parse("7/2/2013");
            Console.WriteLine(ts.TotalDays);
            Console.WriteLine(DateTime.Today);
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.UtcNow);
            
        }
        static void Main5()
        {
            var date = DateTime.Now;
            Console.WriteLine(date.ToString("dd-MMM-yy  HH:mm:ss tt  MMMM"));
        }
        static void Main4()
        {
            string str = "21.12.2003";

            string[] formats = { "dd-MM-yyyy","d-M-yyyy","dd/MM/yyyy","dd.MM.yyyy"};

            DateTime date;

            if (DateTime.TryParseExact(str, formats, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out date))
                Console.WriteLine(date);
            else
                Console.WriteLine("Invalid date format");
            

        }
        static void Main3()
        {
            string  str = null;
            int no;

            if (int.TryParse(str, out no))
                Console.WriteLine(no);
            else
                Console.WriteLine("Invalid " + no);
            
        }
        static void Main2()
        {
            var date = DateTime.Parse("12-31-2002 12:23:34 AM");
            Console.WriteLine(date);
        }
        static void Main1(string[] args)
        {
            string str = "aa";

            int no = Convert.ToInt32(str); // int.Parse(str);
            Console.WriteLine(no);

            

        }
    }
}
