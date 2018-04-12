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
    public partial class frmFlightsMain : Form
    {
        public frmFlightsMain()
        {
            InitializeComponent();
            lblError.Text = DisplayBookings() + "Found";
            DisplayBookings();
        }

        private void lblFRef_Click(object sender, EventArgs e)
        {

        }

        private void lstBookings_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            lblError.Text = FilterByDestination(txtFilter.Text) + "Found";

        }

        Int32 DisplayBookings()
        {
            //create an instance of the booking collection
            clsFlightCollection Bookings = new clsFlightCollection();
            //set the data source to the list of bookings in the collection
            lstFlights.DataSource = Bookings.FlightList;
            //set the name of the primary key
            lstFlights.ValueMember = "FlightID";
            //set the data field to display
            lstFlights.DisplayMember = "FlightNo";
            //bind the data to the list
            return Bookings.Count;
        }

        Int32 FilterByDestination(string Destination)
        {
            //create an instance of the booking collection
            clsFlightCollection C = new clsFlightCollection();
            C.FilterByDestination(Destination);
            //set the data source to the list of bookings in the collection
            lstFlights.DataSource = C.FlightList;
            //set the name of the primary key
            lstFlights.ValueMember = "FlightID";
            //set the data field to display
            lstFlights.DisplayMember = "Destination";
            //bind the data to the list
            return C.Count;
        }

        private void frmFlightsMain_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmAddEditFlight Edit = new frmAddEditFlight(Convert.ToInt32(lstFlights.SelectedValue));
            Edit.Visible = true;
        }
    }
}
