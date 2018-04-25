<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="MyWebSite.Pages.Login" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="../Styles/StyleSheet.css" type="text/css" />
    <link rel="stylesheet" href="../Styles/signin.css" type="text/css" />
    <link rel="stylesheet" href="../Styles/bootstrap.min.css" type="text/css" />

</head>
<body class="text-center">
    <form id="form1" runat="server" class="form-signin">
        <div>
<div class="container">
        <asp:Table ID="Table1" Class="form-signin" runat="server"             
            CellSpacing="50" BorderStyle="None" HorizontalAlign="Center" >
             <asp:TableRow 
                ID="TableRow1" 
                runat="server" 
                BackColor="Transparent">
                <asp:TableCell >
                    <h2 class="form-signin-heading">Please sign in</h2>
                </asp:TableCell>          
            </asp:TableRow>           	   
            <asp:TableRow 
                ID="TableRow2" 
                runat="server" 
                BackColor="Transparent"
                ForeColor ="Black">            
                <asp:TableCell>
                <asp:TextBox runat="server" id="tbxUsername" class="form-control" placeholder="User name"></asp:TextBox>                
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow 
                ID="TableRow3" 
                runat="server" 
                BackColor="Transparent"
                ForeColor ="Black"
                CellPadding="5"> 
                <asp:TableCell>
                <asp:TextBox runat="server" id="tbxPassword" class="form-control" TextMode="Password" placeholder="Password"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow 
                ID="TableRow4" 
                runat="server" 
                BackColor="Transparent"
                ForeColor ="Black"
                CellPadding="5">
             <asp:TableCell HorizontalAlign="Right">
                <asp:Button CssClass="btn btn-lg btn-primary btn-block" runat="server" Text="Log in" id="btnLogin" OnClick="btnLogin_Click1"></asp:Button>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableFooterRow runat="server" BackColor="Transparent">
                <asp:TableCell         
                    HorizontalAlign="Right"
                    Font-Italic="true">
                    <asp:Label runat="server" Text="" id="lblSuccess"></asp:Label>
                </asp:TableCell>
            </asp:TableFooterRow>
        </asp:Table>          
    </div> <!-- /container -->
            </div>
        </form>
</body>
</html>
