<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="MyWebSite.Pages.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <h1>Home</h1>
    <asp:Label ID="lblWelcome" runat="server" Text=""></asp:Label>
    <p>We have thousands of books in print across our two campus libraries. Use the library catalogue to search for books by title, author, subject or keyword. Each campus library has its own book stock and you will know if the book is at your campus by the location information.</p>
</asp:Content>
