<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Login ID="Login1" runat="server" CreateUserText="Sign Up" CreateUserUrl="SignUp.aspx" DestinationPageUrl="~/Secure/Customers/AdminHomepage.aspx" Height="324px" Width="774px">
</asp:Login>
</asp:Content>

