using Inventory.Sql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Inventory
{
	public partial class ProductEditingPage : System.Web.UI.Page
	{	
		SqlHelper sqlHelper;
		Product product;
		protected void Page_Load(object sender, EventArgs e)
		{
			sqlHelper = new SqlHelper();
			product = sqlHelper.GetProduct(1);
			lblProductId.Text = "Product ID: "+product.Product_Id;
			lblProductDesc_Pre.Text = product.Product_Desc;
			lblProductName_Pre.Text = product.Product_Name;
		}

		protected void btnCancel_Click(object sender, EventArgs e)
		{
			Response.Redirect("Inventory.aspx");
		}
	}
}