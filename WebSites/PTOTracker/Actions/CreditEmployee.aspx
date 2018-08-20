﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Actions/ActionsMaster.master" AutoEventWireup="true" CodeFile="CreditEmployee.aspx.cs" Inherits="Actions_CreditEmployee" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ActionsMainContent" Runat="Server">
    <h3>Credit Employee</h3>
    
    <div class="body-content">
        <asp:Label ID="EmployeeLabel" AssociatedControlID="EmployeeDropDown" runat="server">Employee:</asp:Label>
        <asp:DropDownList ID="EmployeeDropDown" runat="server" DataSourceID="EmployeeDropDownDS" DataTextField="EmployeeName" DataValueField="EmployeeId" />
        <asp:SqlDataSource ID="EmployeeDropDownDS" runat="server" ConnectionString="<%$ ConnectionStrings:PTODataConnectionString %>" SelectCommand="SELECT [EmployeeId], [EmployeeName] FROM [Employee] ORDER BY [EmployeeName]"></asp:SqlDataSource>
    </div>
    <div class="body-content">
        <asp:Label ID="PTOAmountLabel" AssociatedControlID="PTOAmount" runat="server">PTO Amount:</asp:Label>
        <asp:TextBox ID="PTOAmount" runat="server" TextMode="Number" ></asp:TextBox>
        <asp:RequiredFieldValidator id="PTOAmountValidator" runat="server"
            ControlToValidate="PTOAmount"
            ErrorMessage="PTO Amount is a required field."
            ForeColor="Red">
        </asp:RequiredFieldValidator>
    </div>
    <div class="body-content">
        <asp:Label ID="DescriptionLabel" AssociatedControlID="Description" runat="server">Description:</asp:Label>
        <asp:TextBox ID="Description" runat="server"></asp:TextBox>
    </div>
    <div class="body-content">
    
        <asp:Button ID="SubmitButton" runat="server" Text="Submit" OnClick="SubmitButton_Click" />
    
        <div class="body-content">
            <asp:Label ID="SuccessLabel" runat="server" Font-Bold="True" ForeColor="Green" Text="Credit Successfully Added!" Visible="False"></asp:Label>
        </div>
    
    </div>
</asp:Content>
