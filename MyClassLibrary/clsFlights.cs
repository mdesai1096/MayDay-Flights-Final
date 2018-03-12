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

        public string Valid(string flightNo, string airline, string destination, string arrival, string arrivalAirport, string departure, string departureAirport)
        {
            string OK = "";
            if (flightNo.Length == 0)
            {
                return OK = OK + "Flight no is blank";
            }
            if (flightNo.Length != 5)
            {
                return OK = OK + "Flight no must be less than 5 characters";
            }
            //if (flightNo.Length < 1)
            //{
            //return OK = OK + "Flight no must be 5 characters";
            //}
            if (airline.Length == 0)
            {
                return OK = OK + "Airline is blank";
            }
            if (airline.Length > 10)
            {
                return OK = OK + "Airline must be less than 10 characters";
            }
            return OK;
        }
    }
}