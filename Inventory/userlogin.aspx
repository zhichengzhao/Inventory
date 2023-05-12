<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="userlogin.aspx.cs" Inherits="Inventory.user_login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <asp:Label ID="lblUserName" runat="server" Text="UserName"></asp:Label><br />
            <asp:TextBox ID="tbUserName" runat="server"></asp:TextBox> <br />

             <asp:Label ID="lblUserPass" runat="server" Text="Password"></asp:Label><br />
            <asp:TextBox ID="tbUserPass" runat="server"></asp:TextBox> <br />

            <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
            <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" />
            <asp:Button ID="btnForgetPass" runat="server" Text="ForgetPass" OnClick="btnForgetPass_Click"  />
        </div>
    </form>
</body>
</html>
