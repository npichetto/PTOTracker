<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron" style="text-align: center; vertical-align: middle">
        <h1>PTO Tracker</h1>
        <p class="lead">This system allows your employees to schedule PTO, log sick days, and view detailed reports.</p>
    </div>

    <div style="margin:0 auto; vertical-align: middle; text-align: center;">
        <p style="vertical-align: middle; text-align: center">
            <asp:Button ID="ActionsButton" runat="server" Text="Schedule/Log PTO" Width="250px" PostBackUrl="~/Actions/ActionsMain.aspx" />
        </p>
        <p style="vertical-align: middle; text-align: center">
            <asp:Button ID="ReportsButton" runat="server" Text="View Reports" Width="250px" PostBackUrl="~/Reports/ReportsMain.aspx" />
        </p>
   </div>
</asp:Content>
