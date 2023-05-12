using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Inventory.Sql;

namespace Inventory
{
	public partial class AddProduct : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}
		protected void btnAddProduct_Click(object sender, EventArgs e)
		{
			if(tbProductName.Text.Equals("") || tbProductName.Text == null) { lblMessage.Text = "Product name can not be empty."; return; }

			SqlHelper sqlHelper = new SqlHelper();
			Product product = new Product();
			product.Product_Name = tbProductName.Text;
			product.Product_Desc = tbProductDesc.Text;
			if (sqlHelper.AddProduct(product) == 1)
			{
				Response.Redirect("Inventory.aspx");
			}
			else
			{
				lblMessage.Text = "Product not added.";
			}
			
		}

		protected void btnCancel_Click(object sender, EventArgs e)
		{
			Response.Redirect("Inventory.aspx");
		}
	}
}