<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="productedit.aspx.cs" Inherits="Inventory.ProductEditingPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblProductId" runat="server" Text=""></asp:Label><br />

            <asp:Label ID="lblProductName" runat="server" Text="Product Name"> </asp:Label> <br />
            <asp:Label ID="lblProductName_Pre" runat="server" Text=""></asp:Label><br />
            <asp:TextBox ID="tbProductName" runat="server"></asp:TextBox> <br />

            <asp:Label ID="lblProductDesc" runat="server" Text="Product Description"></asp:Label><br />
            <asp:Label ID="lblProductDesc_Pre" runat="server" Text=""></asp:Label><br />
            <asp:TextBox ID="tbProductDesc" runat="server"></asp:TextBox> <br />

            <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click"  />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
            <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
