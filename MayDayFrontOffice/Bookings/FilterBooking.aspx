<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="FilterBooking.aspx.cs" Inherits="FilterBooking" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
    <asp:Label ID="lblHeader" runat="server" Font-Size="XX-Large" style="z-index: 1; left: 896px; top: 220px; position: absolute" Text="Bookings Admin"></asp:Label>
    <br />
</p>
<br />
<br />
<asp:TextBox ID="txtSearch" runat="server" style="z-index: 1; left: 419px; top: 307px; position: absolute; width: 235px"></asp:TextBox>
<br />
<br />
<br />
<br />
<asp:ListBox ID="lstBookings" runat="server" style="z-index: 1; left: 411px; top: 348px; position: absolute; height: 155px; width: 1111px">
    <asp:ListItem>Mohammad Desai 02/10/2017 £500</asp:ListItem>
</asp:ListBox>
<br />
<asp:Button ID="btnSearch" runat="server" style="z-index: 1; left: 682px; top: 307px; position: absolute" Text="Search" />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 938px; top: 535px; position: absolute; width: 91px" Text="Edit Booking" OnClick="btnEdit_Click" />
<asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 1321px; top: 539px; position: absolute; margin-bottom: 0px" Text="Cancel Booking" OnClick="btnCancel_Click" />
<br />
<asp:Label ID="lblError" runat="server" style="z-index: 1; left: 840px; top: 308px; position: absolute"></asp:Label>
<asp:Button ID="btnNew" runat="server" OnClick="btnNew_Click" style="z-index: 1; left: 417px; top: 538px; position: absolute; width: 92px" Text="New Booking" />
<br />
<br />
</asp:Content>

