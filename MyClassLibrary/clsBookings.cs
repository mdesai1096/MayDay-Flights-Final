using System;

namespace MyClassLibrary
{
    public class clsBookings
    {
        public clsBookings()
        {
        }

        public decimal Ammount { get; set; }
        public DateTime DateBooked { get; set; }
        public string PaymentType { get; set; }

        public string Valid(string ammount, string paymentType, string dateBooked)
        {
            //temp variable to store date
            DateTime DateTemp;
            //string variable to store any error messages found
            string OK = "";
            //If Payment type is blank
            if (paymentType.Length == 0)
            {
                //Flag an error
                OK = OK + "Payment Blank: Charecter limit 10";
            }

            //If Payment type is blank
            if (paymentType.Length > 10)
            {
                //Flag an error
                OK = OK + "Payment Blank: Charecter limit 10";
            }

            try //try to see if the ammount entered is valid
            {
                //var to store ammount
                decimal Price;
                //assign the ammount a tempory variable
                Price = Convert.ToDecimal(ammount);
                //if the price is greater then 0 but less then 30,0000
                if (Price < 0 | Price > 30000 )
                {
                    //set the error message
                    OK = OK + "Ammount must be between £0 and £30,000";
                }
            }
            catch // if an error has failed to be caught
            {
                //flag an error
                OK = OK + "Incorrect charecters entered";
            }

            try //try to see if the date entered is valid
            {
                //tempory variable to store the date
                DateTemp = Convert.ToDateTime(dateBooked);
                //if the datetemp is greater then todays date
                if (DateTemp < DateTime.Now.Date)
                {
                    //flag an error
                    OK = OK + "Date in past. Please enter todays date";
                }

                //if the datetemp is less then todays date
                if (DateTemp > DateTime.Now.Date)
                {
                    //flag an error
                    OK = OK + "Date in past. Please enter todays date";
                }

            }
            catch // if an error has failed to be caught
            {
                //flag an error
                OK = OK + "Incorrect charecters entered";
            }

            //return any errors found
            return OK;
        }
    }
}