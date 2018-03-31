using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyClassLibrary;

public partial class Delete : System.Web.UI.Page
{
    Int32 CustomerID;
    protected void Page_Load(object sender, EventArgs e)
    {
        CustomerID = Convert.ToInt32(Session["CustomerID"]);
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        DeleteCust();
        //directs back to the login page 
        Response.Redirect("AdminHomepage.aspx");
    }

    void DeleteCust()
    {
        clsCustomerCollection CustList = new clsCustomerCollection();
        CustList.ThisCustomer.Find(CustomerID);
        CustList.Delete();
    }
}