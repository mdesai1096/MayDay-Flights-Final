using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;

namespace MyTesting
{
    [TestClass]
    public class tstFlights
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create a new instance of the class we want to create
            clsFlights AnFlight = new clsFlights();
            //test to see if it exists
            Assert.IsNotNull(AnFlight);
        }

        [TestMethod]
        public void FlightNoOK()
        {
            //create instance of class we want to create
            clsFlights AnFlight = new clsFlights();
            //create some test data to assign to the property
            string TestData = "AI 114";
            //assign the data to the property
            AnFlight.FlightNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnFlight.FlightNo, TestData);
        }

        [TestMethod]
        public void AirlineID()
        {
            //create instance of class we want to create
            clsFlights AnFlight = new clsFlights();
            //create some test data to assign to the property
            string TestData = "Air India";
            //assign the data to the property
            AnFlight.Airline = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnFlight.Airline, TestData);

        }

        [TestMethod]
        public void ArrivalOK()
        {
            //create a new instance of the class we want to create
            clsFlights AFlight = new clsFlights();
            //create some test data
            DateTime ArrivalDate = DateTime.Now.Date;
            AFlight.ArrivalDate = ArrivalDate;
            //test to see if it exists
            Assert.AreEqual(AFlight.ArrivalDate, ArrivalDate);
        }

        [TestMethod]
        public void DepartureOK()
        {
            //create a new instance of the class we want to create
            clsFlights AFlight = new clsFlights();
            //create some test data
            DateTime DepartureDate = DateTime.Now.Date;
            AFlight.DepartureDate = DepartureDate;
            //test to see if it exists
            Assert.AreEqual(AFlight.DepartureDate, DepartureDate);
        }

        [TestMethod]
        public void FlightValidExist()
        {
            //create a new instance of the class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string Airline = "Air India";
            string ArrivalAirport = "Birmingham Airport";
            string Arrival = DateTime.Now.Date.ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "Birmingham Airport";
            string Destination = "Dubai";
            Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(ArrivalAirport, Arrival, Airline, Departure, DepartureAirport, Destination, Active);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }
    }
}
