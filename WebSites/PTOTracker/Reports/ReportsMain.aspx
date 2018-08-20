<%@ Page Title="" Language="C#" MasterPageFile="~/Reports/ReportsMaster.master" AutoEventWireup="true" CodeFile="ReportsMain.aspx.cs" Inherits="Reports_ReportsMain" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ReportsMainContent" Runat="Server">
    <div style="margin:0 auto; vertical-align: middle; text-align: center;">
        <asp:Button ID="EmployeeBalanceButton" runat="server" Width="250px" PostBackUrl="~/Reports/EmployeeBalance.aspx" Text="Employee Balance" />
    </div>
    <div style="margin:0 auto; vertical-align: middle; text-align: center;">
        <asp:Button ID="DetailedReportButton" runat="server" Width="250px" PostBackUrl="~/Reports/DetailedReport.aspx" Text="Detailed Report" />
    </div>
</asp:Content>

