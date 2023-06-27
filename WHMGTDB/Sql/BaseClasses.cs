using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using WHMGTDB.Sql;
namespace Inventory.Sql
{
	public class Product
	{
		public int Product_Id { get; set; }
		public string Product_Name { get; set; }
		public string Product_Desc { get; set; }
		public int Product_Qty { get; set; }
		public int Product_CreatedByClient { get; set; }

		public List<SqlParameter> ParamList(bool returnvalueneed)
		{
			SqlParameter s1 = null;
            List<SqlParameter> parameters = new List<SqlParameter>();
			if (Product_Name != null && !Product_Name.Equals("")) { parameters.Add(SQL_PM.StringPM("@product_name", Product_Name)); }
			if (Product_Desc != null && !Product_Desc.Equals("")) { parameters.Add(SQL_PM.StringPM("@product_desc", Product_Desc)); }
			if (Product_Id > 0) { parameters.Add(SQL_PM.IntPM("@product_desc", Product_Id)); }
			if (Product_Qty > 0) { parameters.Add(SQL_PM.IntPM("@product_qty", Product_Qty)); }
			if (Product_CreatedByClient > 0) { parameters.Add(SQL_PM.IntPM("@client_id", Product_CreatedByClient)); }

            if (returnvalueneed) { parameters.Add(SQL_PM.IntReturnPM("@result")); }
			return parameters;
		}
	}

	public class Client
	{
		public int Client_Id { get; set; }
		public string Client_Name { get; set;}
		public string Client_Pass { get; set;}
		public List<SqlParameter> ParamList(bool returnvalueneed)
		{
			SqlParameter s1 = null;
			List<SqlParameter> parameters = new List<SqlParameter>();
			if (Client_Name != null && !Client_Name.Equals(""))  parameters.Add(SQL_PM.StringPM("@client_name", Client_Name)); 
			if (Client_Name != null && !Client_Name.Equals(""))  parameters.Add(SQL_PM.StringPM("@client_pass", Client_Pass)); 
			if (Client_Id > 0)	parameters.Add(SQL_PM.IntPM("@client_id", Client_Id));
			return parameters;
		}
	}
}