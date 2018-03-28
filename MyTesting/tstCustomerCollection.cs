using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;
using System.Collections.Generic;
using Class_Library;

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
            TestItem.DateOfBirth = DateTime.Now.Date.AddYears(-18).ToString();
            TestItem.Gender = "male";
            TestItem.ContactNumber = "01161234567";
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

        [TestMethod]
        public void CountPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //create some test data
            Int32 someCount = 0;
            //assign the data to the property
            AllCustomer.Count = someCount;//test to see that it exists
            Assert.AreEqual(AllCustomer.Count, someCount);
        }

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
            TestCustomer.DateOfBirth = DateTime.Now.Date.AddYears(-18).ToString();
            TestCustomer.Gender = "male";
            TestCustomer.ContactNumber = "01161234567";
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
            TestItem.DateOfBirth = DateTime.Now.Date.AddYears(-18).ToString();
            TestItem.Gender = "male";
            TestItem.ContactNumber = "01161234567";
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

    }
}
