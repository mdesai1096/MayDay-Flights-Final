using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class FilterBooking : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void Page_UnLoad(object sender, EventArgs e)
    {
        
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

        
        
    }

    

    protected void btnNew_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["BookRef"] = -1;
        //redirect to data entry page
        Response.Redirect("AEBookings.aspx");
    }
}