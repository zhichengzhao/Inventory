<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inventory.aspx.cs" Inherits="Inventory.Inventory" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblMessage" runat="server" Text="?"></asp:Label>
        <asp:Button ID="btnAddProduct" runat="server" Text="AddProduct" OnClick="btnAddProduct_Click" />
        <asp:Button ID="btnLogout" runat="server" Text="Log Out" OnClick="btnLogout_Click" />
        <div>
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="product_Id" DataSourceID="SqlDataSource1" AllowCustomPaging="True" PageSize="50" >
                <Columns>
                    <asp:BoundField DataField="product_Id" HeaderText="product_Id" InsertVisible="False" ReadOnly="True" SortExpression="product_Id" />
                    <asp:BoundField DataField="product_name" HeaderText="product_name" SortExpression="product_name" />
                    <asp:BoundField DataField="product_description" HeaderText="product_description" SortExpression="product_description" />
                    <asp:BoundField DataField="product_quantity" HeaderText="product_quantity" SortExpression="product_quantity" />
                    <asp:TemplateField HeaderText="Action">
                        <ItemTemplate>
                            <asp:Button ID="btnEdit" runat="server"  Text="Edit" OnClick="btnEdit_Click" />
                            <asp:Button ID="btnInbound" runat="server" Text="Inbound" OnClick="btnInbound_Click" />
                            <asp:Button ID="btnOutbound" runat="server" Text="OutBound" OnClick="btnOutbound_Click" />
                            
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <PagerSettings Mode="NumericFirstLast" Position="TopAndBottom" />
            </asp:GridView>
        </div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Warehouse %>" 
            SelectCommand="SELECT * FROM [products]"></asp:SqlDataSource>
        <div>


        </div>

    </form>
</body>
</html>
