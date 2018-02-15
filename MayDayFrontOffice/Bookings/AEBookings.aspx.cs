using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyClassLibrary;

public partial class AEBookings : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //write to textboxes query sting passed from previous page
        txtRef.Text = Convert.ToString(Request.QueryString["lblRef"]);
        txtDateBooked.Text = Convert.ToString(Request.QueryString["date"]);
        txtAmount.Text = Convert.ToString(Request.QueryString["amount"]);
        txtPayment.Text = Convert.ToString(Request.QueryString["Payment"]);

    }

    protected void btnReturn_Click(object sender, EventArgs e)
    {
        //redirect to the filter page
        Response.Redirect("FilterBooking.aspx");

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //Display an message to indicate task as been done
        lblError.Text=("Success");
    }

    protected void btnCust_Click(object sender, EventArgs e)
    {
        //Display an message to indicate task as been done
        lblError.Text = ("1 Customer Found");
    }

    protected void btnFlights_Click(object sender, EventArgs e)
    {
        //Display an message to indicate task as been done
        lblError.Text = ("1 Flight Found");
    }

    protected void btnTourOp_Click(object sender, EventArgs e)
    {
        //Display an message to indicate task as been done
        lblError.Text = ("1 Tour found");
    }
}