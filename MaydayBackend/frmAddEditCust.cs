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
    public partial class frmAddEditCust : Form
    {
        public int CustID { get; private set; }

        public frmAddEditCust(Int32 custID)
        {
            this.CustID = custID;
            InitializeComponent();
            //if this is not a new record
            if (CustID != -1)
            {
                //display the current data for the record
                DisplayCust();

            }
        }



        private void btnEnter_Click(object sender, EventArgs e)
        {
            //This will then enter the information you have enterted in the form
            if (CustID == -1)
            {
                //add the new record
                Add();
                lblError.Text = "Sucuess";
            }
            else
            {
                //update the record
                Update50();
                lblError.Text = "Update Sucuess";
            }
        }

        //function for Adding records
        void Add()
        {
            //create an instance of the booking list
            clsCustomerCollection CList = new clsCustomerCollection();
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
                CList.ThisCustomer.ContactNumber = txtContactNumber.Text;
                CList.ThisCustomer.EMail = txtEmail.Text;
                //update the record
                CList.Add();

            }
            else
            {
                //report an error
                lblError.Text = "There were problems with the data entered " + Error;
            }
        }
        //function for updating records
        void Update50()
        {
            //create an instance of the booking list
            clsCustomerCollection CList = new clsCustomerCollection();
            //validate the data on the web form
            //string foreName, string surname, string dateOfBirth, string gender, string contactNumber, string eMail, string flatNo, string houseNo, string postCode
            String Error = CList.ThisCustomer.Valid(txtForename.Text, txtSurname.Text, txtDateOfBirth.Text, txtGender.Text, txtContactNumber.Text, txtEmail.Text, txtFlatNo.Text, txtHouseNumber.Text, txtPostCode.Text);
            //if the data is OK then add it to the object
            if (Error == "")
            {
                //find the record to update
                CList.ThisCustomer.Find(CustID);
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
                //update the record
                CList.Update();
                
            }
            else
            {
                //report an error
                lblError.Text = "There were problems with the data entered " + Error;
            }
        }

        void DisplayCust()
        {
            //create an instance of the booking list
            clsCustomerCollection CList = new clsCustomerCollection();
            //find the record to update
            CList.ThisCustomer.Find(CustID);
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
}
