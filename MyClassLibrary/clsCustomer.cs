using System;

namespace MyClassLibrary
{
    public class clsCustomer
    {

        public clsCustomer()
        {
        }

        public string Date { get; set; }
        public string PostCode { get; set; }

        public bool Valid(string postCode, string date)
        {
            DateTime DateTemp;
            Boolean OK = false;
            if (postCode.Length < 20)
            {
                OK = false;
            }
            else
            {
                OK = true;
            }
            DateTemp = Convert.ToDateTime(date);
            if (DateTemp > DateTime.Now.Date)
            {

                OK = false;
            }
            return OK;
        }
    }
}