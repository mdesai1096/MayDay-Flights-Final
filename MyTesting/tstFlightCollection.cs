using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;
using System.Collections.Generic;

namespace MyTesting
{
    [TestClass]
    public class tstFlightCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsFlightCollection AllFlights = new clsFlightCollection();
            //test to see that it exists
            Assert.IsNotNull(AllFlights);
        }

        [TestMethod]
        public void FlightListOK()
        {
            //create an instance of the class we want to create
            clsFlightCollection AllFlights = new clsFlightCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsFlights> TestList = new List<clsFlights>();
            //add an item to the list
            //create the item of test data
            clsFlights TestItem = new clsFlights();
            //set its properties
            TestItem.Flight_No = 1;
            TestItem.Airline = "Air India";
            TestItem.ArrivalAirport = "BHX";
            TestItem.Arrival = DateTime.Now.Date;
            TestItem.Departure = DateTime.Now.Date;
            TestItem.DepartureAirport = "BHX";
            TestItem.Destination = "India";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllFlights.FlightList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllFlights.FlightList, TestList);
        }



        [TestMethod]
        public void ThisFlightsPropertyOK()
        {
            //create an instance of the class we want to create
            clsFlightCollection AllFlights = new clsFlightCollection();
            //create some test data to assign to the property
            clsFlights TestFlights = new clsFlights();
            //set the properties of the test object
            TestFlights.Flight_No = 1;
            TestFlights.Airline = "Air India";
            TestFlights.ArrivalAirport = "BHX";
            TestFlights.Arrival = DateTime.Now.Date;
            TestFlights.Departure = DateTime.Now.Date;
            TestFlights.DepartureAirport = "BHX";
            TestFlights.Destination = "India";
            //assign the data to the property
            AllFlights.ThisFlight = TestFlights;
            //test to see that the two values are the same
            Assert.AreEqual(AllFlights.ThisFlight, TestFlights);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsFlightCollection AllFlights = new clsFlightCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsFlights> TestList = new List<clsFlights>();
            //add an item to the list
            //create the item of test data
            clsFlights TestItem = new clsFlights();
            //set its properties
            TestItem.Flight_No = 1;
            TestItem.Airline = "Air India";
            TestItem.ArrivalAirport = "BHX";
            TestItem.Arrival = DateTime.Now.Date;
            TestItem.Departure = DateTime.Now.Date;
            TestItem.DepartureAirport = "BHX";
            TestItem.Destination = "India";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllFlights.FlightList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllFlights.Count, TestList.Count);

        }




    }
}

       
    

