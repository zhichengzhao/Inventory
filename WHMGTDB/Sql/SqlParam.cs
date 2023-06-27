using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WHMGTDB.Sql
{
    public class SQL_PM
    {
        public static SqlParameter IntPM(string t, int v)
        {
            SqlParameter p = new SqlParameter();
            p.ParameterName = t;
            p.DbType = DbType.Int32;
            p.Value = v;
            return p;
        }
        public static SqlParameter StringPM(string t, string v) {
            return new SqlParameter(t, v);
        }   
        public static SqlParameter IntReturnPM(string t)
        {
            SqlParameter p = new SqlParameter();
            p.ParameterName = t;
            p.DbType = DbType.Int32;
            //p.Value = 0;
            p.Direction = ParameterDirection.ReturnValue;
            return p;
        }
        
    }
}
