<%@ Page Title="" Language="C#" MasterPageFile="~/Actions/ActionsMaster.master" AutoEventWireup="true" CodeFile="ActionsMain.aspx.cs" Inherits="Actions_Actions" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ActionsMainContent" Runat="Server">
    
    <div style="margin:0 auto; vertical-align: middle; text-align: center;">
        <asp:Button ID="SchedulePTOButton" runat="server" Width="250px" PostBackUrl="~/Actions/SchedulePTO.aspx" Text="Schedule PTO" />
    </div>
    <div style="margin:0 auto; vertical-align: middle; text-align: center;">
        <asp:Button ID="CreditEmployeeButton" runat="server" Width="250px" PostBackUrl="~/Actions/CreditEmployee.aspx" Text="Credit Employee" />
    </div>
    
</asp:Content>

