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
            TestItem.FlightID = 1;
            TestItem.FlightNo = "A114";
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
            TestFlights.FlightID = 1;
            TestFlights.FlightNo = "A114";
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
            TestItem.FlightID = 1;
            TestItem.FlightNo = "A114";
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

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsFlightCollection AllFlights = new clsFlightCollection();
            //create the item of test data
            clsFlights TestFlights = new clsFlights();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            //set its properties
            //TestFlights.FlightID = 1;
            TestFlights.FlightNo = "AA11";
            TestFlights.Airline = "Air India";
            TestFlights.ArrivalAirport = "DXB";
            TestFlights.Arrival = DateTime.Now.Date;
            TestFlights.Departure = DateTime.Now.Date;
            TestFlights.DepartureAirport = "MCR";
            TestFlights.Destination = "Dubai";
            //set ThisFlights to the test data
            AllFlights.ThisFlight = TestFlights;
            //add the record
            PrimaryKey = AllFlights.Add();
            //set the primary key of the test data
            TestFlights.FlightID = PrimaryKey;
            //find the record
            AllFlights.ThisFlight.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllFlights.ThisFlight, TestFlights);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsFlightCollection AllFlights = new clsFlightCollection();
            //create the item of test data
            clsFlights TestItem = new clsFlights();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.FlightNo = "AA11";
            TestItem.Airline = "Air India";
            TestItem.ArrivalAirport = "DXB";
            TestItem.Arrival = DateTime.Now.Date;
            TestItem.Departure = DateTime.Now.Date;
            TestItem.DepartureAirport = "MCR";
            TestItem.Destination = "Dubai";
            //set ThisFlights to the test data
            AllFlights.ThisFlight = TestItem;
            //add the record
            PrimaryKey = AllFlights.Add();
            //set the primary key of the test data
            TestItem.FlightID = PrimaryKey;
            //find the record
            AllFlights.ThisFlight.Find(PrimaryKey);
            //delete the record
            AllFlights.Delete();
            //now find the record
            Boolean Found = AllFlights.ThisFlight.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsFlightCollection AllFlights = new clsFlightCollection();
            //create the item of test data
            clsFlights TestItem = new clsFlights();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.FlightNo = "AA11";
            TestItem.Airline = "Air India";
            TestItem.ArrivalAirport = "DXB";
            TestItem.Arrival = DateTime.Now.Date;
            TestItem.Departure = DateTime.Now.Date;
            TestItem.DepartureAirport = "MCR";
            TestItem.Destination = "Dubai";
            //set ThisFlights to the test data
            AllFlights.ThisFlight = TestItem;
            //add the record
            PrimaryKey = AllFlights.Add();
            //set the primary key of the test data
            TestItem.FlightID = PrimaryKey;
            //modify the test data
            TestItem.FlightNo = "AA30";
            TestItem.Airline = "Air France";
            TestItem.ArrivalAirport = "LHR";
            TestItem.Arrival = DateTime.Now.Date;
            TestItem.Departure = DateTime.Now.Date;
            TestItem.DepartureAirport = "DHL";
            TestItem.Destination = "Germany";
            //set the record based on the new test data
            AllFlights.ThisFlight = TestItem;
            //update the record
            AllFlights.Update();
            //find the record
            AllFlights.ThisFlight.Find(PrimaryKey);
            //test to see ThisFlights matches the test data
            Assert.AreEqual(AllFlights.ThisFlight, TestItem);
        }

        [TestMethod]
        public void FilterByDestinationMethodOK()
        {
            //create an instance of the class containing unfiltred results
            clsFlightCollection AllFlights = new clsFlightCollection();
            //create an instance of the filtered data
            clsFlightCollection FilteredFlights = new clsFlightCollection();
            //apply a blank string (should return all records);
            FilteredFlights.FilterByDestination("");
            //test to see that the two values are the same
            Assert.AreEqual(AllFlights.Count, FilteredFlights.Count);

        }

        [TestMethod]
        public void FilterByDestinationNoneFound()
        {
            //create an instance of the filtered data
            clsFlightCollection FilteredFlights = new clsFlightCollection();
            //apply a airline that doesn't exist
            FilteredFlights.FilterByDestination("@@@");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredFlights.Count);

        }

        [TestMethod]
        public void FilterByDestinationTestDataFound()
        {
            //create an instance of the filtered data
            clsFlightCollection FilteredFlights = new clsFlightCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a destination that doesn't exist
            FilteredFlights.FilterByDestination("XXXXX");
            //check that the correct number of records are found
            if (FilteredFlights.Count == 2)
            {
                //check that the first record is ID 36
                if (FilteredFlights.FlightList[0].FlightID != 30)
                {
                    OK = false;
                }
                //check that the first record is ID 37
                if (FilteredFlights.FlightList[1].FlightID != 31)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no records
            Assert.IsTrue(OK);
        }





    }
}

