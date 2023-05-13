using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Inventory.Sql;
namespace Inventory
{
	public partial class productinbound : System.Web.UI.Page
	{
		SqlHelper sqlHelper;
		Product product;
		int product_id ;
		protected void Page_Load(object sender, EventArgs e)
		{
			//After finished the param in get product should be changed to the link param 
			sqlHelper = new SqlHelper();
			product_id = int.Parse(Request.QueryString["productid"].ToString());
			product = sqlHelper.GetProduct(product_id);
		}

		protected void Page_PreRender(object sender, EventArgs e)
		{
			//lblProductId.Text = "Product ID: " + product_id;
			//lblProductDesc_Pre.Text = product.Product_Desc;
			lblProductDesc.Text = product.Product_Desc;
			//lblProductName_Pre.Text = product.Product_Name;
			lblProductName.Text = product.Product_Name;

		}

		protected void btnInbound_Click(object sender, EventArgs e)
		{
			Product p = new Product();
			p.Product_Id = product.Product_Id;
			p.Product_Qty = int.Parse(tbQuantity.Text);
			//lblMessage.Text = p.Product_Name + p.Product_Desc;
			int i = sqlHelper.InboundProduct(p);
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