using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;

namespace MyTesting
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Assert.IsNotNull(AnCustomer);
        }
        [TestMethod]
        public void PostCodeExist()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string PostCode = "LE5";
            AnCustomer.PostCode = PostCode;
            Assert.AreEqual(AnCustomer.PostCode, PostCode);

        }

        [TestMethod]
        public void DateExist()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Date = Convert.ToString(DateTime.Now.Date);
            AnCustomer.Date = Date;
            Assert.AreEqual(AnCustomer.Date, Date);

        }
        [TestMethod]
        public void ValidExist()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean AllOK = false;
            string PostCode = "LE5";
            string date = Convert.ToString(DateTime.Now.Date);

            AllOK = AnCustomer.Valid(PostCode, date);
            Assert.IsTrue(AllOK);

        }
        [TestMethod]
        public void DateBoundary()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Error = true;
            string PostCode = "LE5";
            string Date = Convert.ToString(DateTime.Now.Date);
            Error = AnCustomer.Valid(PostCode, Date);
            Assert.IsTrue(Error, "");
        }
        [TestMethod]
        public void DateMin()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Error = true;
            string PostCode = "LE5";
            DateTime Date = DateTime.Now.Date;
            Date.AddYears(-1000);
            string DateT = Date.ToString();

            Error = AnCustomer.Valid(PostCode, DateT);
            Assert.IsTrue(Error, "");
        }
        [TestMethod]
        public void DateMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Error = true;
            string PostCode = "LE5";
            DateTime Date = DateTime.Now.Date;
            Date.AddYears(+1000);
            string DateT = Date.ToString();

            Error = AnCustomer.Valid(PostCode, DateT);
            Assert.IsTrue(Error, "");
            //////////////////////////////postcode////////////////////
        }
        [TestMethod]
        public void PostcodeBoundary()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Error = true;
            string PostCode = "LE5";
            string Date = Convert.ToString(DateTime.Now.Date);
            Error = AnCustomer.Valid(PostCode, Date);
            Assert.IsTrue(Error, "");
        }
        [TestMethod]
        public void PostcodeMin()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Error = true;
            string PostCode = "LE5";
            DateTime Date = DateTime.Now.Date;
            Date.AddYears(-1000);
            string DateT = Date.ToString();

            Error = AnCustomer.Valid(PostCode, DateT);
            Assert.IsTrue(Error, "");
        }
        [TestMethod]
        public void PostcodeMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Error = true;
            string PostCode = "LE5";
            DateTime Date = DateTime.Now.Date;
            Date.AddYears(+1000);
            string DateT = Date.ToString();

            Error = AnCustomer.Valid(PostCode, DateT);
            Assert.IsTrue(Error, "");
        }
        [TestMethod]
        public void Surname()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Error = true;
            string Surname = "Dean";
            DateTime Date = DateTime.Now.Date;
            Date.AddYears(+1000);
            string DateT = Date.ToString();

            Error = AnCustomer.Valid(Surname, DateT);
            Assert.IsTrue(Error, "");
        }
        [TestMethod]
        public void SurnameMin()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Error = true;
            string Surname = "Dean";
            DateTime Date = DateTime.Now.Date;
            Date.AddYears(+1000);
            string DateT = Date.ToString();

            Error = AnCustomer.Valid(Surname, DateT);
            Assert.IsTrue(Error, "");
        }
        [TestMethod]
        public void SurnameMinPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Error = true;
            string Surname = "Dean";
            DateTime Date = DateTime.Now.Date;
            Date.AddYears(+1000);
            string DateT = Date.ToString();

            Error = AnCustomer.Valid(Surname, DateT);
            Assert.IsTrue(Error, "");
        }
        [TestMethod]
        public void SurnameMaxMinusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Error = true;
            string Surname = "Dean";
            DateTime Date = DateTime.Now.Date;
            Date.AddYears(+1000);
            string DateT = Date.ToString();

            Error = AnCustomer.Valid(Surname, DateT);
            Assert.IsTrue(Error, "");
        }
        [TestMethod]
        public void SurnameMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Error = true;
            string Surname = "Dean";
            DateTime Date = DateTime.Now.Date;
            Date.AddYears(+1000);
            string DateT = Date.ToString();

            Error = AnCustomer.Valid(Surname, DateT);
            Assert.IsTrue(Error, "");
        }
        [TestMethod]
        public void SurnameMaxPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Error = true;
            string Surname = "Dean";
            DateTime Date = DateTime.Now.Date;
            Date.AddYears(+1000);
            string DateT = Date.ToString();

            Error = AnCustomer.Valid(Surname, DateT);
            Assert.IsTrue(Error, "");
        }
        [TestMethod]
        public void SurnameMid()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Error = true;
            string Surname = "Dean";
            DateTime Date = DateTime.Now.Date;
            Date.AddYears(+1000);
            string DateT = Date.ToString();

            Error = AnCustomer.Valid(Surname, DateT);
            Assert.IsTrue(Error, "");
        }
        [TestMethod]
        public void SurnameExtremeMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Error = true;
            string Surname = "Dean";
            DateTime Date = DateTime.Now.Date;
            Date.AddYears(+1000);
            string DateT = Date.ToString();

            Error = AnCustomer.Valid(Surname, DateT);
            Assert.IsTrue(Error, "");

        }
        [TestMethod]
        public void HouseNo()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Error = true;
            Int32 HouseNo = 40;
            DateTime Date = DateTime.Now.Date;
            Date.AddYears(+1000);
            string DateT = Date.ToString();

            Error = AnCustomer.Valid(HouseNo.ToString(), DateT);
            Assert.IsTrue(Error, "");
        }
        [TestMethod]
        public void Gender()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Error = true;
            Boolean Gender = true;
            DateTime Date = DateTime.Now.Date;
            Date.AddYears(+1000);
            string DateT = Date.ToString();

            Error = AnCustomer.Valid(Gender.ToString(), DateT);
            Assert.IsTrue(Error, "");
        }
        [TestMethod]
        public void Forename()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Error = true;
            string Forename = "Dean";
            DateTime Date = DateTime.Now.Date;
            Date.AddYears(+1000);
            string DateT = Date.ToString();

            Error = AnCustomer.Valid(Forename, DateT);
            Assert.IsTrue(Error, "");
        }
        [TestMethod]
        public void ForenameMin()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Error = true;
            string Forename = "Dean";
            DateTime Date = DateTime.Now.Date;
            Date.AddYears(+1000);
            string DateT = Date.ToString();

            Error = AnCustomer.Valid(Forename, DateT);
            Assert.IsTrue(Error, "");
        }
        [TestMethod]
        public void ForenameMinPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Error = true;
            string Forename = "Dean";
            DateTime Date = DateTime.Now.Date;
            Date.AddYears(+1000);
            string DateT = Date.ToString();

            Error = AnCustomer.Valid(Forename, DateT);
            Assert.IsTrue(Error, "");
        }
        [TestMethod]
        public void ForenameMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Error = true;
            string Forename = "Dean";
            DateTime Date = DateTime.Now.Date;
            Date.AddYears(+1000);
            string DateT = Date.ToString();

            Error = AnCustomer.Valid(Forename, DateT);
            Assert.IsTrue(Error, "");
        }
        [TestMethod]
        public void ForenameMaxPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Error = true;
            string Forename = "Dean";
            DateTime Date = DateTime.Now.Date;
            Date.AddYears(+1000);
            string DateT = Date.ToString();

            Error = AnCustomer.Valid(Forename, DateT);
            Assert.IsTrue(Error, "");
        }
        [TestMethod]
        public void ForenameMid()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Error = true;
            string Forename = "Dean";
            DateTime Date = DateTime.Now.Date;
            Date.AddYears(+1000);
            string DateT = Date.ToString();

            Error = AnCustomer.Valid(Forename, DateT);
            Assert.IsTrue(Error, "");
        }
        [TestMethod]
        public void ForenameExtremeMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Error = true;
            string Forename = "Dean";
            DateTime Date = DateTime.Now.Date;
            Date.AddYears(+1000);
            string DateT = Date.ToString();

            Error = AnCustomer.Valid(Forename, DateT);
            Assert.IsTrue(Error, "");
        }
        [TestMethod]
        public void FlatNo()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Error = true;
            string FlatNo = "Dean";
            DateTime Date = DateTime.Now.Date;
            Date.AddYears(+1000);
            string DateT = Date.ToString();

            Error = AnCustomer.Valid(FlatNo, DateT);
            Assert.IsTrue(Error, "");
        }
        [TestMethod]
        public void Email()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Error = true;
            string Email = "Dean";
            DateTime Date = DateTime.Now.Date;
            Date.AddYears(+1000);
            string DateT = Date.ToString();

            Error = AnCustomer.Valid(Email, DateT);
            Assert.IsTrue(Error, "");

        }
        [TestMethod]
        public void CustomerID()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Error = true;
            string CustomerID = "Dean";
            DateTime Date = DateTime.Now.Date;
            Date.AddYears(+1000);
            string DateT = Date.ToString();

            Error = AnCustomer.Valid(CustomerID, DateT);
            Assert.IsTrue(Error, "");
        }
        [TestMethod]
        public void ContactNo()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Error = true;
            Int32 ContactNo = 40;
            DateTime Date = DateTime.Now.Date;
            Date.AddYears(+1000);
            string DateT = Date.ToString();

            Error = AnCustomer.Valid(ContactNo.ToString(), DateT);
            Assert.IsTrue(Error, "");
        }
        [TestMethod]
        public void Active()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Error = true;
            Boolean Active = true;
            DateTime Date = DateTime.Now.Date;
            Date.AddYears(+1000);
            string DateT = Date.ToString();

            Error = AnCustomer.Valid(Active.ToString(), DateT);
            Assert.IsTrue(Error, "");
        }
    }
}