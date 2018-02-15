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
        if (lstBookings.SelectedIndex != -1)
        {
            //redirect to the edit page whilst sending the data
            Response.Redirect("AEBookings.aspx?lblref=525&date=02/10/2017&amount=500&Payment=Credit Card");

        }
        else
        {
            //display an error
            lblError.Text = "You must select an item off the list first to edit it.";
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //if a booking has not been selected off the list box
        if(lstBookings.SelectedIndex != -1)
        {
            //redirect to the Delete page whilst send data
            Response.Redirect("DeleteBooking.aspx?lblref=525");
        }
        else
        {
            //display an error
            lblError.Text = "You must select an item off the list first to cancel it.";
        }
        
        
    }

    

    protected void btnNew_Click(object sender, EventArgs e)
    {
        //Redirect to the new booking page
        Response.Redirect("AEBookings.aspx?lblref=655455");
    }
}