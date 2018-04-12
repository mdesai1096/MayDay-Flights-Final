using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyClassLibrary;

public partial class _Default : System.Web.UI.Page
{
    //this function handles the load event for the page
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update list box
            DisplayEmployees();

        }

    }

    void DisplayEmployees()
    {
        clsEmployeeCollection HR = new clsEmployeeCollection();
        //set the name of the primary key
        lstHR.DataSource = HR.EmployeesList;
        lstHR.DataValueField = "EmployeeNo";
        lstHR.DataTextField = "EmployeeName";
        lstHR.DataBind();
    }



    protected void btnDisplayAll_Click(object sender, EventArgs e)
    {

    }
}