using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;

namespace Test_Framework
{
    [TestClass]
    public class tstFlights
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create instance of class we want to create
            clsFlights AnFlight = new clsFlights();
            //test to see that it exists
            Assert.IsNotNull(AnFlight);
        }

        [TestMethod]
        public void
        //tesr
    }
}

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
            string FlightNo = "AI111";
            string Airline = "AirIndiaaa";
            string ArrivalAirport = "BHX";
            string Arrival = DateTime.Now.Date.ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "Birmingham Airport";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists 
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void FlightNoMinMinus1()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "";
            string Airline = "Air India";
            string ArrivalAirport = "Dubai Airport";
            string Arrival = DateTime.Now.Date.ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "Birmingham Airport";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreNotEqual(OK, "");
        }

        [TestMethod]
        public void FlightNoBoundaryMin()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "AAAAA";
            string Airline = "AirIndiaaa";
            string ArrivalAirport = "BHX";
            string Arrival = DateTime.Now.Date.ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "Birmingham Airport";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void FlightNoMinPlus1()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "AAAAAA";
            string Airline = "Air India";
            string ArrivalAirport = "Dubai Airport";
            string Arrival = DateTime.Now.Date.ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "Birmingham Airport";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreNotEqual(OK, "");
        }

        [TestMethod]
        public void FlightNoMaxMinus1()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "AAAA";
            string Airline = "Air India";
            string ArrivalAirport = "Dubai Airport";
            string Arrival = DateTime.Now.Date.ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "Birmingham Airport";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreNotEqual(OK, "");
        }

        [TestMethod]
        public void FlightNoBoundaryMax()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "AAAAA";
            string Airline = "Air India";
            string ArrivalAirport = "BHX";
            string Arrival = DateTime.Now.Date.ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "Birmingham Airport";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void FlightNoMaxPlus1()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "AAaaaa";
            string Airline = "Air India";
            string ArrivalAirport = "Dubai Airport";
            string Arrival = DateTime.Now.Date.ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "Birmingham Airport";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreNotEqual(OK, "");
        }

        [TestMethod]
        public void FlightNoMid()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "AA";
            string Airline = "Air India";
            string ArrivalAirport = "Dubai Airport";
            string Arrival = DateTime.Now.Date.ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "Birmingham Airport";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreNotEqual(OK, "");
        }

        [TestMethod]
        public void FlightNoExtermeMax()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "";
            FlightNo = FlightNo.PadRight(20, 'a');
            string Airline = "Air India";
            string ArrivalAirport = "Dubai Airport";
            string Arrival = DateTime.Now.Date.ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "Birmingham Airport";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreNotEqual(OK, "");
        }

        [TestMethod]
        public void AirlineMinMinus1()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "AAAAA";
            string Airline = "";
            string ArrivalAirport = "Dubai Airport";
            string Arrival = DateTime.Now.Date.ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "Birmingham Airport";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreNotEqual(OK, "");



        }

        [TestMethod]
        public void AirlineBoundaryMin()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "AAAAA";
            string Airline = "bb";
            string ArrivalAirport = "Dubai Airport";
            string Arrival = DateTime.Now.Date.ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "Birmingham Airport";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreNotEqual(OK, "");
        }

        [TestMethod]
        public void AirlineMinPlus1()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "AAAAA";
            string Airline = "sss";
            string ArrivalAirport = "BHX";
            string Arrival = DateTime.Now.Date.ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "Birmingham Airport";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void AirlineMaxMinus1()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "AAAAA";
            string Airline = "";
            Airline = Airline.PadRight(9, 'a');
            string ArrivalAirport = "BHX";
            string Arrival = DateTime.Now.Date.ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "Birmingham Airport";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void AirlineBoundaryMax()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "AAAAA";
            string Airline = "Air India";
            Airline = Airline.PadRight(10, 'a');
            string ArrivalAirport = "DBX";
            string Arrival = DateTime.Now.Date.ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "Birmingham Airport";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void AirlineMaxPlus1()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "AAAAA";
            string Airline = "";
            Airline = Airline.PadRight(11, 'a');
            string ArrivalAirport = "Dubai Airport";
            string Arrival = DateTime.Now.Date.ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "Birmingham Airport";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreNotEqual(OK, "");
        }

        [TestMethod]
        public void AirlineMid()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "AAAAA";
            string Airline = "AAAAA";
            string ArrivalAirport = "BHX";
            string Arrival = DateTime.Now.Date.ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "Birmingham Airport";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void AirlineExtermeMax()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "AAAAA";
            string Airline = "";
            Airline = Airline.PadRight(20, 'a');
            string ArrivalAirport = "Dubai Airport";
            string Arrival = DateTime.Now.Date.ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "Birmingham Airport";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreNotEqual(OK, "");
        }

        [TestMethod]
        public void DestinationMinMinus1()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "AAAAA";
            string Airline = "Air India";
            string ArrivalAirport = "Dubai Airport";
            string Arrival = DateTime.Now.Date.ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "Birmingham Airport";
            string Destination = "A";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreNotEqual(OK, "");

        }

        [TestMethod]
        public void DestinationBoundaryMin()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "AAAAA";
            string Airline = "Air India";
            string ArrivalAirport = "BHX";
            string Arrival = DateTime.Now.Date.ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "Birmingham Airport";
            string Destination = "DG";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void DestinationMinPlus1()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "AAAAA";
            string Airline = "Air India";
            string ArrivalAirport = "BHX";
            string Arrival = DateTime.Now.Date.ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "Birmingham Airport";
            string Destination = "BAL";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void DestinationMaxMinus1()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "AAAAA";
            string Airline = "";
            Airline = Airline.PadRight(9, 'a');
            string ArrivalAirport = "Dubai Airport";
            string Arrival = DateTime.Now.Date.ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "Birmingham Airport";
            string Destination = "Dubaiiiii";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreNotEqual(OK, "");
        }
        [TestMethod]
        public void DestinationMaxBoundary()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "AAAAA";
            string Airline = "";
            Airline = Airline.PadRight(9, 'a');
            string ArrivalAirport = "BHX";
            string Arrival = DateTime.Now.Date.ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "Birmingham Airport";
            string Destination = "Dubaiiiiii";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }
        [TestMethod]
        public void DestinationMaxPlus1()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "AAaaaa";
            string Airline = "Air India";
            string ArrivalAirport = "Dubai Airport";
            string Arrival = DateTime.Now.Date.ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "Birmingham Airport";
            string Destination = "Dubaiiiiiii";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreNotEqual(OK, "");
        }
        [TestMethod]
        public void DestinationMid()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "AAAAA";
            string Airline = "AirIndiaaa";
            string ArrivalAirport = "BHX";
            string Arrival = DateTime.Now.Date.ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "Birmingham Airport";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }
        [TestMethod]
        public void DestinationExtermeMax()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "";
            FlightNo = FlightNo.PadRight(20, 'a');
            string Airline = "Air India";
            string ArrivalAirport = "Dubai Airport";
            string Arrival = DateTime.Now.Date.ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "Birmingham Airport";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreNotEqual(OK, "");
        }

        [TestMethod]
        public void ArrivalMinMinusOne()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "";
            FlightNo = FlightNo.PadRight(5, 'a');
            string Airline = "Air India";
            string ArrivalAirport = "Dubai Airport";
            string Arrival = DateTime.Now.Date.AddYears(-1).ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "Birmingham Airport";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreNotEqual(OK, "");
        }

        [TestMethod]
        public void ArrivalMinBoundary()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "";
            FlightNo = FlightNo.PadRight(5, 'a');
            string Airline = "Air India";
            string ArrivalAirport = "Dubai Airport";
            string Arrival = "";
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "Birmingham Airport";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreNotEqual(OK, "");
        }

        [TestMethod]
        public void ArrivalMinPlusOne()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "";
            FlightNo = FlightNo.PadRight(5, 'a');
            string Airline = "Air India";
            string ArrivalAirport = "BHX";
            string Arrival = DateTime.Now.Date.ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "Birmingham Airport";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void ArrivalMaxMinusOne()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "";
            FlightNo = FlightNo.PadRight(5, 'a');
            string Airline = "Air India";
            string ArrivalAirport = "Dubai Airport";
            string Arrival = DateTime.Now.Date.AddYears(-364).ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "Birmingham Airport";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreNotEqual(OK, "");
        }

        [TestMethod]
        public void ArrivalMaxBoundary()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "";
            FlightNo = FlightNo.PadRight(5, 'a');
            string Airline = "Air India";
            string ArrivalAirport = "BHX";
            string Arrival = DateTime.Now.Date.AddYears(+365).ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "Birmingham Airport";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void ArrivalMaxPlusOne()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "";
            FlightNo = FlightNo.PadRight(5, 'a');
            string Airline = "Air India";
            string ArrivalAirport = "BHX";
            string Arrival = DateTime.Now.Date.AddYears(+366).ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "Birmingham Airport";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void ArrivalMid()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "";
            FlightNo = FlightNo.PadRight(5, 'a');
            string Airline = "Air India";
            string ArrivalAirport = "Dubai Airport";
            string Arrival = "";
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "Birmingham Airport";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreNotEqual(OK, "");
        }

        [TestMethod]
        public void ArrivalExtermeMax()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "";
            FlightNo = FlightNo.PadRight(5, 'a');
            string Airline = "Air India";
            string ArrivalAirport = "BHX";
            string Arrival = DateTime.Now.Date.AddYears(+730).ToString(); ;
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "Birmingham Airport";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void DepartureMinMinusOne()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "";
            FlightNo = FlightNo.PadRight(5, 'a');
            string Airline = "Air India";
            string ArrivalAirport = "Dubai Airport";
            string Arrival = DateTime.Now.Date.AddYears(-1).ToString();
            string Departure = DateTime.Now.Date.AddYears(-1).ToString();
            string DepartureAirport = "Birmingham Airport";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreNotEqual(OK, "");
        }

        [TestMethod]
        public void DepartureMinBoundary()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "";
            FlightNo = FlightNo.PadRight(5, 'a');
            string Airline = "Air India";
            string ArrivalAirport = "Dubai Airport";
            string Arrival = "";
            string Departure = "";
            string DepartureAirport = "Birmingham Airport";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreNotEqual(OK, "");
        }

        [TestMethod]
        public void DepartureMinPlusOne()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "";
            FlightNo = FlightNo.PadRight(5, 'a');
            string Airline = "Air India";
            string ArrivalAirport = "BHX";
            string Arrival = DateTime.Now.Date.ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "Birmingham Airport";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void DepartureMaxMinusOne()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "";
            FlightNo = FlightNo.PadRight(5, 'a');
            string Airline = "Air India";
            string ArrivalAirport = "Dubai Airport";
            string Arrival = DateTime.Now.Date.AddYears(-364).ToString();
            string Departure = DateTime.Now.Date.AddYears(-364).ToString();
            string DepartureAirport = "Birmingham Airport";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreNotEqual(OK, "");
        }

        [TestMethod]
        public void DepartureMaxBoundary()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "";
            FlightNo = FlightNo.PadRight(5, 'a');
            string Airline = "Air India";
            string ArrivalAirport = "BHX";
            string Arrival = DateTime.Now.Date.AddYears(+365).ToString();
            string Departure = DateTime.Now.Date.AddYears(+365).ToString();
            string DepartureAirport = "Birmingham Airport";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void DepartureMaxPlusOne()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "";
            FlightNo = FlightNo.PadRight(5, 'a');
            string Airline = "Air India";
            string ArrivalAirport = "BHX";
            string Arrival = DateTime.Now.Date.AddYears(+366).ToString();
            string Departure = DateTime.Now.Date.AddYears(+366).ToString();
            string DepartureAirport = "Birmingham Airport";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void DepartureMid()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "";
            FlightNo = FlightNo.PadRight(5, 'a');
            string Airline = "Air India";
            string ArrivalAirport = "Dubai Airport";
            string Arrival = "";
            string Departure = "";
            string DepartureAirport = "Birmingham Airport";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreNotEqual(OK, "");
        }

        [TestMethod]
        public void DepartureExtermeMax()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "";
            FlightNo = FlightNo.PadRight(5, 'a');
            string Airline = "Air India";
            string ArrivalAirport = "BHX";
            string Arrival = DateTime.Now.Date.AddYears(+730).ToString();
            string Departure = DateTime.Now.Date.AddYears(+730).ToString();
            string DepartureAirport = "Birmingham Airport";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void ArrivalAirportMinBoundary()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "AAAAA";
            string Airline = "Air India";
            Airline = Airline.PadRight(10, 'a');
            string ArrivalAirport = "A";
            string Arrival = DateTime.Now.Date.ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "Birmingham Airport";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void ArrivalAirportMinPlusOne()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "AAAAA";
            string Airline = "Air India";
            Airline = Airline.PadRight(10, 'a');
            string ArrivalAirport = "AA";
            string Arrival = DateTime.Now.Date.ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "Birmingham Airport";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void ArrivalAirportMaxMinusOne()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "AAAAA";
            string Airline = "Air India";
            Airline = Airline.PadRight(10, 'a');
            string ArrivalAirport = "AA";
            string Arrival = DateTime.Now.Date.ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "Birmingham Airport";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void ArrivalAirportMaxBoundary()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "AAAAA";
            string Airline = "Air India";
            Airline = Airline.PadRight(10, 'a');
            string ArrivalAirport = "AAA";
            string Arrival = DateTime.Now.Date.ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "Birmingham Airport";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void ArrivalAirportMaxPlusOne()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "AAAAA";
            string Airline = "Air India";
            Airline = Airline.PadRight(10, 'a');
            string ArrivalAirport = "AAAA";
            string Arrival = DateTime.Now.Date.ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "Birmingham Airport";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreNotEqual(OK, "");
        }

        [TestMethod]
        public void ArrivalAirportMid()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "AAAAA";
            string Airline = "Air India";
            Airline = Airline.PadRight(10, 'a');
            string ArrivalAirport = "AA";
            string Arrival = DateTime.Now.Date.ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "Birmingham Airport";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void ArrivalAirportExtermeMax()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "AAAAA";
            string Airline = "Air India";
            Airline = Airline.PadRight(10, 'a');
            string ArrivalAirport = "AAAAA";
            string Arrival = DateTime.Now.Date.ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "Birmingham Airport";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreNotEqual(OK, "");
        }

        [TestMethod]
        public void DepartureAirportMinBoundary()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "AAAAA";
            string Airline = "Air India";
            Airline = Airline.PadRight(10, 'a');
            string ArrivalAirport = "A";
            string Arrival = DateTime.Now.Date.ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "A";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void DepartureAirportMinPlusOne()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "AAAAA";
            string Airline = "Air India";
            Airline = Airline.PadRight(10, 'a');
            string ArrivalAirport = "AA";
            string Arrival = DateTime.Now.Date.ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "AA";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void DepartureAirportMaxMinusOne()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "AAAAA";
            string Airline = "Air India";
            Airline = Airline.PadRight(10, 'a');
            string ArrivalAirport = "AA";
            string Arrival = DateTime.Now.Date.ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "AA";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void DepartureAirportMaxBoundary()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "AAAAA";
            string Airline = "Air India";
            Airline = Airline.PadRight(10, 'a');
            string ArrivalAirport = "AAA";
            string Arrival = DateTime.Now.Date.ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "AAA";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void DepartureAirportMaxPlusOne()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "AAAAA";
            string Airline = "Air India";
            Airline = Airline.PadRight(10, 'a');
            string ArrivalAirport = "AAAA";
            string Arrival = DateTime.Now.Date.ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "AAAA";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreNotEqual(OK, "");
        }

        [TestMethod]
        public void DepartureAirportMid()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "AAAAA";
            string Airline = "Air India";
            Airline = Airline.PadRight(10, 'a');
            string ArrivalAirport = "AA";
            string Arrival = DateTime.Now.Date.ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "aa";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void DepartureAirportExtermeMax()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "AAAAA";
            string Airline = "Air India";
            Airline = Airline.PadRight(10, 'a');
            string ArrivalAirport = "AAAAA";
            string Arrival = DateTime.Now.Date.ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "AAAAA";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreNotEqual(OK, "");
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsFlights AnFlight = new clsFlights();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 Flight_No = 1;
            //invoke the method
            Found = AnFlight.Find(Flight_No);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestFlightNoFound()
        {
            //create an instance of the class we want to create
            clsFlights AnFlight = new clsFlights();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 FlightNo = 21;
            //invoke the method
            Found = AnFlight.Find(FlightNo);
            //check the flight no
            if (AnFlight.Flight_No != 21)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}