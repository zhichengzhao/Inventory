using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace Inventory.Sql
{
	public class Product
	{
		public int Product_Id { get; set; }
		public string Product_Name { get; set; }
		public string Product_Desc { get; set; }
		public int Product_Qty { get; set; }
		public int User_id { get; set; }

		public List<SqlParameter> ParamList(bool returnvalueneed)
		{
			SqlParameter s1 = null;
			List<SqlParameter> parameters = new List<SqlParameter>();

			if (Product_Name != null && !Product_Name.Equals("")) { parameters.Add(new SqlParameter("@product_name", Product_Name)); }
			if (Product_Desc != null && !Product_Desc.Equals("")) { parameters.Add(new SqlParameter("@product_desc", Product_Desc)); }
			if (Product_Id > 0)
			{
				s1 = new SqlParameter();
				s1.ParameterName = "@product_id";
				s1.DbType = DbType.Int32;
				s1.Value = Product_Id;
				parameters.Add(s1);
			}
			if (Product_Qty > 0)
			{
				s1 = new SqlParameter();
				s1.ParameterName = "@product_qty";
				s1.DbType = DbType.Int32;
				s1.Value = Product_Qty;
				parameters.Add(s1);
			}
			if (returnvalueneed)
			{
				s1 = new SqlParameter();
				s1.ParameterName = "@result";
				s1.DbType = DbType.Int32;
				s1.Value = 0;
				s1.Direction = ParameterDirection.ReturnValue;
				parameters.Add(s1);
			}
			if (User_id > 0)
			{
				s1 = new SqlParameter();
				s1.ParameterName = "@user_id";
				s1.DbType = DbType.Int32;
				s1.Value = Product_Id;
				parameters.Add(s1);
			}
			return parameters;
		}
	}

	public class user
	{
		public int User_Id { get; set; }
		public string User_Name { get; set;}
		public string User_Pass { get; set;}

		public List<SqlParameter> ParamList(bool returnvalueneed)
		{
			SqlParameter s1 = null;
			List<SqlParameter> parameters = new List<SqlParameter>();

			if (User_Name != null && !User_Name.Equals("")) { parameters.Add(new SqlParameter("@user_name", User_Name)); }
			if (User_Pass != null && !User_Pass.Equals("")) { parameters.Add(new SqlParameter("@user_pass", User_Pass)); }
			if (User_Id > 0)
			{
				s1 = new SqlParameter();
				s1.ParameterName = "@user_id";
				s1.DbType = DbType.Int32;
				s1.Value = User_Id;
				parameters.Add(s1);
			}
			return parameters;
		}
	}
}