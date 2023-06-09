﻿using Inventory.Sql;
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
		int product_id = 1;
		protected void Page_Load(object sender, EventArgs e)
		{
			//After finished the param in get product should be changed to the link param 
			sqlHelper = new SqlHelper();
			product_id = int.Parse(Request.QueryString["productid"].ToString());
			product = sqlHelper.GetProduct(product_id);
		}

		protected void Page_PreRender(object sender, EventArgs e)
		{
			lblProductId.Text = "Product ID: " + product_id;
			//lblProductDesc_Pre.Text = product.Product_Desc;
			tbProductDesc.Text = product.Product_Desc;
			//lblProductName_Pre.Text = product.Product_Name;
			tbProductName.Text = product.Product_Name;

		}

		protected void btnCancel_Click(object sender, EventArgs e)
		{
			Response.Redirect("Inventory.aspx");
		}

        protected void btnSave_Click(object sender, EventArgs e)
        {
			Product product1 = new Product();
			product1.Product_Id = product.Product_Id;
			product1.Product_Name = tbProductName.Text;
			product1.Product_Desc = tbProductDesc.Text;
			lblMessage.Text = product1.Product_Name + product1.Product_Desc;
			int i = sqlHelper.EditProduct(product1);
			
			if (i == 1)
				Response.Redirect("Inventory.aspx");
			else
				lblMessage.Text = "Something's wrong";
		}

        protected void btnRemove_Click(object sender, EventArgs e)
        {
			Product product1 = new Product();
			product1.Product_Id = product.Product_Id;
			int i = sqlHelper.RemoveProduct(product1);
			if (i == 1)
				Response.Redirect("Inventory.aspx");
			else
				lblMessage.Text = "Something's wrong";
		}
    }
}