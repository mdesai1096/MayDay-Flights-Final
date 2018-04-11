using System;

namespace MyClassLibrary

{
    public class clsFlights
    {
        //private data member for the FlightNo property
        private Int32 mFlight_No;
        //private data member for Airline
        private string mAirline;
        //private data member for Destination
        private string mDestination;
        //private data member for Arrival
        private DateTime mArrivalDate;
        //private data member for Departure
        private DateTime mDepartureDate;
        //private data member for Arrival Airport
        private string mArrivalAirport;
        //private data memeber for Departure Airport
        private string mDepartureAirport;


        //public property for FlightNo
        public int Flight_No
        {
            get
            {
                //return the private data
                return mFlight_No;
            }
            set
            {
                //set the value of the private data member 
                mFlight_No = value;

            }
        }
        
        //public property for Arrival Date
        public DateTime Arrival
        {
            get
            {
                //return the private data
                return mArrivalDate;

            }
            set
            {
                //set the private data
                mArrivalDate = value;
            }
        }

        //public property for Departure Date
        public DateTime Departure
        {
            get
            {
                //return the private data
                return mDepartureDate;

            }
            set
            {
                //set the private data
                mDepartureDate = value;
            }
        }
        //public property for Airline 
        public string Airline
        {
            get
            {
                //return the private data
                return mAirline;

            }
            set
            {
                //set the private data
                mAirline = value;
            }
        }
        //public property for Destination 
        public string Destination
        {
            get
            {
                //return the private data
                return mDestination;

            }
            set
            {
                //set the private data
                mDestination = value;
            }
        }








        public string ArrivalAirport { get; set; }
        public string DepartureAirport { get; set; }

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
            mFlight_No = 21;
            mAirline = "Air India";
            mDestination = "India";
            mArrivalDate = Convert.ToDateTime("21/06/2018");
            mDepartureDate = Convert.ToDateTime("21/06/2018");
            mArrivalAirport = "BHX";
            mDepartureAirport = "BHX";
            //always return true
            return true;
        }






    }
}
