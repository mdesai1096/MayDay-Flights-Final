using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyClassLibrary;

public partial class AddFlight : System.Web.UI.Page
{
    Int32 flightid;
    protected void Page_Load(object sender, EventArgs e)
    {
        //that bit goes here
       flightid = Convert.ToInt32(Session["flightID"]);
        if (IsPostBack == false)
        {
            DisplayCustomer();
                if (flightid != -1)

                {
                DisplayCustomer();

            }
        }
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

    void Update()
    {
        //create an instance of the flight book
        MyClassLibrary.clsFlightCollection Flights = new clsFlightCollection();
        //validate the data on the web form
        string Error = Flights.ThisFlight.Valid(txtFlightNo.Text, txtAirline.Text, txtDestination.Text, txtArrivalTime.Text, txtArrivalAirport.Text, txtDepartureTime.Text, txtDepartureAirport.Text);
        //if the data is OK then add it to the object
        if (Error == "")

        {
            //get the data entered by the user
            Flights.ThisFlight.Find(flightid);
            Flights.ThisFlight.FlightNo = txtFlightNo.Text;
            Flights.ThisFlight.Airline = txtAirline.Text;
            Flights.ThisFlight.Destination = txtDestination.Text;
            Flights.ThisFlight.ArrivalAirport = txtArrivalAirport.Text;
            Flights.ThisFlight.Arrival = Convert.ToDateTime(txtArrivalTime.Text);
            Flights.ThisFlight.Departure = Convert.ToDateTime(txtDepartureTime.Text);
            Flights.ThisFlight.DepartureAirport = txtDepartureAirport.Text;
           
            //add the record
            Flights.Update();
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
        if (flightid == -1)
        {
//add the new record
        Add();
        }

        else
        {
            Update();
        }
        
        //all done so redirect back to the main page
        //Response.Redirect("DefaultFlight.aspx");
    }

    void DisplayCustomer()
    {
        MyClassLibrary.clsFlightCollection Flights = new clsFlightCollection();
        Flights.ThisFlight.Find(flightid);
        txtFlightNo.Text = Flights.ThisFlight.FlightNo;
       txtAirline.Text =Flights.ThisFlight.Airline;
         txtDestination.Text=Flights.ThisFlight.Destination ;
        txtArrivalAirport.Text = Flights.ThisFlight.ArrivalAirport;
        txtArrivalTime.Text=Flights.ThisFlight.Arrival.ToString();
       txtDepartureTime.Text =Flights.ThisFlight.Departure.ToString();
       txtDepartureAirport.Text =Flights.ThisFlight.DepartureAirport;
        
    }

}