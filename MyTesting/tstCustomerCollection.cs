using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;
using System.Collections.Generic;

namespace MyTesting
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //test to see that it exists
            Assert.IsNotNull(AllCustomer);
        }

        [TestMethod]
        public void CustomerListOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this sceanario it needs to be a lists of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.ForeName = "fred";
            TestItem.Surname = "bloggs";
            TestItem.dateOfBirth = DateTime.Now.Date.AddYears(-19);
            TestItem.Gender = "male";
            TestItem.ContactNumber = "01167";
            TestItem.EMail = "me@me.com";
            TestItem.FlatNo = "1";
            TestItem.HouseNo = "2";
            TestItem.PostCode = "LE5 6HP";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomer.CustomerList = TestList;//test to see that it exists
            Assert.AreEqual(AllCustomer.CustomerList, TestList);
        }


        //[TestMethod]
        //public void CountPropertyOK()
        //{
        //    //create an instance of the class we want to create
        //    clsCustomerCollection AllCustomer = new clsCustomerCollection();
        //    //create some test data
        //    Int32 someCount = 2;
        //    //assign the data to the property
        //    AllCustomer.Count = someCount;//test to see that it exists
        //    Assert.AreEqual(AllCustomer.Count, someCount);
        //}

        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //create some test data to assign to the property
            //add an item to the list
            clsCustomer TestCustomer = new clsCustomer();
            //set its properties
            TestCustomer.ForeName = "fred";
            TestCustomer.Surname = "bloggs";
            TestCustomer.dateOfBirth = DateTime.Now.Date.AddYears(-19);
            TestCustomer.Gender = "male";
            TestCustomer.ContactNumber = "12354";
            TestCustomer.EMail = "me@me.com";
            TestCustomer.FlatNo = "1";
            TestCustomer.HouseNo = "2";
            TestCustomer.PostCode = "LE5 6HP";
            //assign the data to the property
            AllCustomer.ThisCustomer = TestCustomer;//test to see that it exists
            Assert.AreEqual(AllCustomer.ThisCustomer, TestCustomer);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this sceanario it needs to be a lists of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.ForeName = "fred";
            TestItem.Surname = "bloggs";
            TestItem.dateOfBirth = DateTime.Now.Date.AddYears(-19);
            TestItem.Gender = "male";
            TestItem.ContactNumber = "12314";
            TestItem.EMail = "me@me.com";
            TestItem.FlatNo = "1";
            TestItem.HouseNo = "2";
            TestItem.PostCode = "LE5 6HP";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomer.CustomerList = TestList;//test to see that it exists
            Assert.AreEqual(AllCustomer.Count, TestList.Count);
        }

        [TestMethod]

        //[TestMethod]
        //public void TwoRecordsPresent()
        //{
        //    //create an instance of the class we want to create
        //    clsCustomerCollection AllCustomer = new clsCustomerCollection();
        //    //test to see that the two values are the same
        //    Assert.AreEqual(AllCustomer.Count, 2);
        //}
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //create an instance of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store primary key
            Int32 PK = 0;
            //set the properties
            //TestItem.CustomerID = 3;
            TestItem.ForeName = "fred";
            TestItem.Surname = "bloggs";
            TestItem.dateOfBirth = DateTime.Now.Date.AddYears(-19);
            TestItem.Gender = "male";
            TestItem.ContactNumber = "12314";
            TestItem.EMail = "me@me.com";
            TestItem.FlatNo = "1";
            TestItem.HouseNo = "2";
            TestItem.PostCode = "LE56HP";
            //set ThisCustomer to validate test data
            AllCustomer.ThisCustomer = TestItem;
            //add the record
            PK = AllCustomer.Add();
            //set primary key of test data
            TestItem.CustomerID = PK;
            //find the record
            AllCustomer.ThisCustomer.Find(PK);
            //test to see that it exists
            Assert.AreEqual(AllCustomer.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //create an instance of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store primary key
            Int32 PK = 0;
            //set the properties
            //TestItem.CustomerID = 3;
            TestItem.ForeName = "fred";
            TestItem.Surname = "bloggs";
            TestItem.dateOfBirth = DateTime.Now.Date.AddYears(-19);
            TestItem.Gender = "male";
            TestItem.ContactNumber = "12314";
            TestItem.EMail = "me@me.com";
            TestItem.FlatNo = "1";
            TestItem.HouseNo = "2";
            TestItem.PostCode = "LE56HP";
            //set ThisCustomer to validate test data
            AllCustomer.ThisCustomer = TestItem;
            //add the record
            PK = AllCustomer.Add();
            //set primary key of test data
            TestItem.CustomerID = PK;
            //find the record
            AllCustomer.ThisCustomer.Find(PK);
            //delete the record
            AllCustomer.Delete();
            //now find the record
            Boolean Found = AllCustomer.ThisCustomer.Find(PK);
            //test to see that it exists
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //create an instance of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store primary key
            Int32 PK = 0;
            //set the properties
            //TestItem.BookRef = 3;
            TestItem.ForeName = "fred";
            TestItem.Surname = "bloggs";
            TestItem.dateOfBirth = DateTime.Now.Date.AddYears(-19);
            TestItem.Gender = "male";
            TestItem.ContactNumber = "12314";
            TestItem.EMail = "me@me.com";
            TestItem.FlatNo = "1";
            TestItem.HouseNo = "2";
            TestItem.PostCode = "LE56HP";
            //set ThisBooking to validate test data
            AllCustomer.ThisCustomer = TestItem;
            //add the record
            PK = AllCustomer.Add();
            //set primary key of test data
            TestItem.CustomerID = PK;
            //modify the record
            //TestItem.BookRef = 3;
            TestItem.ForeName = "Lisa";
            TestItem.Surname = "Smith";
            TestItem.dateOfBirth = DateTime.Now.Date.AddYears(-20);
            TestItem.Gender = "Female";
            TestItem.ContactNumber = "000010";
            TestItem.EMail = "you@you.com";
            TestItem.FlatNo = "2";
            TestItem.HouseNo = "3";
            TestItem.PostCode = "LE1234";
            //set the record based on the new record
            AllCustomer.ThisCustomer = TestItem;
            //update the record
            AllCustomer.Update();
            //find the record
            AllCustomer.ThisCustomer.Find(PK);
            //test to see that it exists
            Assert.AreEqual(AllCustomer.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void FilterbyPostCodeMethodOK()
        {
            clsCustomer TestItem = new clsCustomer();
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //apply a blank string (should return all records)
            FilteredCustomers.FilterbyPostCode("");
            //test to see the two values are the same
            Assert.AreEqual(AllCustomer.Count, FilteredCustomers.Count);
        }

        [TestMethod]
        public void FilterbyPostCodeNoneFound()
        {
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //apply a blank string (should return all records)
            FilteredCustomers.FilterbyPostCode("xxx xxx");
            //test to see the two values are the same
            Assert.AreEqual(0, FilteredCustomers.Count);
        }

        [TestMethod]
        public void FilterbyPostcodeTestDataFound()
        {
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a primary key value 
            FilteredCustomers.FilterbyPostCode("yyy yyy");
            //check the correct number of records are found
            if (FilteredCustomers.Count == 2)
            {
                //check the first record is ID 2
                if (FilteredCustomers.CustomerList[0].CustomerID != 8)
                {
                    OK = false;
                }
                // check that the first record is ID
                if (FilteredCustomers.CustomerList[1].CustomerID != 17)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }

            //test to see there are records
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void FilterbysurNameMethodOK()
        {
            clsCustomer TestItem = new clsCustomer();
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //apply a blank string (should return all records)
            FilteredCustomers.FilterbysurName("");
            //test to see the two values are the same
            Assert.AreEqual(AllCustomer.Count, FilteredCustomers.Count);
        }

        [TestMethod]
        public void FilterbysurNameNoneFound()
        {
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //apply a blank string (should return all records)
            FilteredCustomers.FilterbysurName("xxx xxx");
            //test to see the two values are the same
            Assert.AreEqual(0, FilteredCustomers.Count);
        }

        [TestMethod]
        public void FilterbysurNameTestDataFound()
        {
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a primary key value 
            FilteredCustomers.FilterbysurName("yyyyyy");
            //check the correct number of records are found
            if (FilteredCustomers.Count == 2)
            {
                //check the first record is ID 2
                if (FilteredCustomers.CustomerList[0].CustomerID != 22)
                {
                    OK = false;
                }
                // check that the first record is ID
                if (FilteredCustomers.CustomerList[1].CustomerID != 26)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }

            //test to see there are records
            Assert.IsTrue(OK);
        }
    }
}





