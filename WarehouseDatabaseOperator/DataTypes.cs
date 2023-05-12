using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;

namespace WarehouseDatabaseOperator
{
	//data that can be used for sql param
	//support int string 
	public class UniversalData<T>
	{
		public T DataValue { get; set; }
		public string SqlParamString { get; set; }
		public SqlDbType SqlDataType { get; set; }

		public UniversalData(T value, string paramString)
		{
			switch(typeof(T).ToString())
			{
				case "int" : SqlDataType = SqlDbType.Int; break;
				case "string": SqlDataType = SqlDbType.VarChar; break;
				default: SqlDataType = SqlDbType.VarChar; break;
			}
			DataValue = value;
			SqlParamString = paramString;
		}
	}
	

	public class SqlHelper <T>
	{
		
	}
}