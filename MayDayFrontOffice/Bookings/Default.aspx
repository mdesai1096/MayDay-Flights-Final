<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Bookings_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
    <br />
</p>
<asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 406px; top: 291px; position: absolute; width: 187px"></asp:TextBox>
<asp:Button ID="btnFilter" runat="server" style="z-index: 1; left: 626px; top: 290px; position: absolute" Text="Filter" />
<br />
<asp:Label ID="lblError" runat="server" style="z-index: 1; left: 924px; top: 294px; position: absolute"></asp:Label>
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<asp:ListBox ID="lstBookings" runat="server" style="z-index: 1; left: 406px; top: 325px; position: absolute; height: 213px; width: 1135px"></asp:ListBox>
<asp:Button ID="btnNew" runat="server" OnClick="btnNew_Click" style="z-index: 1; left: 419px; top: 572px; position: absolute" Text="New Booking" />
<asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 1397px; top: 575px; position: absolute" Text="Cancel Booking" />
<asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 947px; top: 571px; position: absolute" Text="Update Booking" OnClick="btnEdit_Click" />
<asp:Label ID="lblTitle" runat="server" Font-Size="XX-Large" style="z-index: 1; left: 838px; top: 250px; position: absolute" Text="Bookings Home Page"></asp:Label>
</asp:Content>

