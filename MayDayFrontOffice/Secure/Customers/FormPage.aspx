<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="FormPage.aspx.cs" Inherits="EditCustomer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
            <p style="text-decoration: underline; " class="auto-style8">
                <strong>Form Page</strong></p>
<p style="font-size: large">
    <strong>
    <asp:Label ID="lblForename" runat="server" Text="Forename" CssClass="auto-style7"></asp:Label>
    </strong>&nbsp;<strong><asp:TextBox ID="txtForename" runat="server" Width="155px" CssClass="auto-style7"></asp:TextBox>
    </strong>
</p>
<p style="font-size: large">
    <strong>
    <asp:Label ID="lblSurname" runat="server" Text="Surname" CssClass="auto-style7"></asp:Label>
    </strong>
    <span class="auto-style7"><strong>&nbsp;&nbsp; </strong> </span>
    <strong>
    <asp:TextBox ID="txtSurname" runat="server" Width="158px" CssClass="auto-style7"></asp:TextBox>
    </strong>
</p>
<p style="font-size: large">
    <strong>
    <asp:Label ID="lblDateOfBirth" runat="server" Text="Date Of Birth" CssClass="auto-style7"></asp:Label>
    </strong><span class="auto-style7"><strong>&nbsp;
    </strong></span><strong>
    <asp:TextBox ID="txtDateOfBirth" runat="server" Width="153px" CssClass="auto-style7"></asp:TextBox>
    </strong>
</p>
<p style="font-size: large">
    <strong>
    <asp:Label ID="lblHouseFlatNumber" runat="server" Text="House/Flat Number" CssClass="auto-style7"></asp:Label>
    </strong>&nbsp;<strong><asp:TextBox ID="txtHouseNumber" runat="server" Width="108px" CssClass="auto-style7"></asp:TextBox>
    <asp:TextBox ID="txtFlatNo" runat="server"></asp:TextBox>
    <asp:Button ID="btnBacktoCustomerHomePage" runat="server" OnClick="btnBacktoCustomerHomePage_Click" style="position: absolute; top: 280px; left: 965px; width: 200px; height: 40px; z-index: 1;" Text="Back to Customer Home Page" />
    <asp:Button ID="btnBackToAdminHomePage" runat="server" OnClick="btnBackToAdminHomePage_Click" Text="Back to Admin Home Page" style="margin-left: 0px; margin-bottom: 0px; position: absolute; top: 338px; left: 966px; width: 200px; height: 40px; margin-top: 0px;" />
    </strong>
</p>
<p style="font-size: large">
    <strong>
    <asp:Label ID="lblPostCode" runat="server" Text="Postcode" CssClass="auto-style7"></asp:Label>
    </strong><span class="auto-style7"><strong>&nbsp;
    </strong></span><strong>
    <asp:TextBox ID="txtPostCode" runat="server" Width="87px" CssClass="auto-style7"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </strong>
    <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 773px; top: 288px; position: absolute; width: 143px; font-size: medium; bottom: 455px"></asp:Label>
    <strong>
    <asp:Button ID="btnBacktoLoginPage" runat="server" OnClick="btnBacktoLoginPage_Click" style="text-align: center; position: absolute; top: 396px; left: 967px; width: 200px; margin-top: 0px; height: 40px; z-index: 1;" Text="Back to Login Page " />
    </strong>
</p>
<p style="font-size: large">
    <strong>
    <asp:Label ID="lblGender" runat="server" Text="Gender" CssClass="auto-style7"></asp:Label>
    </strong><span class="auto-style7"><strong>:&nbsp;&nbsp;&nbsp;
    </strong></span><strong>
    <asp:CheckBox ID="chkMale" runat="server" Text="Male" CssClass="auto-style7" />
    </strong><span class="auto-style7"><strong>&nbsp;&nbsp;&nbsp;&nbsp;
    </strong></span><strong>
    <asp:CheckBox ID="chkFemale" runat="server" Text="Female" CssClass="auto-style7" />
    <asp:TextBox ID="txtGender" runat="server"></asp:TextBox>
    </strong>
</p>
<p style="font-size: large">
    <strong>
    <asp:Label ID="lblContactNumber" runat="server" Text="Contact Number" CssClass="auto-style7"></asp:Label>
    </strong><span class="auto-style7"><strong>&nbsp;</strong></span><strong><asp:TextBox ID="txtContactNumber" runat="server" Width="161px" CssClass="auto-style7"></asp:TextBox>
    </strong>
</p>
<p style="font-size: large">
    <strong>
    <asp:Label ID="lblEmail" runat="server" Text="Email" CssClass="auto-style7"></asp:Label>
    </strong><span class="auto-style7"><strong>&nbsp;
    </strong></span><strong>
    <asp:TextBox ID="txtEmail" runat="server" Width="226px" CssClass="auto-style7"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnEnter" runat="server" Height="39px" OnClick="btnEnter_Click" Text="Enter" Width="176px" />
    </strong>
</p>
    <p style="font-size: large">
&nbsp;</p>
            <p style="font-size: large">
                &nbsp;</p>
<p style="font-size: large">
    &nbsp;</p>
<p style="font-size: large">
    &nbsp;</p>
<p style="text-decoration: underline; font-size: large">
    &nbsp;</p>
<p style="text-decoration: underline; font-size: large">
    &nbsp;</p>
<p style="text-decoration: underline; font-size: large">
    &nbsp;</p>

</asp:Content>

<asp:Content ID="Content2" runat="server" contentplaceholderid="head">
    <style type="text/css">
        .auto-style7 {
            font-size: small;
        }
        .auto-style8 {
            font-size: medium;
            text-align: center;
        }
    </style>
</asp:Content>


