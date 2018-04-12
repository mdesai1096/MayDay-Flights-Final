using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyClassLibrary;

public partial class AddFlight : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    

    //function for adding new records
    void Add()
    {
        //create an instance of the flight book
        MyClassLibrary.clsFlightCollection Flights = new clsFlightCollection();
        //validate the data on the web form
        string Error = Flights.ThisFlight.Valid(txtFlightNo.Text, txtAirline.Text, txtDestination.Text, txtArrivalTime.Text, txtArrivalAirport.Text, txtDepartureTime.Text, txtDepartureAirport.Text);
        //if the data is OK then add it to the object
        if (Error == "")
        {
            //get the data entered by the user
            Flights.ThisFlight.FlightNo = txtFlightNo.Text;
            Flights.ThisFlight.Airline = txtAirline.Text;
            Flights.ThisFlight.Destination = txtDestination.Text;
            Flights.ThisFlight.ArrivalAirport = txtArrivalAirport.Text;
            Flights.ThisFlight.Arrival = Convert.ToDateTime(txtArrivalTime.Text);
            Flights.ThisFlight.Departure = Convert.ToDateTime(txtDepartureTime.Text);
            Flights.ThisFlight.DepartureAirport = txtDepartureAirport.Text;
            Flights.ThisFlight.Destination = txtDestination.Text;
            //add the record
            Flights.Add();
            //all done so redirect back to the main page
            Response.Redirect("DefaultFlight.aspx");

        }
        else
        {
            //report an error
            lblError.Text = "There were problems with the data entered" + Error;
        }
    }

    //event handler for the ok button
    protected void btnOk_Click(object sender, EventArgs e)
    {
        //add the new record
        Add();
        //all done so redirect back to the main page
        //Response.Redirect("DefaultFlight.aspx");
    }
}