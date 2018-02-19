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
    public partial class frmBookingMain : Form
    {
        public frmBookingMain()
        {
            InitializeComponent();
        }

        private void btnPopulate_Click(object sender, EventArgs e)
        {
            //call the display user fumction
            lblError.Text = DisplayBookings() + " found";
        }

        Int32 DisplayBookings()
        {
            //create an instance of the booking collection
            clsBookingsCollection Bookings = new clsBookingsCollection();
            //set the data source to the list of bookings in the collection
            lstBookings.DataSource = Bookings.BookingsList;
            //set the name of the primary key
            lstBookings.ValueMember = "BookRef";
            //set the data field to display
            lstBookings.DisplayMember = "BookRef";
            //return the count of records in the list
            return Bookings.Count;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
           lblError.Text = FilterBookingsRef(txtBookRef.Text) + " Found";
             
        }

        Int32 FilterBookingsRef(string BookRef)
        {
            //create an instance of the booking collection
            clsBookingsCollection Bookings = new clsBookingsCollection();
            Bookings.FilterbyBookRef(BookRef);
            //set the data source to the list of bookings in the collection
            lstBookings.DataSource = Bookings.BookingsList;
            //set the name of the primary key
            lstBookings.ValueMember = "BookRef";
            //set the data field to display
            lstBookings.DisplayMember = "BookRef";
            //bind the data to the list
            return Bookings.Count;
        }

        Int32 FilterBookingsDateRange(string Date1, string Date2)
        {
            //create an instance of the booking collection
            clsBookingsCollection Bookings = new clsBookingsCollection();
            Bookings.FilterbyDateBooked(Date1, Date2);
            //set the data source to the list of bookings in the collection
            lstBookings.DataSource = Bookings.BookingsList;
            //set the name of the primary key
            lstBookings.ValueMember = "BookRef";
            //set the data field to display
            lstBookings.DisplayMember = "DateBooked";
            //bind the data to the list
            return Bookings.Count;
        }

        private void btnDFilter_Click(object sender, EventArgs e)
        {
            lblError.Text = FilterBookingsDateRange(txtDate1.Text, txtDate2.Text) + " Found";
        }
    }
}
