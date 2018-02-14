﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;
using System.Collections.Generic;

namespace MyTesting
{
    [TestClass]
    public class tstBookingsCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsBookingsCollection AllBookings = new clsBookingsCollection();
            //test to see that it exists
            Assert.IsNotNull(AllBookings);
        }

        [TestMethod]
        public void BookingListOK()
        {
            //create an instance of the class we want to create
            clsBookingsCollection AllBookings = new clsBookingsCollection();
            //create some test data to assign to the property
            //in this sceanario it needs to be a lists of objects
            List<clsBookings> TestList = new List<clsBookings>();
            //add an item to the list
            //create the item of test data
            clsBookings TestItem = new clsBookings();
            //set its properties
            TestItem.BookRef = 1;
            TestItem.Ammount = 50;
            TestItem.DateBooked = DateTime.Now.Date;
            TestItem.PaymentType = "Credit";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllBookings.BookingsList = TestList;//test to see that it exists
            Assert.AreEqual(AllBookings.BookingsList, TestList);
        }

        //[TestMethod]
        //public void CountPropertyOK()
        //{
        //    //create an instance of the class we want to create
        //    clsBookingsCollection AllBookings = new clsBookingsCollection();
        //    //create some test data
        //    Int32 someCount = 2;
        //    //assign the data to the property
        //    AllBookings.Count = someCount;//test to see that it exists
        //    Assert.AreEqual(AllBookings.Count, someCount);
        //}

        [TestMethod]
        public void ThisBookingPropertyOK()
        {
            //create an instance of the class we want to create
            clsBookingsCollection AllBookings = new clsBookingsCollection();
            //create some test data to assign to the property
            //add an item to the list
            clsBookings TestBooking = new clsBookings();
            //set its properties
            TestBooking.BookRef = 1;
            TestBooking.Ammount = 50;
            TestBooking.DateBooked = DateTime.Now.Date;
            TestBooking.PaymentType = "Credit";
            //assign the data to the property
            AllBookings.ThisBookings = TestBooking;//test to see that it exists
            Assert.AreEqual(AllBookings.ThisBookings, TestBooking);
        }


        [TestMethod]
        public void CountBookingsList()
        {
            //create an instance of the class we want to create
            clsBookingsCollection AllBookings = new clsBookingsCollection();
            //create some test data to assign to the property
            //in this sceanario it needs to be a lists of objects
            List<clsBookings> TestList = new List<clsBookings>();
            //add an item to the list
            //create the item of test data
            clsBookings TestItem = new clsBookings();
            //set its properties
            TestItem.BookRef = 1;
            TestItem.Ammount = 50;
            TestItem.DateBooked = DateTime.Now.Date;
            TestItem.PaymentType = "Credit";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllBookings.BookingsList = TestList;//test to see that it exists
            Assert.AreEqual(AllBookings.Count, TestList.Count);
        }

        //[TestMethod]
        //public void TwoRecordsPresent()
        //{
        //    //create an instance of the class we want to create
        //    clsBookingsCollection AllBookings = new clsBookingsCollection();

        //    Assert.AreEqual(AllBookings.Count, 2);
        //}

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsBookingsCollection AllBookings = new clsBookingsCollection();
            //create an instance of test data
            clsBookings TestItem = new clsBookings();
            //var to store primary key
            Int32 PK = 0;
            //set the properties
            //TestItem.BookRef = 3;
            TestItem.Ammount = 80;
            TestItem.DateBooked = DateTime.Now.Date;
            TestItem.PaymentType = "Debit";
            //set ThisBooking to validate test data
            AllBookings.ThisBookings = TestItem;
            //add the record
            PK = AllBookings.Add();
            //set primary key of test data
            TestItem.BookRef = PK;
            //find the record
            AllBookings.ThisBookings.Find(PK);
            //test to see that it exists
            Assert.AreEqual(AllBookings.ThisBookings, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsBookingsCollection AllBookings = new clsBookingsCollection();
            //create an instance of test data
            clsBookings TestItem = new clsBookings();
            //var to store primary key
            Int32 PK = 0;
            //set the properties
            //TestItem.BookRef = 3;
            TestItem.Ammount = 90;
            TestItem.DateBooked = DateTime.Now.Date;
            TestItem.PaymentType = "Debit";
            //set ThisBooking to validate test data
            AllBookings.ThisBookings = TestItem;
            //add the record
            PK = AllBookings.Add();
            //set primary key of test data
            TestItem.BookRef = PK;
            //find the record
            AllBookings.ThisBookings.Find(PK);
            //delete the record
            AllBookings.Delete();
            //now find the record
            Boolean Found = AllBookings.ThisBookings.Find(PK);
            //test to see that it exists
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsBookingsCollection AllBookings = new clsBookingsCollection();
            //create an instance of test data
            clsBookings TestItem = new clsBookings();
            //var to store primary key
            Int32 PK = 0;
            //set the properties
            //TestItem.BookRef = 3;
            TestItem.Ammount = 80;
            TestItem.DateBooked = DateTime.Now.Date;
            TestItem.PaymentType = "Debit";
            //set ThisBooking to validate test data
            AllBookings.ThisBookings = TestItem;
            //add the record
            PK = AllBookings.Add();
            //set primary key of test data
            TestItem.BookRef = PK;
            //modify the record
            //TestItem.BookRef = 3;
            TestItem.Ammount = 40;
            TestItem.DateBooked = DateTime.Now.Date;
            TestItem.PaymentType = "Credit";
            //set the record based on the new record
            AllBookings.ThisBookings = TestItem;
            //update the record
            AllBookings.Update();
            //find the record
            AllBookings.ThisBookings.Find(PK);
            //test to see that it exists
            Assert.AreEqual(AllBookings.ThisBookings, TestItem);
        }

    }
}
