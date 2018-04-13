<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">



   
    <asp:Label ID="lblLogin" runat="server" style="z-index: 1; left: 857px; top: 221px; position: absolute; width: 69px; font-size: 17pt; height: 30px" Text="Login"></asp:Label>
    <br />
    <asp:Button ID="btnDisplayAll" runat="server" OnClick="btnDisplayAll_Click" style="z-index: 1; left: 538px; top: 529px; position: absolute; height: 27px; width: 114px" Text="Display All" />
    <br />
    <br />
    <br />
    <br />
    <asp:ListBox ID="lstHR" runat="server" Height="170px" Width="766px"></asp:ListBox>
    <asp:Button ID="btnApply" runat="server" style="z-index: 1; left: 459px; top: 529px; position: absolute; width: 70px" Text="Apply" />
    <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 419px; top: 576px; position: absolute" Text="Add Employee" OnClick="btnAdd_Click" />
    <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 590px; top: 576px; position: absolute" Text="Edit Employee" />
    <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 771px; top: 574px; position: absolute" Text="Delete Employee" />
     
</asp:Content>

