<%@ Page Title="" Language="C#" MasterPageFile="~/Reports/ReportsMaster.master" AutoEventWireup="true" CodeFile="DetailedReport.aspx.cs" Inherits="Reports_DetailedReport" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ReportsMainContent" Runat="Server">
    <h3><asp:Label ID="ReportTitleLabel" runat="server"></asp:Label></h3>
    <div>
        <asp:Label ID="EmployeesDropDownLabel" AssociatedControlID="EmployeesDropDown" runat="server" Text="Employee: "></asp:Label>
        <asp:DropDownList ID="EmployeesDropDown" runat="server" DataSourceID="AllEmployeesDS" DataTextField="EmployeeName" DataValueField="EmployeeId" AutoPostBack="True" OnSelectedIndexChanged="EmployeesDropDown_SelectedIndexChanged">
        </asp:DropDownList>
        <asp:SqlDataSource ID="AllEmployeesDS" runat="server" ConnectionString="<%$ ConnectionStrings:PTODataConnectionString %>" SelectCommand="SELECT [EmployeeId], [EmployeeName] FROM [Employee] ORDER BY [EmployeeName]"></asp:SqlDataSource>
    </div>
    <div>
        <asp:GridView ID="ReportGridView" runat="server" 
                      AutoGenerateColumns="false"
                      Width="100%">
            <Columns>
                <asp:BoundField DataField="DateRange"
                                HeaderText="DATE" />
                <asp:BoundField DataField="Description" 
                                HeaderText="EVENT/DESCRIPTION" />
                <asp:BoundField DataField="PTOAmount"
                                HeaderText="+ OR - HOURS" />
                <asp:BoundField DataField="ResultingPTOBalance"
                                HeaderText="BALANCE" />
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>

