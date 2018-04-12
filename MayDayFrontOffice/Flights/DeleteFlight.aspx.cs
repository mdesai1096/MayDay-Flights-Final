using MyClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Flights_DelteFlight : System.Web.UI.Page
{
    //var to store the primary key value of the record to be deleted
    Int32 FlightNo;
    //event handler fror the load event
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the flights to be deleted from the session object
        FlightNo = Convert.ToInt32(Session["FlightID"]); 

    }

    protected void btnReturn_Click(object sender, EventArgs e)
    {
        Response.Redirect("DefaultFlight.aspx");
    }

    //event handler for the yes button
    protected void btnCancelFlight_Click(object sender, EventArgs e)
    {
        //delete the record
        DeleteFlight();
        //redirect back to the main page
        Response.Redirect("DefaultFlight.Aspx");


        lblError.Text = "Flight Deleted";
    }

    void DeleteFlight()
    {
        //function to delete the selected record

        //create a new instance of the flight book
        clsFlightCollection FlightBook = new clsFlightCollection();
        //find the record to delete 
        FlightBook.ThisFlight.Find(FlightNo);
        //delete the record
        FlightBook.Delete();    
    }
}