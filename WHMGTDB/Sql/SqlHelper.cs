using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WHMGTDB.Sql
{
	public partial class SqlHelper
	{
		static string connstring = "Data Source=(LocalDB)\\MSSQLLocalDB;"+
			"AttachDbFilename=C:\\Users\\zhicheng\\source\\repos\\Inventory\\WHMGTDB\\warehousedatabase.mdf;Integrated Security=True";
		SqlConnection conn = null;

		public SqlHelper() {
			conn = new SqlConnection(connstring);
		}

		public SqlCommand Sqlcmd(SqlConnection conn, string procedure)
		{
            SqlCommand c = new SqlCommand();
            c.Connection = conn;
            c.CommandType = CommandType.StoredProcedure;
			c.CommandText = procedure;

            return c;
        }

	}
}