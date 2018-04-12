using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyClassLibrary;

public partial class Bookings_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //display their user name
            lblUser.Text = "The current user is " + User.Identity.Name;
            //write whatever the date was is 1 year in the past in the start date text box
            txtStartDate.Text = DateTime.Today.Date.AddYears(-1).ToString("dd/MM/yyyy");
            //write whatever the date was is today in the end date text box
            txtEndDate.Text = DateTime.Today.Date.ToString("dd/MM/yyyy");
            //if an admin has loggedin
            if (User.IsInRole("admin"))
            {
                //populate the text box with all boooking
                DisplayBookings();
                //show the buttons
                btnFilter.Visible = true;
                txtFilter.Visible = true;
                btnDelete.Visible = true;
            }
            else //if any other user
            {               
                //update the list box
                FilterBookingsDateRange(DateTime.Today.Date.AddYears(-5).ToString(), DateTime.Today.Date.ToString());
                //hide the buttons
                btnFilter.Visible = false;
                txtFilter.Visible = false;
                btnDelete.Visible = false;
            }

        }
    }

    protected void btnNew_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["BookRef"] = -1;
        //redirect to the data entry page
        Response.Redirect("AEBookings.aspx");
    }

    void DisplayBookings()
    {
        //create an instance of the booking collection
        clsBookingsCollection Bookings = new clsBookingsCollection();
        //set the data source to the list of bookings in the collection
        lstBookings.DataSource = Bookings.BookingsList;
        //set the name of the primary key
        lstBookings.DataValueField = "BookRef";
        //set the data field to display
        lstBookings.DataTextField = "AllDetails";
        //bind the data to the list
        lstBookings.DataBind();
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 BookRef;
        //if a record has been selected from the list
        if (lstBookings.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            BookRef = Convert.ToInt32(lstBookings.SelectedValue);
            //store the data in the session object
            Session["BookRef"] = BookRef;
            //redirect to the edit page
            Response.Redirect("AEBookings.aspx");
        }
        else//if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 BookRef;
        //if a record has been selected from the list
        if (lstBookings.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            BookRef = Convert.ToInt32(lstBookings.SelectedValue);
            //store the data in the session object
            Session["BookRef"] = BookRef;
            //redirect to the delete page
            Response.Redirect("Delete.aspx");
        }
        else //if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnFilter_Click(object sender, EventArgs e)
    {
    
        FilterSurname(txtFilter.Text);
    }

    void FilterBookingsRef(string BookRef)
    {
        //create an instance of the booking collection
        clsBookingsCollection Bookings = new clsBookingsCollection();
        Bookings.FilterbyBookRef(BookRef);
        //set the data source to the list of bookings in the collection
        lstBookings.DataSource = Bookings.BookingsList;
        //set the name of the primary key
        lstBookings.DataValueField = "BookRef";
        //set the data field to display
        lstBookings.DataTextField = "AllDetails";
        //bind the data to the list
        lstBookings.DataBind();
    }

    void FilterSurname (string Surname)
    {
        //create an instance of the booking collection
        clsBookingsCollection Bookings = new clsBookingsCollection();
        Bookings.FilterSurname(Surname);
        //set the data source to the list of bookings in the collection
        lstBookings.DataSource = Bookings.BookingsList;
        //set the name of the primary key
        lstBookings.DataValueField = "BookRef";
        //set the data field to display
        lstBookings.DataTextField = "AllCDetails";
        //bind the data to the list
        lstBookings.DataBind();
    }

    protected void btnFDate_Click(object sender, EventArgs e)
    {

        //create an instance of the booking list
        clsBookingsCollection BookingsList = new clsBookingsCollection(User.Identity.Name);
        //validate the data on the web form
        String Error = BookingsList.ThisBookings.ValidDateFilter(txtStartDate.Text, txtEndDate.Text);
        //if the data is OK then add it to the object
        if (Error == "")
        {
            //display the number of record found after filtering has been applied
             FilterBookingsDateRange(txtStartDate.Text, txtEndDate.Text);
            //clear the label
            lblError.Text = "";
        }
        else
        {
            //report an error
            lblError.Text = "There were problems with the data entered " + Error;
            //display all bookings
            //DisplayBookings();
        }

    }

    void FilterBookingsDateRange(string StartDate, string EndDate)
    {
        //create an instance of the booking collection
        clsBookingsCollection Bookings = new clsBookingsCollection(User.Identity.Name);
        Bookings.FilterbyDateBooked(StartDate, EndDate);
        //set the data source to the list of bookings in the collection
        lstBookings.DataSource = Bookings.BookingsList;
        //set the name of the primary key
        lstBookings.DataValueField = "BookRef";
        //set the data field to display
        lstBookings.DataTextField = "AllDetails";
        //bind the data to the list
        lstBookings.DataBind();
    }

}