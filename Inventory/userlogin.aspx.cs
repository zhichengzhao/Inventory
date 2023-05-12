using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Inventory
{
	public partial class user_login : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void btnRegister_Click(object sender, EventArgs e)
		{
			Response.Redirect("userregister.aspx");
		}

		protected void btnLogin_Click(object sender, EventArgs e)
		{
			Response.Redirect("Inventory.aspx");
		}

		protected void btnForgetPass_Click(object sender, EventArgs e)
		{
			Response.Redirect("userforgetpass.aspx");
		}
	}
}