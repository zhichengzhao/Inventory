using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Inventory.Sql
{
	public class SqlHelper
	{
		string connstring = "";
		SqlConnection conn = null;

		public SqlHelper() {
			connstring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\zhicheng\\source\\repos\\Inventory\\Inventory\\App_Data\\Warehouse.mdf;Integrated Security=True";
			conn = new SqlConnection(connstring);
		}

		//name, desc is require. other input will be ignored.
		public int AddProduct(Product p) { 
			List<SqlParameter> pram = p.ParamList(true);
			SqlCommand sqlCommand = new SqlCommand();
			sqlCommand.Connection = conn;
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "Products_AddProduct";
			foreach (SqlParameter s in pram) sqlCommand.Parameters.Add(s);
			conn.Open();
			sqlCommand.ExecuteNonQuery();
			conn.Close();
			int result = (int)sqlCommand.Parameters["@result"].Value;
			return result;
		}

		//product id is required. 
		public int RemoveProduct(Product p)
		{
			List<SqlParameter> pram = p.ParamList(true);
			SqlCommand sqlCommand = new SqlCommand();
			sqlCommand.Connection = conn;
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "Products_AddProduct";
			foreach (SqlParameter s in pram) sqlCommand.Parameters.Add(s);
			conn.Open();
			sqlCommand.ExecuteNonQuery();
			conn.Close();
			int result = (int)sqlCommand.Parameters["@result"].Value;
			return result;
		}

		//product id is required. 
		public Product GetProduct(int id)
		{
			Product product = new Product();
			product.Product_Id = id;
			//List<SqlParameter> pram = GenerateParam(product,false);
			SqlCommand sqlCommand = new SqlCommand();
			sqlCommand.Connection = conn;
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "Products_GetProduct";
			//foreach (SqlParameter s in pram) sqlCommand.Parameters.Add(s);

			SqlParameter s1;
			s1 = new SqlParameter();
			s1.ParameterName = "@product_id";
			s1.DbType = DbType.Int32;
			s1.Value = id;
			sqlCommand.Parameters.Add(s1);

			conn.Open();
			try
			{
				SqlDataReader r = sqlCommand.ExecuteReader();
				if (r.Read())
				{
					product.Product_Name = r["product_name"].ToString();
					product.Product_Desc = r["product_description"].ToString();
					product.Product_Qty = (int)r["product_quantity"];
				}
				else
					product.Product_Name = "no data.";
			}
			catch (Exception ex)
			{
				conn.Close();
			}
			conn.Close();
			return product;
		}


	}
}