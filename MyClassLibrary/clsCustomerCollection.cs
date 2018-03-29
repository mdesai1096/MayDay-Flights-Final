﻿using MyClassLibrary;
using System;
using System.Collections.Generic;

namespace MyClassLibrary
{
    public class clsCustomerCollection
    {

        private List<clsCustomer> mCustomerList = new List<clsCustomer>();
        //private member thisCustomer
        private clsCustomer mThisCustomer = new clsCustomer();



        //public property for the Customer list
        public List<clsCustomer> CustomerList
        {
            get
            {
                //return the private data
                return mCustomerList;
            }
            set
            {
                //set the private data
                mCustomerList = value;
            }
        }

        //public propery for count
        public int Count
        {
            get
            {
                //return the count of the list
                return mCustomerList.Count;
            }
            set
            {
                //later
            }
        }

        public clsCustomer ThisCustomer
        {
            get
            {
                //return the private data
                return mThisCustomer;
            }
            set
            {
                //set the private data
                mThisCustomer = value;
            }
        }
        ////constructor for the class
        //    public clsCustomerCollection()
        //    {

        //        //create an instance of the data connection class
        //        clsCustomer TestItem = new clsCustomer();
        //        //set the properties
        //        TestItem.ForeName = "fred";
        //        TestItem.Surname = "bloggs";
        //        TestItem.dateOfBirth = DateTime.Now.Date.AddYears(-18);
        //        TestItem.Gender = "male";
        //        TestItem.ContactNumber = "01161234567";
        //        TestItem.EMail = "me@me.com";
        //        TestItem.FlatNo = "1";
        //        TestItem.HouseNo = "2";
        //        TestItem.PostCode = "LE5 6HP";
        //        //add the item to test lists
        //        mCustomerList.Add(TestItem);
        //        //re initalise the object for some new data
        //        TestItem = new clsCustomer();
        //        //set properties
        //        TestItem.ForeName = "fred";
        //        TestItem.Surname = "bloggs";
        //        TestItem.dateOfBirth = DateTime.Now.Date.AddYears(-18);
        //        TestItem.Gender = "male";
        //        TestItem.ContactNumber = "01161234567";
        //        TestItem.EMail = "me@me.com";
        //        TestItem.FlatNo = "1";
        //        TestItem.HouseNo = "2";
        //        TestItem.PostCode = "LE5 6HP";
        //        //add the item to test lists
        //        mCustomerList.Add(TestItem);
        //    }
        //}

        //constructor for the class
        public clsCustomerCollection()
        {

            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procodure
            DB.Execute("sproc_tblCustomer_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //Create a blank Customer
                clsCustomer AnCustomer = new clsCustomer();
                //read in the fields from the current records
                AnCustomer.ForeName = Convert.ToString(DB.DataTable.Rows[Index]["ForeName"]);
                AnCustomer.Surname = Convert.ToString(DB.DataTable.Rows[Index]["Surname"]);
                AnCustomer.dateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateofBirth"]);
                AnCustomer.Gender = Convert.ToString(DB.DataTable.Rows[Index]["Gender"]);
                AnCustomer.ContactNumber = Convert.ToString(DB.DataTable.Rows[Index]["ContactNo"]);
                AnCustomer.EMail = Convert.ToString(DB.DataTable.Rows[Index]["EMail"]);
                AnCustomer.FlatNo = Convert.ToString(DB.DataTable.Rows[Index]["FlatNo"]);
                AnCustomer.HouseNo = Convert.ToString(DB.DataTable.Rows[Index]["HouseNo"]);
                AnCustomer.PostCode = Convert.ToString(DB.DataTable.Rows[Index]["PostCode"]);
                //add the records into a private data member
                mCustomerList.Add(AnCustomer);
                //point to the next record
                Index++;
            }
        }
    }
}



