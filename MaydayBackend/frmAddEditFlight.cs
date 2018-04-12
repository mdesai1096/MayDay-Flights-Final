using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyClassLibrary;

namespace MaydayBackend
{
    public partial class frmAddEditFlight : Form
    {
        public frmAddEditFlight(Int32 FlightID)
        {
            this.FlightID = FlightID;
            InitializeComponent();
            if (FlightID != -1)
            {
                //display the current data for the record)
                DisplayFlight();
            }
                

        }

        public int FlightID { get; private set; }

        private void frmAddEditFlight_Load(object sender, EventArgs e)
        {

        }
        //function for adding new records
        void Add()
        {
            //create an instance of the flight book
            MyClassLibrary.clsFlightCollection Flights = new clsFlightCollection();
            //validate the data on the web form
            string Error = Flights.ThisFlight.Valid(txtFlightNo.Text, txtAirline.Text, txtDestination.Text, txtArrivalTime.Text, txtArrival.Text, txtDepartureTime.Text, txtDeparture.Text);
            //if the data is OK then add it to the object
            if (Error == "")
            {
                //get the data entered by the user
                Flights.ThisFlight.FlightNo = txtFlightNo.Text;
                Flights.ThisFlight.Airline = txtAirline.Text;
                Flights.ThisFlight.Destination = txtDestination.Text;
                Flights.ThisFlight.ArrivalAirport = txtArrival.Text;
                Flights.ThisFlight.Arrival = Convert.ToDateTime(txtArrivalTime.Text);
                Flights.ThisFlight.Departure = Convert.ToDateTime(txtDepartureTime.Text);
                Flights.ThisFlight.DepartureAirport = txtDeparture.Text;

                //add the record
                Flights.Add();
                //all done so redirect back to the main page


            }
            else
            {
                //report an error
                lblError.Text = "There were problems with the data entered" + Error;
            }
        }

            void Update40()
        {
            //create an instance of the flight book
            MyClassLibrary.clsFlightCollection Flights = new clsFlightCollection();
            //validate the data on the web form
            string Error = Flights.ThisFlight.Valid(txtFlightNo.Text, txtAirline.Text, txtDestination.Text, txtArrivalTime.Text, txtArrivalTime.Text, txtDepartureTime.Text, txtDepartureTime.Text);
            //if the data is OK then add it to the object
            if (Error == "")

            {
                //get the data entered by the user
                Flights.ThisFlight.Find(FlightID);
                Flights.ThisFlight.FlightNo = txtFlightNo.Text;
                Flights.ThisFlight.Airline = txtAirline.Text;
                Flights.ThisFlight.Destination = txtDestination.Text;
                Flights.ThisFlight.ArrivalAirport = txtArrivalTime.Text;
                Flights.ThisFlight.Arrival = Convert.ToDateTime(txtArrivalTime.Text);
                Flights.ThisFlight.Departure = Convert.ToDateTime(txtDepartureTime.Text);
                Flights.ThisFlight.DepartureAirport = txtDepartureTime.Text;

                //add the record
                Flights.Update();
                //all done so redirect back to the main page
                //Response.Redirect("frmFlightsMain.cs");

            }
            else
            {
                //report an error
                lblError.Text = "There were problems with the data entered" + Error;
            }
        }

        void DisplayFlight()
        {
            MyClassLibrary.clsFlightCollection Flights = new clsFlightCollection();
            Flights.ThisFlight.Find(FlightID);
            txtFlightNo.Text = Flights.ThisFlight.FlightNo;
            txtAirline.Text = Flights.ThisFlight.Airline;
            txtDestination.Text = Flights.ThisFlight.Destination;
            txtArrival.Text = Flights.ThisFlight.ArrivalAirport;
            txtArrivalTime.Text = Flights.ThisFlight.Arrival.ToString();
            txtDepartureTime.Text = Flights.ThisFlight.Departure.ToString();
            txtDeparture.Text = Flights.ThisFlight.DepartureAirport;

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (FlightID == -1)
            {
                //add the new record
                Add();
            }

            else
            {
                Update40();
            }
        }
    }
}

       