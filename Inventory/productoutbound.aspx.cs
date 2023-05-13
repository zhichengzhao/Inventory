using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Inventory.Sql;

namespace Inventory
{
	public partial class productoutbound : System.Web.UI.Page
	{
		SqlHelper sqlHelper;
		Product product;
		int product_id;
		protected void Page_Load(object sender, EventArgs e)
		{
			//After finished the param in get product should be changed to the link param 
			sqlHelper = new SqlHelper();
			product_id = int.Parse(Request.QueryString["productid"].ToString());
			product = sqlHelper.GetProduct(product_id);
		}

		protected void btnOutbound_Click(object sender, EventArgs e)
		{
			Product p = new Product();
			p.Product_Id = product.Product_Id;
			p.Product_Qty = int.Parse(tbQuantity.Text);
			//lblMessage.Text = p.Product_Name + p.Product_Desc;
			int i = sqlHelper.OutboundProduct(p);
			if (i == 1)
				Response.Redirect("Inventory.aspx");
			else
				lblMessage.Text = "Something's wrong" + i;
		}

		protected void btnCancel_Click(object sender, EventArgs e)
		{
			Response.Redirect("Inventory.aspx");
		}
	}
}