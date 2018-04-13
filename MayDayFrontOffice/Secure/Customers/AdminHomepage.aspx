<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AdminHomepage.aspx.cs" Inherits="admin_customer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <h2>
         <asp:Label ID="lblAdminHomePage" runat="server" style="text-decoration: underline" Text="Admin Home Page"></asp:Label>
     </h2>
     <asp:ListBox ID="lstCust" runat="server" Height="95px" Width="342px"></asp:ListBox>
     <asp:Label ID="lblUserInfo" runat="server"></asp:Label>
     <br />
                        <br />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; width: 407px; left: 907px; top: 425px; position: absolute; font-size: large;"></asp:Label>

            <br />
            <br />
            <asp:Label ID="lblPostCode" runat="server" style="z-index: 1; width: 307px; left: 400px; top: 407px; position: absolute;" Text="Please Enter a Surname or Postcode"></asp:Label>
            &nbsp;<br />
            <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 390px; top: 433px; position: absolute; margin-top: 1px;" Width="239px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnDisplayAll" runat="server" style="z-index: 1; left: 365px; top: 546px; position: absolute; width: 324px; height: 30px;" Text="Display All" OnClick="btnDisplayAll_Click"/>
            <br />
            <asp:Button ID="btnSurname" runat="server" OnClick="btnSurname_Click" Text="Filter Surname" style="position: absolute; top: 497px; left: 365px; width: 149px; z-index: 1; height: 30px" />
            <br />
     <asp:Button ID="btnAdd" runat="server" Height="30px" OnClick="btnAdd_Click1" Text="Add Customer" Width="115px" style="z-index: 1; left: 906px; top: 459px; position: absolute" />
           
            <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 1027px; top: 458px; position: absolute;" Text="Edit Customer" height="30px" width="115px" OnClick="btnEdit_Click1"  />
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; right: 201px; left: 1148px; top: 458px; position: absolute; margin-bottom: 0px;" Text="Delete Customer" height="30px" width="115px"/>
            <asp:Button ID="btnPCFilter1" runat="server" style="z-index: 1; left: 526px; top: 498px; position: absolute; height: 30px; width: 163px;" Text="Filter Postcode" OnClick="btnApply_Click" />
     <asp:Button ID="btnFilterPostcodeAdmin" runat="server" style="z-index: 1; left: 526px; top: 498px; position: absolute; width: 160px; height: 31px" Text="Filter Postcode" OnClick="btnFilterPostcodeAdmin_Click" />
     <br />
     <asp:Button ID="btnFilterSurnameAdmin" runat="server" Height="30px" OnClick="btnFilterSurnameAdmin_Click" style="z-index: 1; left: 360px; top: 496px; position: absolute" Text="Filter Surname" Width="150px" />
     <br />
     <br />
     <br />
     <br />
     <br />
     <br />
     <br />
     <br />
     <asp:Button ID="btnBacktoHomePage" runat="server" Height="39px" Text="Back to Home Page" Width="159px" OnClick="btnBacktoHomePage_Click" style="z-index: 1; left: 825px; top: 558px; position: absolute" />
     
     &nbsp;

</asp:Content>

