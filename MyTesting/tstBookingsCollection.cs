using System;
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
        //    Int32 someCount = 0;
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



    }
}
