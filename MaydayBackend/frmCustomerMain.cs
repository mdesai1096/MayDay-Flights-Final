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
    public partial class frmCustomerMain : Form
    {
        Int32 custID;
        public frmCustomerMain()
        {
            InitializeComponent();
            lblError.Text = DisplayCustomers() + "Found";
        }

        
        private void frmCustomerMain_Load(object sender, EventArgs e)
        {
            
            
        }

        Int32 DisplayCustomers()
        {
            //create an instancew of the Customer Collection
            clsCustomerCollection Customers = new clsCustomerCollection();
            // set the data source to the list of countries in the collection
            lstCust.DataSource = Customers.CustomerList;
            // set the name of the primary key
            lstCust.ValueMember = "CustomerID";
            // set the data field to display
            lstCust.DisplayMember = "AllDetails";
            //bind the data to the list 
            
            return Customers.Count ;

        }

        Int32 FilterPostCode(string PostCode)
        {
            //create an instance of the booking collection
            clsCustomerCollection C = new clsCustomerCollection();
            C.FilterbyPostCode(PostCode);
            //set the data source to the list of bookings in the collection
            lstCust.DataSource = C.CustomerList;
            //set the name of the primary key
            lstCust.ValueMember = "CustomerID";
            //set the data field to display
            lstCust.DisplayMember = "PostCode";
            //bind the data to the list
            return C.Count;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            lblError.Text = FilterPostCode(txtFilter.Text) + "Found";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEditCust Add = new frmAddEditCust(-1);
            Add.Visible = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmAddEditCust Edit = new frmAddEditCust(Convert.ToInt32(lstCust.SelectedValue));
            Edit.Visible = true ;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //get the primary key value of the record to delete   
            custID = Convert.ToInt32(lstCust.SelectedValue);
            //delete the record   
            lblError.Text = "Booking Reference " + DeleteCust() + " Canceled";
            //refesh list box   
            DisplayCustomers();
        }

        Int32 DeleteCust()
        {
            clsCustomerCollection CustList = new clsCustomerCollection();
            CustList.ThisCustomer.Find(custID);
            CustList.Delete();
            return custID;
        }

        private void btnDisplayAll_Click(object sender, EventArgs e)
        {
            lblError.Text = DisplayCustomers() + " found";
        }

        private void btnFilterbySurname_Click(object sender, EventArgs e)
        {
            lblError.Text = FilterSname(txtFilter.Text) + "Found";
        }

        Int32 FilterSname(string sname)
        {
            //create an instance of the booking collection
            clsCustomerCollection C = new clsCustomerCollection();
            C.FilterbysurName(sname);
            //set the data source to the list of bookings in the collection
            lstCust.DataSource = C.CustomerList;
            //set the name of the primary key
            lstCust.ValueMember = "CustomerID";
            //set the data field to display
            lstCust.DisplayMember = "surName";
            //bind the data to the list
            return C.Count;
        }
    }
}
