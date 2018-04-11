using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyClassLibrary;

public partial class EditCustomer : System.Web.UI.Page
{
    Int32 CustomerID;
    protected void Page_Load(object sender, EventArgs e)
    {

        //get the pk of the booking to be processed
        CustomerID = Convert.ToInt32(Session["CustomerID"]);
        if (IsPostBack == false)
        {

            //if this is not a new record
            if (CustomerID != -1)
            {
                //display the current data for the record
                DisplayCust();

            }
        }
        }

    protected void btnBackToAdminHomePage_Click(object sender, EventArgs e)
    {
        //This will take you back to Admin Home Page 
        Response.Redirect("AdminHomepage.aspx");
    }

    protected void btnBacktoCustomerHomePage_Click(object sender, EventArgs e)
    {
        // this will then take you back to the customer Home Page 
        Response.Redirect("CustomerHomepage.aspx");
    }

    protected void btnBacktoLoginPage_Click(object sender, EventArgs e)
    {
        //directs back to the home page 
        Response.Redirect("/Misc/Home.aspx");
    }

    protected void btnEnter_Click(object sender, EventArgs e)
    {
        //This will then enter the information you have enterted in the form
        if (CustomerID == -1)
        {
            //add the new record
            Add();
        }
        else
        {
            //update the record
            Update();
        }
    }

    //function for Adding records
    void Add()
    {
        //create an instance of the booking list
        clsCustomerCollection CList = new clsCustomerCollection(User.Identity.Name);
        //validate the data on the web form
        //string foreName, string surname, string dateOfBirth, string gender, string contactNumber, string eMail, string flatNo, string houseNo, string postCode
        String Error = CList.ThisCustomer.Valid(txtForename.Text, txtSurname.Text, txtDateOfBirth.Text, txtGender.Text, txtContactNumber.Text, txtEmail.Text, txtFlatNo.Text, txtHouseNumber.Text, txtPostCode.Text);
        //if the data is OK then add it to the object
        if (Error == "")
        {
         
            //get the data entered by the user
            CList.ThisCustomer.Surname = txtSurname.Text;
            CList.ThisCustomer.ForeName = txtForename.Text;
            CList.ThisCustomer.dateOfBirth = Convert.ToDateTime(txtDateOfBirth.Text);
            CList.ThisCustomer.HouseNo = txtHouseNumber.Text;
            CList.ThisCustomer.FlatNo = txtFlatNo.Text;
            CList.ThisCustomer.PostCode = txtPostCode.Text;
            CList.ThisCustomer.Gender = txtGender.Text;
            CList.ThisCustomer.ContactNumber =txtContactNumber.Text;
            CList.ThisCustomer.EMail = txtEmail.Text;
            //CList.ThisCustomer.UserName = User.Identity.Name;
            //update the record
            CList.Add();
            //all done so redirect back to the main page
            Response.Redirect("AdminHomepage.aspx");
        }
        else
        {
            //report an error
            lblError.Text = "There were problems with the data entered " + Error;
        }
    }
    //function for updating records
    void Update()
    {
        //create an instance of the booking list
        clsCustomerCollection CList = new clsCustomerCollection(User.Identity.Name);
        //validate the data on the web form
                                                 //string foreName, string surname, string dateOfBirth, string gender, string contactNumber, string eMail, string flatNo, string houseNo, string postCode
        String Error = CList.ThisCustomer.Valid(txtForename.Text, txtSurname.Text, txtDateOfBirth.Text, txtGender.Text, txtContactNumber.Text, txtEmail.Text, txtFlatNo.Text, txtHouseNumber.Text, txtPostCode.Text);
        //if the data is OK then add it to the object
        if (Error == "")
        {
            //find the record to update
            CList.ThisCustomer.Find(CustomerID);
            //get the data entered by the user
            CList.ThisCustomer.Surname = Convert.ToString(txtSurname.Text);
            CList.ThisCustomer.ForeName = Convert.ToString(txtForename.Text);
            CList.ThisCustomer.dateOfBirth = Convert.ToDateTime(txtDateOfBirth.Text);
            CList.ThisCustomer.HouseNo = Convert.ToString(txtHouseNumber.Text);
            CList.ThisCustomer.FlatNo = Convert.ToString(txtFlatNo.Text);
            CList.ThisCustomer.PostCode = Convert.ToString(txtPostCode.Text);
            CList.ThisCustomer.Gender = Convert.ToString(txtGender.Text);
            CList.ThisCustomer.ContactNumber = Convert.ToString(txtContactNumber.Text);
            CList.ThisCustomer.EMail = Convert.ToString(txtEmail.Text);
            //CList.ThisCustomer.UserName = User.Identity.Name;
            //update the record
            CList.Update();
            //all done so redirect back to the main page
            Response.Redirect("AdminHomepage.aspx");
        }
        else
        {
            //report an error
            lblError.Text = "There were problems with the data entered " + Error;
        }
    }

    void DisplayCust( )
    {
        //create an instance of the booking list
        clsCustomerCollection CList = new clsCustomerCollection();
        //find the record to update
        CList.ThisCustomer.Find(CustomerID);
        //display the data for this record
        txtSurname.Text = CList.ThisCustomer.Surname;
        txtForename.Text = CList.ThisCustomer.ForeName;
        txtDateOfBirth.Text = CList.ThisCustomer.dateOfBirth.ToString();
        txtHouseNumber.Text = CList.ThisCustomer.HouseNo;
        txtFlatNo.Text = CList.ThisCustomer.FlatNo;
        txtPostCode.Text = CList.ThisCustomer.PostCode;
        txtGender.Text = CList.ThisCustomer.Gender;
        txtContactNumber.Text = CList.ThisCustomer.ContactNumber;
        txtEmail.Text = CList.ThisCustomer.EMail;

    }
}