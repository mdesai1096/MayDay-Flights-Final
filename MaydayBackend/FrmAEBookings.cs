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

//Author Mohammad Desai//

namespace MaydayBackend
{
    public partial class FrmAEBookings : Form
    {
        //public property for BookingRef
        public int BookingRef { get; private set; }

        public FrmAEBookings( Int32 BookRef)
        {
            //get the selected index from frmBooking main and set it as the bookref
            this.BookingRef = BookRef;
            InitializeComponent();
            //if this is not a new record
            if (BookingRef != -1)
            {
                //chnange the title of the form
                lblTitle.Text = "Edit Booking";
                //chnange the title bar of the form
                this.Text = "Edit Booking";
                //make the text box read only so it the pk cannot be changed.
                txtBookRef.ReadOnly = true;
                //populate the text boxes with the selected data
                DisplayBookings();
            }
            else //this is a new record
            {
                //make the textbox and label invisible
                txtBookRef.Visible = false;
                lblBookRef.Visible = false;
                //change the title bar of the from
                this.Text = "New Booking";
                //change the title displayed in the form
                lblTitle.Text = "New Booking";
                //populate the text box with todays date
                txtDateBo.Text = DateTime.Today.Date.ToString("dd/MM/yyyy");

            }
            
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //if the Booking is equal the -1
            if (BookingRef == -1)
            {
                //this is a new record call the ADD fucntion
                Add();
            }
            else //this is an exisitng record
            {
                //call the fucntion to update the record
                Update1();

            }
            
        }

        //function for adding new records
        void Add()
        {
            //create an instance of the booking list
            clsBookingsCollection BookingsList = new clsBookingsCollection();
            //validate the data on the web form
            String Error = BookingsList.ThisBookings.Valid(txtAmount.Text, txtDateBo.Text, txtPayType.Text);
            //if the data is OK then add it to the object
            if (Error == "")
            {

                //get the data entered by the user
                BookingsList.ThisBookings.Ammount = Convert.ToDecimal(txtAmount.Text);
                BookingsList.ThisBookings.DateBooked = Convert.ToDateTime(txtDateBo.Text);
                BookingsList.ThisBookings.PaymentType = txtPayType.Text;
                //add the record
                BookingsList.Add();
                //all done so redirect back to the main page
                lblError.Text = "Sucessfully Booked";
            }
            else
            {
                //report an error
                lblError.Text = "There were problems with the data entered " + Error;
            }
        }

        //function for updating records
        void Update1()
        {
            //create an instance of the booking list
            clsBookingsCollection BookingsList = new clsBookingsCollection();
            //validate the data on the web form
            String Error = BookingsList.ThisBookings.Valid(txtAmount.Text, txtDateBo.Text, txtPayType.Text);
            //if the data is OK then add it to the object
            if (Error == "")
            {
                //find the record to update
                BookingsList.ThisBookings.Find(BookingRef);
                //get the data entered by the user
                BookingsList.ThisBookings.Ammount = Convert.ToDecimal(txtAmount.Text);
                BookingsList.ThisBookings.DateBooked = Convert.ToDateTime(txtDateBo.Text);
                BookingsList.ThisBookings.PaymentType = txtPayType.Text;
                //update the record
                BookingsList.Update();
                //all done so redirect back to the main page
                lblError.Text = "Sucessfully Updated";
            }
            else
            {
                //report an error
                lblError.Text = "There were problems with the data entered " + Error;
            }
        }
        private void FrmAEBookings_Load(object sender, EventArgs e)
        {

        }




        

        void DisplayBookings()
        {
            //create an instance of the booking list
            clsBookingsCollection BookingsList = new clsBookingsCollection();
            //find the record to update
            BookingsList.ThisBookings.Find(BookingRef);
            //display the data for this record
            txtBookRef.Text = BookingsList.ThisBookings.BookRef.ToString();
            txtAmount.Text = BookingsList.ThisBookings.Ammount.ToString();
            txtDateBo.Text = BookingsList.ThisBookings.DateBooked.ToString();
            txtPayType.Text = BookingsList.ThisBookings.PaymentType;

        }


    }
}
