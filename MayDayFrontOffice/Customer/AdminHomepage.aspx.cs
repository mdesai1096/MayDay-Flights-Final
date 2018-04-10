using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyClassLibrary;

public partial class admin_customer : System.Web.UI.Page
{

    //this function handles the load event for the page
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayCustomers();
        }

    }

    void DisplayCustomers()
    {
        //create an instancew of the Customer Collection
        clsCustomerCollection Customers = new clsCustomerCollection();
        // set the data source to the list of countries in the collection
        lstCust.DataSource = Customers.CustomerList;
        // set the name of the primary key
        lstCust.DataValueField = "CustomerID";
        // set the data field to display
        lstCust.DataTextField = "AllDetails";
        //bind the data to the list 
        lstCust.DataBind();

    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 CustomerID;
        //if a record has been selected from the list
        if (lstCust.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            CustomerID = Convert.ToInt32(lstCust.SelectedValue);
            //store the data in the session object
            Session["CustomerID"] = CustomerID;
            //redirect to the delete page
            Response.Redirect("Delete.aspx");
        }
        else //if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";
        }

    }

    protected void btnBacktoHomePage_Click(object sender, EventArgs e)
    {
        //directs back to the home page 
        Response.Redirect("/Misc/Home.aspx");
    }

    protected void btnAdd_Click1(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["CustomerID"] = -1;
        //redirect to the data entry page
        Response.Redirect("FormPage.aspx");
    }

    protected void btnEdit_Click1(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 CustomerID;
        //if a record has been selected from the list
        if (lstCust.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            CustomerID = Convert.ToInt32(lstCust.SelectedValue);
            //store the data in the session object
            Session["CustomerID"] = CustomerID;
            //redirect to the edit page
            Response.Redirect("FormPage.aspx");
        }
        else//if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        //apply will filter by surname and/or postcode 
        FilterPostCode(txtFilter.Text);
    }

    protected void btnDisplayAll_Click(object sender, EventArgs e)
    {
        DisplayCustomers();
        
    }
    void FilterSname(string sname)
    {
        //create an instance of the booking collection
        clsCustomerCollection C = new clsCustomerCollection();
        C.FilterbysurName(sname);
        //set the data source to the list of bookings in the collection
        lstCust.DataSource = C.CustomerList;
        //set the name of the primary key
        lstCust.DataValueField = "CustomerID";
        //set the data field to display
        lstCust.DataTextField = "surName";
        //bind the data to the list
        lstCust.DataBind();
    }
    void FilterPostCode(string PostCode)
    {
        //create an instance of the booking collection
        clsCustomerCollection C = new clsCustomerCollection();
        C.FilterbyPostCode(PostCode);
        //set the data source to the list of bookings in the collection
        lstCust.DataSource = C.CustomerList;
        //set the name of the primary key
        lstCust.DataValueField = "CustomerID";
        //set the data field to display
        lstCust.DataTextField = "PostCode";
        //bind the data to the list
        lstCust.DataBind();
    }



    protected void btnSurname_Click(object sender, EventArgs e)
    {
        FilterSname(txtFilter.Text);
    }
}