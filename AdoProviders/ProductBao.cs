using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;

namespace AdoProviders
{
    public class ProductBao
    {
        public static bool AddProduct(int id, string name, decimal rate)
        {
            try
            {
                ProductDao.AddProduct(id, name, rate);
                return true;
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex, "ProductBao");
            }
            return false;
        }
    }
}
