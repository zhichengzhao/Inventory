using Inventory.Sql;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WHMGTDB.Sql
{
    public partial class SqlHelper
    {
        //param: product name, product desc
        public int AddProduct(Product p)
        {
            SqlCommand c = Sqlcmd(conn, "Products_AddProduct");
            foreach (SqlParameter s in p.ParamList(true)) c.Parameters.Add(s);
            c.Connection.Open();
            c.ExecuteNonQuery();
            c.Connection.Close();
            int result = (int)c.Parameters["@result"].Value;
            return result;
        }

        //param: product id
        public int RemoveProduct(Product p)
        {
            SqlCommand c = Sqlcmd(conn, "Products_RemoveProduct");
            foreach (SqlParameter s in p.ParamList(false)) c.Parameters.Add(s);
            conn.Open();
            int result = c.ExecuteNonQuery();
            conn.Close();
            return result;
        }

        //param: product id
        public Product GetProduct(Product p)
        {
            SqlCommand c = Sqlcmd(conn, "Products_GetProduct");
            foreach (SqlParameter s in p.ParamList(false)) c.Parameters.Add(s);
            try
            {
                conn.Open();
                SqlDataReader r = c.ExecuteReader();
                conn.Close();

                if (r.Read())
                {
                    p.Product_Name = r["product_name"].ToString();
                    p.Product_Desc = r["product_description"].ToString();
                    p.Product_Qty = (int)r["product_quantity"];
                }
                else
                    p.Product_Name = "no data.";
            }
            catch (Exception ex)
            {
                conn.Close();
            }
            conn.Close();
            return p;
        }

        //param: product id, product name, product desc
        public int EditProduct(Product p)
        {
            SqlCommand c = Sqlcmd(conn, "Products_EditProduct");
            foreach (SqlParameter s in p.ParamList(false)) c.Parameters.Add(s);
            conn.Open();
            int result = c.ExecuteNonQuery();
            conn.Close();
            return result;
        }
        //param: product id, product qty
        public int InboundProduct(Product p)
        {
            SqlCommand c = Sqlcmd(conn, "Products_Inbound");
            foreach (SqlParameter s in p.ParamList(true)) c.Parameters.Add(s);
            conn.Open();
            c.ExecuteNonQuery();
            conn.Close();
            int result = (int)c.Parameters["@result"].Value;
            return result;
        }

        //param: product id, product qty
        public int OutboundProduct(Product p)
        {

            SqlCommand c = Sqlcmd(conn, "Products_Outbound");
            foreach (SqlParameter s in p.ParamList(true)) c.Parameters.Add(s);
            conn.Open();
            c.ExecuteNonQuery();
            conn.Close();
            int result = (int)c.Parameters["@result"].Value;
            return result;
        }
    }
}
