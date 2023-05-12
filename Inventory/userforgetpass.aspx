<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="userforgetpass.aspx.cs" Inherits="Inventory.userforgetpass" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        Reset your password
        <div>
             <asp:Label ID="lblUserName" runat="server" Text="UserName"></asp:Label><br />
            <asp:TextBox ID="tbUserName" runat="server"></asp:TextBox> <br />

             <asp:Label ID="lblUserPass" runat="server" Text="Password"></asp:Label><br />
            <asp:TextBox ID="tbUserPass" runat="server"></asp:TextBox> <br />

            <asp:Button ID="btnReset" runat="server" Text="Reset" OnClick="btnReset_Click"  />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click"  />

        </div>
    </form>
</body>
</html>
