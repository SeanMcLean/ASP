<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="MyWebSite.Pages.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="lblHeading" runat="server" Text="Please enter Username &amp; Password "></asp:Label>
        <br />
        <br />
        <asp:Label ID="lblUsername" runat="server" Text="Username:"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="tbxUsername" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblPassword" runat="server" Text="Password:"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="tbxPassword" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Login" />
    
    </div>
    </form>
</body>
</html>
