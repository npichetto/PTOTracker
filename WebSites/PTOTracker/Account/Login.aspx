<%@ Page Title="Log in" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Account_Login" Async="true" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h2><%: Title %>.</h2>

    <div class="row">
        <div class="col-md-8">
            <section id="loginForm">
                <div class="form-horizontal">
                    <h4>Use a local account to log in.</h4>
                    <hr />
                    <asp:PlaceHolder runat="server" ID="ErrorMessage" Visible="false">
                        <p class="text-danger">
                            <asp:Literal runat="server" ID="FailureText" />
                        </p>
                    </asp:PlaceHolder>
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="UserDropDown" CssClass="col-md-2 control-label">User name</asp:Label>
                        <div class="col-md-10">
                            <asp:DropDownList ID="UserDropDown" runat="server" DataSourceID="UserDropDownDS" DataTextField="EmployeeName" DataValueField="EmployeeId">
                            </asp:DropDownList>
                            <asp:SqlDataSource ID="UserDropDownDS" runat="server" ConnectionString="<%$ ConnectionStrings:PTODataConnectionString %>" SelectCommand="SELECT [EmployeeId], [EmployeeName] FROM [Employee] ORDER BY [EmployeeName]"></asp:SqlDataSource>
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="col-md-offset-2 col-md-10">
                            <asp:Button runat="server" OnClick="LogIn" Text="Log in" CssClass="btn btn-default" />
                        </div>
                    </div>
                </div>
            </section>
        </div>

    </div>
</asp:Content>

