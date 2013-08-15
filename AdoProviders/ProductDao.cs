using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace AdoProviders
{
    public class ProductDao
    {
        public static bool AddProduct(int id, string name, decimal rate)
        {
            string cnStr = @"Data Source=.\SQLEXPRESS;AttachDbFilename=c:\csnet\Ajay\AdoProviders\SampleDb.mdf;Integrated Security=True;User Instance=True";
            using (SqlConnection cn = new SqlConnection(cnStr))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "insert into product values (@productid, @productname,@productrate)";
                    cmd.Parameters.Add("@productid", SqlDbType.Int).Value = id;
                    cmd.Parameters.Add("@productname", SqlDbType.VarChar, 10).Value = name;
                    cmd.Parameters.Add("@productrate", SqlDbType.Decimal).Value = rate;

                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    return true;
                }
            }
        }
    }
}
