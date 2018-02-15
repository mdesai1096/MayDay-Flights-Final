<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AEBookings.aspx.cs" Inherits="AEBookings" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <br />
    </p>
    <br />
    <br />
    <br />
    <asp:TextBox ID="txtDateBooked" runat="server" style="z-index: 1; left: 1315px; top: 361px; position: absolute; width: 127px;"></asp:TextBox>
    <asp:TextBox ID="txtRef" runat="server" style="z-index: 1; left: 1311px; top: 301px; position: absolute"></asp:TextBox>
    <asp:TextBox ID="txtPayment" runat="server" style="z-index: 1; left: 1317px; top: 452px; position: absolute"></asp:TextBox>
    <asp:TextBox ID="txtAmount" runat="server" style="z-index: 1; left: 1315px; top: 408px; position: absolute"></asp:TextBox>
    <br />
    <asp:Button ID="btnTourOp" runat="server" style="z-index: 1; left: 1096px; top: 263px; position: absolute; width: 95px" Text="Search Tours" OnClick="btnTourOp_Click" />
    <asp:Button ID="btnFlights" runat="server" style="z-index: 1; left: 789px; top: 264px; position: absolute; width: 107px; height: 25px;" Text="Search Flights" OnClick="btnFlights_Click" />
    <asp:Button ID="btnCust" runat="server" style="z-index: 1; left: 502px; top: 260px; position: absolute; width: 124px" Text="Search Customer" OnClick="btnCust_Click" />
    <br />
    <br />
    <br />
    <br />
    <br />
    <asp:Label ID="lblHeader" runat="server" Font-Size="XX-Large" style="z-index: 1; left: 629px; top: 212px; position: absolute" Text="New/Edit Booking"></asp:Label>
    <asp:ListBox ID="lstFlights" runat="server" style="z-index: 1; left: 651px; top: 309px; position: absolute; height: 121px; width: 248px; margin-bottom: 0px;">
        <asp:ListItem>Emirates EK47 Birmingham to Dubai</asp:ListItem>
</asp:ListBox>
    <br />
    <br />
    <br />
    <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 808px; top: 456px; position: absolute"></asp:Label>
    <br />
    <asp:ListBox ID="lstCust" runat="server" style="z-index: 1; left: 379px; top: 307px; position: absolute; height: 126px; width: 243px">
        <asp:ListItem>Mohammad Desai</asp:ListItem>
</asp:ListBox>
    <asp:ListBox ID="lstTourOp" runat="server" style="z-index: 1; left: 935px; top: 311px; position: absolute; height: 119px; width: 254px">
        <asp:ListItem>Thomas Cook</asp:ListItem>
</asp:ListBox>
    <asp:Button ID="btnReturn" runat="server" style="z-index: 1; left: 1097px; top: 530px; position: absolute" Text="Return" OnClick="btnReturn_Click" />
    <asp:Button ID="btnOK" runat="server" style="z-index: 1; left: 560px; top: 528px; position: absolute; width: 74px" Text="OK" OnClick="btnOK_Click" />
    <br />
    <asp:Label ID="lblAmount" runat="server" style="z-index: 1; left: 1248px; top: 409px; position: absolute" Text="Amount"></asp:Label>
    <asp:Label ID="lblDate" runat="server" style="z-index: 1; left: 1200px; top: 363px; position: absolute; width: 99px;" Text="Date Booked"></asp:Label>
    <asp:Label ID="lblPayment" runat="server" style="z-index: 1; left: 1243px; top: 455px; position: absolute" Text="Payment"></asp:Label>
    <asp:Label ID="lblRef" runat="server" style="z-index: 1; left: 1232px; top: 305px; position: absolute" Text="Reference"></asp:Label>
    <br />
    <br />
    <br />
    <asp:TextBox ID="txtTourOps" runat="server" style="z-index: 1; left: 939px; top: 263px; position: absolute; width: 124px;"></asp:TextBox>
    <asp:TextBox ID="txtCust" runat="server" style="z-index: 1; left: 371px; top: 261px; position: absolute; width: 113px;"></asp:TextBox>
    <asp:TextBox ID="txtFlights" runat="server" style="z-index: 1; left: 652px; top: 264px; position: absolute; width: 110px;"></asp:TextBox>
</asp:Content>

