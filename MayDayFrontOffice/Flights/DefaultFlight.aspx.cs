using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DefaultFlight : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }




    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["FlightID"] = -1;
        //redirect to the data entry page
        Response.Redirect("AnAddress.aspx");

    }

    //event handler for the update/edit button
    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 FlightNo;
        //if a record has been selected from the list
        if (lstFlights.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            FlightNo = Convert.ToInt32(lstFlights.SelectedValue);
            //store the data in the session object
            Session["FlightID"] = FlightNo;
            //redirect to the edit page
            Response.Redirect("AddFlight.aspx");
        }
        else // if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";

        }
    }



    //event handler for the delete button
    protected void btnDelete_Click1(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be delete
        Int32 FlightNo;
        //if a record has been selected from the list
        if(lstFlights.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            FlightNo = Convert.ToInt32(lstFlights.SelectedValue);
            //store the data in the session object
            Session["FlightNo"] = FlightNo;
            //redirect to the delete page
            Response.Redirect("DeleteFlight.aspx");
        }
        else //if no record has been selected
        {
            //display an error
            lblError.Text = "Plese select a record to delete from the list";
        }
        
    }
}

