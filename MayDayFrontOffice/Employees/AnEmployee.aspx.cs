using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyClassLibrary;


public partial class Employees_AnEmployee : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    void Add()
    {
        //create instance of employee book
        clsEmployeeCollection EmployeeBook = new clsEmployeeCollection();
        //vlidate data in form
        //Valid(string employeeAddress, string employeeContactNumber, string employeeDOB, string employeeEmail, string employeeJoinDate, string employeeName, string employeeRole, string employeeSalary)
        String Error = EmployeeBook.ThisEmployee.Valid(txtEmployeeAddress.Text, txtEmployeeContactNo.Text, txtEmployeeDOB.Text, txtEmployeeEmail.Text, txtEmployeeJoinDate.Text, txtEmployeeName.Text, txtEmployeeRole.Text, txtEmployeeSalary.Text);
        //if data is OK then add to objext
        if (Error == " ")
        {
            //get data entered by user
            EmployeeBook.ThisEmployee.Address = txtEmployeeAddress.Text;
            EmployeeBook.ThisEmployee.EmployeeContactNumber = txtEmployeeContactNo.Text;
            EmployeeBook.ThisEmployee.EmployeeDOB = Convert.ToDateTime(txtEmployeeDOB.Text);
            EmployeeBook.ThisEmployee.EmployeeEmail = txtEmployeeEmail.Text;
            EmployeeBook.ThisEmployee.EmployeeJoinDate = Convert.ToDateTime(txtEmployeeContactNo.Text);
            //EmployeeBook.ThisEmployee.EmployeeContactNo = txtEmployeeContactNo.Text;
            EmployeeBook.ThisEmployee.EmployeeName = txtEmployeeName.Text;
            EmployeeBook.ThisEmployee.EmployeeRole = txtEmployeeRole.Text;
            EmployeeBook.ThisEmployee.EmployeeSalary = txtEmployeeSalary.Text;
            //add record
            EmployeeBook.Add();
        }
        else
        {
            lblError.Text = "There was an error with the data entered" + Error;
        }
    }


    protected void btnOK_Click(object sender, EventArgs e)
    {
        //add new record
        Add();
        //all done so redirect bak to main page
        Response.Redirect("Default.aspx");
    }
}
