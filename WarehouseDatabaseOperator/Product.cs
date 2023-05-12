using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;

namespace WarehouseDatabaseOperator
{
	public class Product
	{
		public UniversalData<int> Product_Id { get; set; }
		public UniversalData<string> Product_Name { get; set; }
		public UniversalData<string> Product_Desc { get; set; }
		public UniversalData<int> Product_Qty { get; set; }

		public Product() {
			Product_Id = new UniversalData<int>( -1, "@product_id");
			Product_Name = new UniversalData<string>( "", "@product_id");
			Product_Desc = new UniversalData<string>( "", "@product_id");
			Product_Qty = new UniversalData<int>( -1, "@product_id");
		}


	}
}
