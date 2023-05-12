using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Inventory
{
	public partial class registeruser : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void btnCancel_Click(object sender, EventArgs e)
		{
			Response.Redirect("userlogin.aspx");
		}

		protected void btnRegister_Click(object sender, EventArgs e)
		{
			Response.Redirect("userlogin.aspx");
		}
	}
}