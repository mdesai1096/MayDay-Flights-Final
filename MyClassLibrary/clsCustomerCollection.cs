using System.Collections.Generic;
using MyClassLibrary;

namespace Class_Library
{
    public class clsCustomerCollection
    {

        private List<clsCustomer> mCustomerList = new List<clsCustomer>();
        //private member thisCustomer
        private clsCustomer mThisCustomer = new clsCustomer();



        //public property for the Customer list
        public List<clsCustomer> CustomerList
        {
            get
            {
                //return the private data
                return mCustomerList;
            }
            set
            {
                //set the private data
                mCustomerList = value;
            }
        }

        //public propery for count
        public int Count
        {
            get
            {
                //return the count of the list
                return mCustomerList.Count;
            }
            set
            {
                //later
            }
        }

                    public clsCustomer ThisCustomer
        {
            get
            {
                //return the private data
                return mThisCustomer;
            }
            set
            {
                //set the private data
                mThisCustomer = value;
            }
        }


    }
}
