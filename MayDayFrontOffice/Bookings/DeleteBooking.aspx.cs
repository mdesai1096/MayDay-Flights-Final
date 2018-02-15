using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DeleteBooking : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //write to textboxes query sting passed from previous page
        txtBookRef.Text = Convert.ToString(Request.QueryString["lblRef"]);
    }

    protected void btnReturn_Click(object sender, EventArgs e)
    {
        //directs back the filter page
        Response.Redirect("FilterBooking.aspx");
    }

    protected void btnCancelBook_Click(object sender, EventArgs e)
    {
        //write to the label
        lblError.Text = ("Booking has been canceled");
    }
}