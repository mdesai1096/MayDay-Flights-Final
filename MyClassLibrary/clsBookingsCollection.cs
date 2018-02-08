using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyClassLibrary
{
    public class clsBookingsCollection
    {
        //prive data memeber for the list
        List<clsBookings> mBookingsList = new List<clsBookings>();
        //private member thisAddress
        clsBookings mThisBooking = new clsBookings();

        //public property for the booking list
        public List<clsBookings> BookingsList
        {
            get
            {
                //return the private data
                return mBookingsList;
            }
            set
            {
                //set the private data
                mBookingsList = value;
            }
        }

        //public propery for count
        public int Count
        {
            get
            {
                //return the count of the list
                return mBookingsList.Count;
            }
            set
            {
                //later
            }
        }

        public clsBookings ThisBookings
        {
            get
            {
                //return the private data
                return mThisBooking;
            }
            set
            {
                //set the private data
                mThisBooking = value;
            }
        }
    }
}