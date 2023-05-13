using System;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace Inventory
{
	public partial class Inventory : System.Web.UI.Page
	{
		string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\zhicheng\\source\\repos\\Inventory\\Inventory\\App_Data\\Warehouse.mdf;Integrated Security=True";
		
		protected void Page_Load(object sender, EventArgs e)
		{

		}

        

		protected void btnEdit_Click(object sender, EventArgs e)
		{
			Button b = (Button)sender;
			DataControlFieldCell f = (DataControlFieldCell)b.Parent;
			GridViewRow gvr = (GridViewRow)f.Parent;
			int i = gvr.RowIndex;
			lblMessage.Text = "you click on the " + gvr.RowIndex + "row";
			int productid = int.Parse(GridView1.Rows[i].Cells[0].Text);
			lblMessage.Text = "you click on the " + gvr.RowIndex + "row. product id is "+productid;
			string page = "productedit.aspx?productid=" + productid;
			Response.Redirect(page,true);
		}

		protected void btnAddProduct_Click(object sender, EventArgs e)
		{
			Response.Redirect("productadd.aspx");
		}

        protected void btnLogout_Click(object sender, EventArgs e)
        {
			Response.Redirect("userlogin.aspx");
		}

		protected void btnOutbound_Click(object sender, EventArgs e)
		{
			Button b = (Button)sender;
			DataControlFieldCell f = (DataControlFieldCell)b.Parent;
			GridViewRow gvr = (GridViewRow)f.Parent;
			int i = gvr.RowIndex;
			//lblMessage.Text = "you click on the " + gvr.RowIndex + "row";
			int productid = int.Parse(GridView1.Rows[i].Cells[0].Text);
			//lblMessage.Text = "you click on the " + gvr.RowIndex + "row. product id is " + productid;
			string page = "productoutbound.aspx?productid=" + productid;
			Response.Redirect(page);
		}

		protected void btnInbound_Click(object sender, EventArgs e)
		{
			Button b = (Button)sender;
			DataControlFieldCell f = (DataControlFieldCell)b.Parent;
			GridViewRow gvr = (GridViewRow)f.Parent;
			int i = gvr.RowIndex;
			lblMessage.Text = "you click on the " + gvr.RowIndex + "row";
			int productid = int.Parse(GridView1.Rows[i].Cells[0].Text);
			lblMessage.Text = "you click on the " + gvr.RowIndex + "row. product id is " + productid;
			string page = "productinbound.aspx?productid=" + productid;
			Response.Redirect(page);
		}
	}
}