using System;

namespace MyClassLibrary
{
    public class clsFlights
    {
        public clsFlights()
        {
        }

        public string Airline { get; set; }
        public DateTime ArrivalDate { get; set; }
        public DateTime DepartureDate { get; set; }
        public string FlightNo { get; set; }

        public string Valid(string arrivalAirport, string arrival, string airline, string departure, string departureAirport, string destination, bool active, string flightno)
        {
            string OK = "";
            return OK;
        }
    }
}