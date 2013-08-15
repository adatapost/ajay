using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace AdoProviders
{
    class Program
    {
        static void Main()
        {
            if (ProductBao.AddProduct(11, "R", 10.10m))
                Console.WriteLine("Added");
            else
                Console.WriteLine("See exception trace/log");
        }
        static void Main2()
        {
            try
            {
                ProductDao.AddProduct(2, "A", 34.33m);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }
        }
        static void Main1(string[] args)
        {
            string cnStr = @"Data Source=.\SQLEXPRESS;AttachDbFilename=c:\csnet\Ajay\AdoProviders\SampleDb.mdf;Integrated Security=True;User Instance=True";
            using (SqlConnection cn = new SqlConnection(cnStr))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "insert into product values (@productid, @productname,@productrate)";
                    cmd.Parameters.Add("@productid", SqlDbType.Int).Value = 10;
                    cmd.Parameters.Add("@productname", SqlDbType.VarChar, 10).Value = "More than 10 characters";
                    cmd.Parameters.Add("@productrate", SqlDbType.Decimal).Value = 10.10;

                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();

                }
            }
        }
    }
}
