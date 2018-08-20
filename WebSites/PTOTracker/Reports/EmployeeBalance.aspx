<%@ Page Title="" Language="C#" MasterPageFile="~/Reports/ReportsMaster.master" AutoEventWireup="true" CodeFile="EmployeeBalance.aspx.cs" Inherits="Reports_EmployeeBalance" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ReportsMainContent" Runat="Server">
    <h3><asp:Label ID="ReportTitleLabel" runat="server"></asp:Label></h3>
    <div>
        <asp:GridView ID="ReportGridView" runat="server" 
                      AutoGenerateColumns="false"
                      Width="100%">
            <Columns>
                <asp:BoundField DataField="EmployeeName"
                                HeaderText="NAME" />
                <asp:BoundField DataField="BalanceHours" 
                                HeaderText="BALANCE" />
                <asp:BoundField DataField="NextPTOEventString"
                                HeaderText="NEXT SCHEDULED PTO EVENT" />
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>

