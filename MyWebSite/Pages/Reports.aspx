<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Reports.aspx.cs" Inherits="MyWebSite.Pages.Reports" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<h1>Report Selection</h1>
<p>To view the report relating to the previous sales with external publisher: 
<a class="btn btn-default" href="http://172.28.134.11/Reports/report/LibraryVersion2/PublisherReport" target="_blank"> Publisher Sales Report  &raquo; </a>
</p>
<p>To view reports listing the overdue books of a member: 
<a class="btn btn-default" href="http://172.28.134.11/Reports/report/LibraryVersion2/DueDate" target="_blank"> Overdue Books Report  &raquo;</a>
</p>
<p>To view reports listing the books ready for pickup: 
<a class="btn btn-default" href="http://172.28.134.11/Reports/report/LibraryVersion2/BookPickUp" target="_blank"> Books for Pickup Report  &raquo;</a>
</p>
<p>To view reports listing the history of a member: 
<a class="btn btn-default" href="http://172.28.134.11/Reports/report/LibraryVersion2/BorrowHistory" target="_blank"> Members History Report  &raquo;</a>
</p>
<p>To view reports listing books available: 
<a class="btn btn-default" href="http://172.28.134.11/Reports/report/LibraryVersion2/BrowseDB" target="_blank"> Item Search Report  &raquo;</a>
</p>
<p>To view reports listing the system logs: 
<a class="btn btn-default" href="http://172.28.134.11/Reports/report/LibraryVersion2/Access%20Logs" target="_blank"> System Logs Report &raquo;</a>
</p>
<p>To view the root directory of the above reports: 
<a class="btn btn-default" href="http://172.28.134.11/Reports/browse/LibraryVersion2" target="_blank"> Report Overview &raquo;</a>
</p>

</asp:Content>
