<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">



   
    <asp:Label ID="lblLogin" runat="server" style="z-index: 1; left: 857px; top: 221px; position: absolute; width: 69px; font-size: 17pt; height: 30px" Text="Login"></asp:Label>
    <br />
    <asp:Button ID="btnDisplayAll" runat="server" OnClick="btnDisplayAll_Click" style="z-index: 1; left: 432px; top: 529px; position: absolute; height: 27px; width: 114px" Text="Display All" />
    <br />
    <br />
    <br />
    <br />
    <asp:ListBox ID="lstHR" runat="server" Height="170px" Width="766px"></asp:ListBox>
     
</asp:Content>
