using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyClassLibrary;

public partial class DefaultFlight : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayBookings();
        }
        
    }




    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["FlightID"] = -1;
        //redirect to the data entry page
        Response.Redirect("AddFlight.aspx");

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
            lblError.Text = "Please select a record to update from the list";

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
            Session["FlightID"] = FlightNo;
            //redirect to the delete page
            Response.Redirect("DeleteFlight.aspx");
        }
        else //if no record has been selected
        {
            //display an error
            lblError.Text = "Plese select a record to delete from the list";
        }



    }

    void FilterByDestination(string Destination)
    {
        //create an instance of the booking collection
        clsFlightCollection C = new clsFlightCollection();
        C.FilterByDestination(Destination);
        //set the data source to the list of bookings in the collection
        lstFlights.DataSource = C.FlightList;
        //set the name of the primary key
        lstFlights.DataValueField = "FlightID";
        //set the data field to display
        lstFlights.DataTextField = "Destination";
        //bind the data to the list
        lstFlights.DataBind();
    }

    void DisplayBookings()
    {
        //create an instance of the booking collection
        clsFlightCollection Bookings = new clsFlightCollection();
        //set the data source to the list of bookings in the collection
        lstFlights.DataSource = Bookings.FlightList;
        //set the name of the primary key
        lstFlights.DataValueField = "FlightID";
        //set the data field to display
        lstFlights.DataTextField = "FlightNo";
        //bind the data to the list
        lstFlights.DataBind();
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        FilterByDestination(txtSearch.Text);
    }
}

