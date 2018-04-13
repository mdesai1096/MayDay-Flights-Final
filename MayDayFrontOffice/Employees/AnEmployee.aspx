<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AnEmployee.aspx.cs" Inherits="Employees_AnEmployee" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style7 {
            font-size: x-large;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <span class="auto-style7">Add Employee</span></p>
    <p>
        <asp:Label ID="lblEmployeeName" runat="server" style="z-index: 1; left: 395px; top: 286px; position: absolute" Text="Employee Name:"></asp:Label>
        <asp:TextBox ID="txtEmployeeName" runat="server" style="z-index: 1; left: 522px; top: 285px; position: absolute; width: 137px"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="lblEmployeeJoinDate" runat="server" style="z-index: 1; left: 395px; top: 321px; position: absolute" Text="Employee Join Date:"></asp:Label>
        <asp:TextBox ID="txtEmployeeJoinDate" runat="server" style="z-index: 1; left: 538px; top: 320px; position: absolute"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="lblEmployeeDOB" runat="server" style="z-index: 1; left: 396px; top: 353px; position: absolute" Text="Employee DOB:"></asp:Label>
        <asp:Label ID="lblEmployeeEmail" runat="server" style="z-index: 1; left: 396px; top: 386px; position: absolute" Text="Employee Email:"></asp:Label>
        <asp:TextBox ID="txtEmployeeDOB" runat="server" style="z-index: 1; left: 517px; top: 352px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblEmployeeContactNo" runat="server" style="z-index: 1; left: 396px; top: 423px; position: absolute" Text="Employee Contact No:"></asp:Label>
    </p>
    <p>
        <asp:TextBox ID="txtEmployeeEmail" runat="server" style="z-index: 1; left: 515px; top: 386px; position: absolute; width: 148px"></asp:TextBox>
    </p>
    <p>
        <asp:TextBox ID="txtEmployeeContactNo" runat="server" style="z-index: 1; left: 557px; top: 421px; position: absolute; width: 138px; right: 408px"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="lblEmployeeAddress" runat="server" style="z-index: 1; left: 395px; top: 454px; position: absolute" Text="Employee Address:"></asp:Label>
        <asp:TextBox ID="txtEmployeeAddress" runat="server" style="z-index: 1; left: 529px; top: 453px; position: absolute; width: 285px"></asp:TextBox>
        <asp:Label ID="lblEmployeeSalary" runat="server" style="z-index: 1; left: 395px; top: 488px; position: absolute" Text="Employee Salary:"></asp:Label>
        <asp:TextBox ID="txtEmployeeSalary" runat="server" style="z-index: 1; left: 514px; top: 487px; position: absolute; width: 164px; right: 425px"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="lblEmployeeRole" runat="server" style="z-index: 1; left: 395px; top: 523px; position: absolute; width: 104px" Text="Employee Role:"></asp:Label>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 418px; top: 564px; position: absolute"></asp:Label>
    </p>
    <p>
        <asp:TextBox ID="txtEmployeeRole" runat="server" style="z-index: 1; left: 511px; top: 523px; position: absolute"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="btnOK" runat="server" style="z-index: 1; left: 390px; top: 594px; position: absolute; width: 44px; right: 454px" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 471px; top: 593px; position: absolute" Text="Cancel" />
    </p>
    <p>
        &nbsp;</p>
</asp:Content>

