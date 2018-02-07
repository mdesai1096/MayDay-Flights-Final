using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;

namespace MyTesting
{
    [TestClass]
    public class tstBookings
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create a new instance of the class we want to create
            clsBookings ABookings = new clsBookings();
            //test to see if it exists
            Assert.IsNotNull(ABookings);
        }

        [TestMethod]
        public void DateBookedOK()
        {
            //create a new instance of the class we want to create
            clsBookings ABookings = new clsBookings();
            //create some test data
            DateTime DateBooked = DateTime.Now.Date;
            ABookings.DateBooked = DateBooked;          
           //test to see if it exists
            Assert.AreEqual(ABookings.DateBooked, DateBooked);
        }

        [TestMethod]
        public void PaymentOK()
        {
            //create a new instance of the class we want to create
            clsBookings ABookings = new clsBookings();
            //create some test data
            string PaymentType = "Credi";
            ABookings.PaymentType = PaymentType;
            //test to see if it exists
            Assert.AreEqual(ABookings.PaymentType, PaymentType);
        }

        [TestMethod]
        public void AmmountOK()
        {
            //create a new instance of the class we want to create
            clsBookings ABookings = new clsBookings();
            //create some test data
            decimal Ammount = Convert.ToDecimal("23.50") ;
            ABookings.Ammount = Ammount;
            //test to see if it exists
            Assert.AreEqual(ABookings.Ammount, Ammount);
        }

        [TestMethod]
        public void ValidExist()
        {
            //create a new instance of the class we want to create
            clsBookings ABookings = new clsBookings();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string PaymentType = "LE";
            string Ammount = "23.50";
            string DateBooked = DateTime.Now.Date.ToString();
            //invoke method
            OK = ABookings.Valid(Ammount, PaymentType, DateBooked);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        /// Payment Type testing ///

        [TestMethod]
        public void BookingsPaymentMinMinus1()
        {
            //create an instance of new class we want to create
            clsBookings ABookings = new clsBookings();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string PaymentType = "";
            string Ammount = "23.50";
            string DateBooked = DateTime.Now.Date.ToString();
            //invoke method
            OK = ABookings.Valid(Ammount, PaymentType, DateBooked);
            //test to see if result correct
            Assert.AreNotEqual(OK, "");
        }

        [TestMethod]
        public void BookingsPaymentBoundryMin()
        {
            //create an instance of new class we want to create
            clsBookings ABookings = new clsBookings();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string PaymentType = "a";
            string Ammount = "23.50";
            string DateBooked = DateTime.Now.Date.ToString();
            //invoke method
            OK = ABookings.Valid(Ammount, PaymentType, DateBooked);
            //test to see if result correct
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void BookingsPaymentMinPlus1()
        {
            //create an instance of new class we want to create
            clsBookings ABookings = new clsBookings();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string PaymentType = "aa";
            string Ammount = "23.50";
            string DateBooked = DateTime.Now.Date.ToString();
            //invoke method
            OK = ABookings.Valid(Ammount, PaymentType, DateBooked);
            //test to see if result correct
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void BookingsPaymentMaxMinus1()
        {
            //create an instance of new class we want to create
            clsBookings ABookings = new clsBookings();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string PaymentType = "";
            PaymentType = PaymentType.PadRight(9, 'a');
            string Ammount = "23.50";
            string DateBooked = DateTime.Now.Date.ToString();
            //invoke method
            OK = ABookings.Valid(Ammount, PaymentType, DateBooked);
            //test to see if result correct
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void BookingsPaymentBoundryMax()
        {
            //create an instance of new class we want to create
            clsBookings ABookings = new clsBookings();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string PaymentType = "";
            PaymentType = PaymentType.PadRight(10, 'a');
            string Ammount = "23.50";
            string DateBooked = DateTime.Now.Date.ToString();
            //invoke method
            OK = ABookings.Valid(Ammount, PaymentType, DateBooked);
            //test to see if result correct
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void BookingsPaymentMaxPlus1()
        {
            //create an instance of new class we want to create
            clsBookings ABookings = new clsBookings();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string PaymentType = "";
            PaymentType = PaymentType.PadRight(11, 'a');
            string Ammount = "23.50";
            string DateBooked = DateTime.Now.Date.ToString();
            //invoke method
            OK = ABookings.Valid(Ammount, PaymentType, DateBooked);
            //test to see if result correct
            Assert.AreNotEqual(OK, "");
        }

        [TestMethod]
        public void BookingsPaymentMid()
        {
            //create an instance of new class we want to create
            clsBookings ABookings = new clsBookings();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string PaymentType = "";
            PaymentType = PaymentType.PadRight(5, 'a');
            string Ammount = "23.50";
            string DateBooked = DateTime.Now.Date.ToString();
            //invoke method
            OK = ABookings.Valid(Ammount, PaymentType, DateBooked);
            //test to see if result correct
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void BookingsPaymentExtremeMax()
        {
            //create an instance of new class we want to create
            clsBookings ABookings = new clsBookings();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string PaymentType = "";
            PaymentType = PaymentType.PadRight(100, 'a');
            string Ammount = "23.50";
            string DateBooked = DateTime.Now.Date.ToString();
            //invoke method
            OK = ABookings.Valid(Ammount, PaymentType, DateBooked);
            //test to see if result correct
            Assert.AreNotEqual(OK, "");
        }

        /// DateBooked testing ///

        [TestMethod]
        public void BookingsDateBookedExtremeMin()
        {
            //create an instance of new class we want to create
            clsBookings ABookings = new clsBookings();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string PaymentType = "12345";
            string Ammount = "23.50";
            //vaiable to store test date data
            DateTime SomeDate;
            //set test date as todays daye
            SomeDate = DateTime.Now.Date;
            //change to date the whatever date is 100 years in the future
            SomeDate = SomeDate.AddYears(-100);
            //Convert data  to a string variable
            string DateBooked = SomeDate.ToString();
            //invoke the method
            OK = ABookings.Valid(Ammount, PaymentType, DateBooked);
            //test to see if result correct
            Assert.AreNotEqual(OK, "");
        }


        [TestMethod]
        public void BookingsDateBookedBoundryMinandMax()
        {
            //create an instance of new class we want to create
            clsBookings ABookings = new clsBookings();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string PaymentType = "12345";
            string Ammount = "23.50";
            //vaiable to store test date data
            DateTime SomeDate;
            //set test date as todays daye
            SomeDate = DateTime.Now.Date;
            //Convert data  to a string variable
            string DateBooked = SomeDate.ToString();
            //invoke the method
            OK = ABookings.Valid(Ammount, PaymentType, DateBooked);
            //test to see if result correct
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void BookingsDateBookedMinandMaxPlus1()
        {
            //create an instance of new class we want to create
            clsBookings ABookings = new clsBookings();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string PaymentType = "12345";
            string Ammount = "23.50";
            //vaiable to store test date data
            DateTime SomeDate;
            //set test date as todays daye
            SomeDate = DateTime.Now.Date;
            //change to date the whatever date is 100 years in the future
            SomeDate = SomeDate.AddDays(+1);
            //Convert data  to a string variable
            string DateBooked = SomeDate.ToString();
            //invoke the method
            OK = ABookings.Valid(Ammount, PaymentType, DateBooked);
            //test to see if result correct
            Assert.AreNotEqual(OK, "");
        }

        [TestMethod]
        public void BookingsDateBookedMinandMaxMinus1()
        {
            //create an instance of new class we want to create
            clsBookings ABookings = new clsBookings();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string PaymentType = "12345";
            string Ammount = "23.50";
            //vaiable to store test date data
            DateTime SomeDate;
            //set test date as todays daye
            SomeDate = DateTime.Now.Date;
            //change to date the whatever date is 100 years in the future
            SomeDate = SomeDate.AddDays(-1);
            //Convert data  to a string variable
            string DateBooked = SomeDate.ToString();
            //invoke the method
            OK = ABookings.Valid(Ammount, PaymentType, DateBooked);
            //test to see if result correct
            Assert.AreNotEqual(OK, "");
        }


        [TestMethod]
        public void BookingsDateBookedExtremeMax()
        {
            //create an instance of new class we want to create
            clsBookings ABookings = new clsBookings();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string PaymentType = "12345";
            string Ammount = "23.50";
            //vaiable to store test date data
            DateTime SomeDate;
            //set test date as todays daye
            SomeDate = DateTime.Now.Date;
            //change to date the whatever date is 100 years in the future
            SomeDate = SomeDate.AddYears(+100);
            //Convert data  to a string variable
            string DateBooked = SomeDate.ToString();
            //invoke the method
            OK = ABookings.Valid(Ammount, PaymentType, DateBooked);
            //test to see if result correct
            Assert.AreNotEqual(OK, "");
        }

        [TestMethod]
        public void BookingsDateBookedInvalidData()
        {
            //create an instance of new class we want to create
            clsBookings ABookings = new clsBookings();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string PaymentType = "12345";
            string Ammount = "23.50";
            //vaiable to store test date data
            string SomeDate;
            //set test date as todays daye
            SomeDate = "ytytyrtyr";
            string DateBooked = SomeDate.ToString();
            //invoke the method
            OK = ABookings.Valid(Ammount, PaymentType, DateBooked);
            //test to see if result correct
            Assert.AreNotEqual(OK, "");
        }

        //Ammount Testing//
        [TestMethod]
        public void BookingsAmmountExtremeMin()
        {
            //create an instance of new class we want to create
            clsBookings ABookings = new clsBookings();
            //string variable to store the results of the validation
            string OK = "a";
            //create some test data to assign to property
            string PaymentType = "a";
            string Ammount = "-100000";
            string DateBooked = DateTime.Now.Date.ToString();
            //invoke method
            OK = ABookings.Valid(Ammount, PaymentType, DateBooked);
            //test to see if result correct
            Assert.AreNotEqual(OK, "");
        }

        [TestMethod]
        public void BookingsAmmountMinMinus1()
        {
            //create an instance of new class we want to create
            clsBookings ABookings = new clsBookings();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string PaymentType = "a";
            string Ammount = "-1";
            string DateBooked = DateTime.Now.Date.ToString();
            //invoke method
            OK = ABookings.Valid(Ammount, PaymentType, DateBooked);
            //test to see if result correct
            Assert.AreNotEqual(OK, "");
        }

        [TestMethod]
        public void BookingsAmmountBoundryMin()
        {
            //create an instance of new class we want to create
            clsBookings ABookings = new clsBookings();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string PaymentType = "a";
            string Ammount = "0";
            string DateBooked = DateTime.Now.Date.ToString();
            //invoke method
            OK = ABookings.Valid(Ammount, PaymentType, DateBooked);
            //test to see if result correct
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void BookingsAmmountMinPlus1()
        {
            //create an instance of new class we want to create
            clsBookings ABookings = new clsBookings();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string PaymentType = "a";
            string Ammount = "1.50";
            string DateBooked = DateTime.Now.Date.ToString();
            //invoke method
            OK = ABookings.Valid(Ammount, PaymentType, DateBooked);
            //test to see if result correct
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void BookingsAmmountMaxMinus1()
        {
            //create an instance of new class we want to create
            clsBookings ABookings = new clsBookings();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string PaymentType = "a";
            string Ammount = "29999";
            string DateBooked = DateTime.Now.Date.ToString();
            //invoke method
            OK = ABookings.Valid(Ammount, PaymentType, DateBooked);
            //test to see if result correct
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void BookingsAmmountBoundaryMax()
        {
            //create an instance of new class we want to create
            clsBookings ABookings = new clsBookings();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string PaymentType = "a";
            string Ammount = "30000";
            string DateBooked = DateTime.Now.Date.ToString();
            //invoke method
            OK = ABookings.Valid(Ammount, PaymentType, DateBooked);
            //test to see if result correct
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void BookingsAmmountMaxPlus1()
        {
            //create an instance of new class we want to create
            clsBookings ABookings = new clsBookings();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string PaymentType = "a";
            string Ammount = "30001";
            string DateBooked = DateTime.Now.Date.ToString();
            //invoke method
            OK = ABookings.Valid(Ammount, PaymentType, DateBooked);
            //test to see if result correct
            Assert.AreNotEqual(OK, "");
        }

        [TestMethod]
        public void BookingsAmmountMid()
        {
            //create an instance of new class we want to create
            clsBookings ABookings = new clsBookings();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string PaymentType = "a";
            string Ammount = "25000";
            string DateBooked = DateTime.Now.Date.ToString();
            //invoke method
            OK = ABookings.Valid(Ammount, PaymentType, DateBooked);
            //test to see if result correct
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void BookingsAmmountExtremeMax()
        {
            //create an instance of new class we want to create
            clsBookings ABookings = new clsBookings();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string PaymentType = "a";
            string Ammount = "100000";
            string DateBooked = DateTime.Now.Date.ToString();
            //invoke method
            OK = ABookings.Valid(Ammount, PaymentType, DateBooked);
            //test to see if result correct
            Assert.AreNotEqual(OK, "");
        }

        [TestMethod]
        public void BookingsAmmountInvalidData()
        {
            //create an instance of new class we want to create
            clsBookings ABookings = new clsBookings();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string PaymentType = "a";
            string Ammount = "sddfgthjjfghb";
            string DateBooked = DateTime.Now.Date.ToString();
            //invoke method
            OK = ABookings.Valid(Ammount, PaymentType, DateBooked);
            //test to see if result correct
            Assert.AreNotEqual(OK, "");
        }


    }
}
