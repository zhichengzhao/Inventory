<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="productinbound.aspx.cs" Inherits="Inventory.productinbound" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <div>
            <asp:Label ID="lblProductName" runat="server" Text="Product Name"></asp:Label><br /> 
            <asp:Label ID="lblProductDesc" runat="server" Text="Product Description"></asp:Label><br />
             <asp:TextBox ID="tbQuantity" runat="server" TextMode="Number"></asp:TextBox><br />
            <asp:Button ID="btnInbound" runat="server" Text="Inbound Product" OnClick="btnInbound_Click" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" /><br />
            <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label><br />
        </div>
    </form>
</body>
</html>
