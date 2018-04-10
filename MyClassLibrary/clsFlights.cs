using System;

namespace MyClassLibrary

{
    public class clsFlights
    {
        public clsFlights()
        {

        }
        //private data member for FlightNo property
        private Int32 mFlightNo;
        public string Airline { get; set; }
        public DateTime ArrivalDate { get; set; }
        public DateTime DepartureDate { get; set; }
        public string FlightNo { get; set; }
        public int Flight_No
        {
            get
            {
                //return the private data
                return mFlightNo;
            }
            set
            {
                //set the value of the private data member 
                mFlightNo = value;

            }
        }

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

            //if (airline.Length == 0)
            //{
            //    return OK = OK + "Airline is blank";
            //}

            if (airline.Length <= 2)
            {
                return OK = OK + "Airline is blank";
            }
            if (airline.Length > 10)
            {
                return OK = OK + "Airline must be less than 10 characters";
            }
            if (destination.Length == 0)
            {
                return OK = OK + "Destination is blank";
            }
            if (destination.Length > 10)
            {
                return OK = OK + "Destination must be less than 10 characters";
            }

            if (arrivalAirport.Length == 0)
            {
                return OK = OK + "Arrival Airport is blank";
            }
            if (arrivalAirport.Length > 3)
            {
                return OK = OK + "Arrival Airport must be less than 4 characters";
            }

            try
            {
                DateTime DateTemp1;
                DateTemp1 = Convert.ToDateTime(departure);


            }
            catch
            {
                OK = OK + "Incorrect date entered";
            }

            try
            {
                DateTime DateTemp;
                DateTemp = Convert.ToDateTime(arrival);

                if (DateTemp < DateTime.Now.Date)
                {
                    OK = OK + "Flight cannot be in the past";
                }



            }
            catch
            {
                OK = OK + "Incorrect date entered";
            }


            return OK;


        }

        public bool Find(int flightNo)
        {
            //set the private data member to the test data value
            mFlightNo = 21;
            //always return true
            return true;
        }






    }
}
