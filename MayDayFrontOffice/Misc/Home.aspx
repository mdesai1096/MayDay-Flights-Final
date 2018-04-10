<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style7 {
            width: 1185px;
            height: 227px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

                
    <asp:Label ID="lblHeader" runat="server" Font-Bold="True" Font-Size="XX-Large" Font-Underline="True" style="z-index: 1; left: 612px; top: 213px; position: absolute" Text="Welcome to MayDay Flights and Travel"></asp:Label>
    <asp:Label ID="lblArticle" runat="server" Font-Size="X-Large" style="z-index: 1; left: 420px; top: 300px; position: absolute; height: 39px; width: 1126px" Text="At MayDay we have a range of holiday packages from City breakes to Beach Holidays and everything in between!"></asp:Label>
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <img alt="" class="auto-style7" src="../Images/56d704988c1d8.jpeg" /><asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" style="z-index: 1; left: 1407px; top: 255px; position: absolute" Text="Login" />
<br />
    <br />

                
</asp:Content>

