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

    protected void Button1_Click(object sender, EventArgs e)
    {
        Add();
        Response.Redirect("DefaultFlight.aspx");
    }

    void Add()
    {
        clsFlightCollection Flights = new clsFlightCollection();
        string Error = Flights.ThisFlight.Valid(txtAirline.Text, txtDestination.Text, txtArrivalTime.Text, txtArrival.Text, txtDepartureTime.Text, txtDeparture.Text);
        if (Error == "")
        {
            Flights.ThisFlight.Airline = txtAirline.Text;
            Flights.ThisFlight.Destination = txtDestination.Text;
            Flights.ThisFlight.ArrivalAirport = txtArrival.Text;
            Flights.ThisFlight.Arrival = Convert.ToDateTime(txtArrivalTime.Text);
            Flights.ThisFlight.Departure = Convert.ToDateTime(txtDepartureTime.Text);
            Flights.ThisFlight.DepartureAirport = txtDeparture.Text;
            Flights.ThisFlight.Destination = txtDestination.Text;
            Flights.Add();
        }
        else
        {
            lblError.Text = Error;
        }
    }
}