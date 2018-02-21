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
        //aa
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
            string AllOK = "";
            string PostCode = "LE5";
            string date = Convert.ToString(DateTime.Now.Date);

            AllOK = AnCustomer.Valid(PostCode, date);
            Assert.AreEqual(AllOK, "");
        }
        [TestMethod]
        public void DateBoundary()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string PostCode = "LE5";
            string Date = Convert.ToString(DateTime.Now.Date);

            Error = AnCustomer.Valid(PostCode, Date);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateMinMinusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string PostCode = "Today- 17 years 364 day";
            DateTime Date = DateTime.Now.Date;
            Date.AddYears(-1000);
            string DateT = Date.ToString();

            Error = AnCustomer.Valid(PostCode, DateT);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateMin()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string PostCode = "Today- 18 years";
            DateTime Date = DateTime.Now.Date;
            Date.AddYears(-1000);
            string DateT = Date.ToString();

            Error = AnCustomer.Valid(PostCode, DateT);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateMinPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string PostCode = "18 years,1 day";
            DateTime Date = DateTime.Now.Date;
            Date.AddYears(-1000);
            string DateT = Date.ToString();

            Error = AnCustomer.Valid(PostCode, DateT);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateMaxMinusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string PostCode = "Today – 149 years 364 day";
            DateTime Date = DateTime.Now.Date;
            Date.AddYears(-1000);
            string DateT = Date.ToString();

            Error = AnCustomer.Valid(PostCode, DateT);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string PostCode = "Today – 150 years ";
            DateTime Date = DateTime.Now.Date;
            Date.AddYears(-1000);
            string DateT = Date.ToString();

            Error = AnCustomer.Valid(PostCode, DateT);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateMaxPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string PostCode = "Today – 150 years 1 day ";
            DateTime Date = DateTime.Now.Date;
            Date.AddYears(-1000);
            string DateT = Date.ToString();

            Error = AnCustomer.Valid(PostCode, DateT);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateMid()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string PostCode = "Today – 75 Years";
            DateTime Date = DateTime.Now.Date;
            Date.AddYears(-1000);
            string DateT = Date.ToString();

            Error = AnCustomer.Valid(PostCode, DateT);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateExtremeMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string PostCode = "01/01/21000";
            DateTime Date = DateTime.Now.Date;
            Date.AddYears(-1000);
            string DateT = Date.ToString();

            Error = AnCustomer.Valid(PostCode, DateT);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]

        public void PostcodeMin()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string PostCode = "LE212";
            DateTime Date = DateTime.Now.Date;
            Date.AddYears(-1000);
            string DateT = Date.ToString();

            Error = AnCustomer.Valid(PostCode, DateT);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PostcodeMinPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string PostCode = "LE2123";
            DateTime Date = DateTime.Now.Date;
            Date.AddYears(+1000);
            string DateT = Date.ToString();

            Error = AnCustomer.Valid(PostCode, DateT);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PostcodeMaxMinusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string PostCode = "LE21234";
            DateTime Date = DateTime.Now.Date;
            Date.AddYears(+1000);
            string DateT = Date.ToString();

            Error = AnCustomer.Valid(PostCode, DateT);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PostcodeMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string PostCode = "LE20AW";
            DateTime Date = DateTime.Now.Date;
            Date.AddYears(+1000);
            string DateT = Date.ToString();

            Error = AnCustomer.Valid(PostCode, DateT);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PostcodeMaxPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string PostCode = "LE20AW1";
            DateTime Date = DateTime.Now.Date;
            Date.AddYears(+1000);
            string DateT = Date.ToString();

            Error = AnCustomer.Valid(PostCode, DateT);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PostcodeMid()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string PostCode = "LE21234";
            DateTime Date = DateTime.Now.Date;
            Date.AddYears(+1000);
            string DateT = Date.ToString();

            Error = AnCustomer.Valid(PostCode, DateT);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PostcodeExtremeMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string PostCode = "LE20AWLE200000000000";
            DateTime Date = DateTime.Now.Date;
            Date.AddYears(+1000);
            string DateT = Date.ToString();

            Error = AnCustomer.Valid(PostCode, DateT);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void Surname()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string Surname = "Dean";
            string PostCode = "LE20AWLE200000000000";
            DateTime Date = DateTime.Now.Date;
            Date.AddYears(+1000);
            string DateT = Date.ToString();

            Error = AnCustomer.Valid(PostCode, Surname, DateT);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SurnameMin()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string Surname = "A";
            string PostCode = "LE20AWLE200000000000";
            DateTime Date = DateTime.Now.Date;
            Date.AddYears(+1000);
            string DateT = Date.ToString();

            Error = AnCustomer.Valid(PostCode, Surname, DateT);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SurnameMinPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string Surname = "JB";
            string PostCode = "LE20AWLE200000000000";
            DateTime Date = DateTime.Now.Date;
            Date.AddYears(+1000);
            string DateT = Date.ToString();

            Error = AnCustomer.Valid(PostCode, Surname, DateT);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SurnameMaxMinusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string Surname = "Abcdefhjklmnjhsaqwe";
            string PostCode = "LE20AWLE200000000000";
            DateTime Date = DateTime.Now.Date;
            Date.AddYears(+1000);
            string DateT = Date.ToString();

            Error = AnCustomer.Valid(PostCode, Surname, DateT);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SurnameMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string Surname = "Abcdefhjklmnjhsaqwea";
            string PostCode = "LE20AWLE200000000000";
            DateTime Date = DateTime.Now.Date;
            Date.AddYears(+1000);
            string DateT = Date.ToString();

            Error = AnCustomer.Valid(PostCode, Surname, DateT);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SurnameMaxPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string Surname = "Abcdefhjklmnjhsaqweaa";
            string PostCode = "LE20AWLE200000000000";
            DateTime Date = DateTime.Now.Date;
            Date.AddYears(+1000);
            string DateT = Date.ToString();

            Error = AnCustomer.Valid(PostCode, Surname, DateT);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void SurnameMid()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string Surname = "Avsafghnmjhg";
            string PostCode = "LE20AWLE200000000000";
            DateTime Date = DateTime.Now.Date;
            Date.AddYears(+1000);
            string DateT = Date.ToString();

            Error = AnCustomer.Valid(PostCode, Surname, DateT);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SurnameExtremeMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string Surname = "Samsung65325621478583254441251";
            string PostCode = "LE20AWLE200000000000";
            DateTime Date = DateTime.Now.Date;
            Date.AddYears(+1000);
            string DateT = Date.ToString();

            Error = AnCustomer.Valid(PostCode, Surname, DateT);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void HouseNo()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            Int32 HouseNo = 40;
            DateTime Date = DateTime.Now.Date;
            Date.AddYears(+1000);
            string DateT = Date.ToString();
            string Surname = "Samsung65325621478583254441251";
            string PostCode = "LE20AWLE200000000000";

            Error = AnCustomer.Valid(Surname, PostCode, HouseNo.ToString(), DateT);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void Gender()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string Gender = "Male";
            DateTime Date = DateTime.Now.Date;
            Date.AddYears(+1000);
            string DateT = Date.ToString();
            string Surname = "Samsung65325621478583254441251";
            string PostCode = "LE20AWLE200000000000";
            Int32 HouseNo = 40;

            Error = AnCustomer.Valid(Gender, Surname, PostCode, HouseNo.ToString(), DateT);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void Forename()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string Gender = "Male";
            string Forename = "Dean";
            DateTime Date = DateTime.Now.Date;
            Date.AddYears(+1000);
            string DateT = Date.ToString();
            string Surname = "Samsung65325621478583254441251";
            string PostCode = "LE20AWLE200000000000";
            Int32 HouseNo = 40;

            Error = AnCustomer.Valid(Forename, Gender, Surname, PostCode, HouseNo.ToString(), DateT);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ForenameMin()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string Gender = "Male";
            string Forename = "A";
            DateTime Date = DateTime.Now.Date;
            Date.AddYears(+1000);
            string DateT = Date.ToString();
            string Surname = "Samsung65325621478583254441251";
            string PostCode = "LE20AWLE200000000000";
            Int32 HouseNo = 40;

            Error = AnCustomer.Valid(Forename, Gender, Surname, PostCode, HouseNo.ToString(), DateT);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ForenameMinPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string Gender = "Male";
            string Forename = "JB";
            DateTime Date = DateTime.Now.Date;
            Date.AddYears(+1000);
            string DateT = Date.ToString();
            string Surname = "Samsung65325621478583254441251";
            string PostCode = "LE20AWLE200000000000";
            Int32 HouseNo = 40;

            Error = AnCustomer.Valid(Forename, Gender, Surname, PostCode, HouseNo.ToString(), DateT);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ForenameMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string Gender = "Male";
            string Forename = "Abcdefhjklmnjhsaqwea";
            DateTime Date = DateTime.Now.Date;
            Date.AddYears(+1000);
            string DateT = Date.ToString();
            string Surname = "Samsung65325621478583254441251";
            string PostCode = "LE20AWLE200000000000";
            Int32 HouseNo = 40;

            Error = AnCustomer.Valid(Forename, Gender, Surname, PostCode, HouseNo.ToString(), DateT);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ForenameMaxPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string Gender = "Male";
            string Forename = "Abcdefhjklmnjhsaqweaa";
            DateTime Date = DateTime.Now.Date;
            Date.AddYears(+1000);
            string DateT = Date.ToString();
            string Surname = "Samsung65325621478583254441251";
            string PostCode = "LE20AWLE200000000000";
            Int32 HouseNo = 40;

            Error = AnCustomer.Valid(Forename, Gender, Surname, PostCode, HouseNo.ToString(), DateT);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ForenameMid()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string Gender = "Male";
            string Forename = "Avsafghnmjhg";
            DateTime Date = DateTime.Now.Date;
            Date.AddYears(+1000);
            string DateT = Date.ToString();
            string Surname = "Samsung65325621478583254441251";
            string PostCode = "LE20AWLE200000000000";
            Int32 HouseNo = 40;

            Error = AnCustomer.Valid(Forename, Gender, Surname, PostCode, HouseNo.ToString(), DateT);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ForenameExtremeMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string Gender = "Male";
            string Forename = "Samsung65325621478583254441251";
            DateTime Date = DateTime.Now.Date;
            Date.AddYears(+1000);
            string DateT = Date.ToString();
            string Surname = "Samsung65325621478583254441251";
            string PostCode = "LE20AWLE200000000000";
            Int32 HouseNo = 40;

            Error = AnCustomer.Valid(Forename, Gender, Surname, PostCode, HouseNo.ToString(), DateT);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void FlatNo()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string Gender = "Male";
            string FlatNo = "73";
            DateTime Date = DateTime.Now.Date;
            Date.AddYears(+1000);
            string DateT = Date.ToString();
            string Surname = "Samsung65325621478583254441251";
            string PostCode = "LE20AWLE200000000000";
            Int32 HouseNo = 40;
            string Forename = "Samsung65325621478583254441251";

            Error = AnCustomer.Valid(FlatNo, Forename, Gender, Surname, PostCode, HouseNo.ToString(), DateT);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FlatNoMin()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string Gender = "Male";
            string FlatNo = "6";
            DateTime Date = DateTime.Now.Date;
            Date.AddYears(+1000);
            string DateT = Date.ToString();
            string Surname = "Samsung65325621478583254441251";
            string PostCode = "LE20AWLE200000000000";
            Int32 HouseNo = 40;
            string Forename = "Samsung65325621478583254441251";

            Error = AnCustomer.Valid(FlatNo, Forename, Gender, Surname, PostCode, HouseNo.ToString(), DateT);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FlatNoMinPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string Gender = "Male";
            string FlatNo = "62";
            DateTime Date = DateTime.Now.Date;
            Date.AddYears(+1000);
            string DateT = Date.ToString();
            string Surname = "Samsung65325621478583254441251";
            string PostCode = "LE20AWLE200000000000";
            Int32 HouseNo = 40;
            string Forename = "Samsung65325621478583254441251";

            Error = AnCustomer.Valid(FlatNo, Forename, Gender, Surname, PostCode, HouseNo.ToString(), DateT);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FlatNoMaxMinusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string Gender = "Male";
            string FlatNo = "10000";
            DateTime Date = DateTime.Now.Date;
            Date.AddYears(+1000);
            string DateT = Date.ToString();
            string Surname = "Samsung65325621478583254441251";
            string PostCode = "LE20AWLE200000000000";
            Int32 HouseNo = 40;
            string Forename = "Samsung65325621478583254441251";

            Error = AnCustomer.Valid(FlatNo, Forename, Gender, Surname, PostCode, HouseNo.ToString(), DateT);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FlatNoMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string Gender = "Male";
            string FlatNo = "100000";
            DateTime Date = DateTime.Now.Date;
            Date.AddYears(+1000);
            string DateT = Date.ToString();
            string Surname = "Samsung65325621478583254441251";
            string PostCode = "LE20AWLE200000000000";
            Int32 HouseNo = 40;
            string Forename = "Samsung65325621478583254441251";

            Error = AnCustomer.Valid(FlatNo, Forename, Gender, Surname, PostCode, HouseNo.ToString(), DateT);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FlatNoMaxPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string Gender = "Male";
            string FlatNo = "1000001";
            DateTime Date = DateTime.Now.Date;
            Date.AddYears(+1000);
            string DateT = Date.ToString();
            string Surname = "Samsung65325621478583254441251";
            string PostCode = "LE20AWLE200000000000";
            Int32 HouseNo = 40;
            string Forename = "Samsung65325621478583254441251";


            Error = AnCustomer.Valid(FlatNo, Forename, Gender, Surname, PostCode, HouseNo.ToString(), DateT);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void FlatNoMid()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string Gender = "Male";
            string FlatNo = "100";
            DateTime Date = DateTime.Now.Date;
            Date.AddYears(+1000);
            string DateT = Date.ToString();
            string Surname = "Samsung65325621478583254441251";
            string PostCode = "LE20AWLE200000000000";
            Int32 HouseNo = 40;
            string Forename = "Samsung65325621478583254441251";


            Error = AnCustomer.Valid(FlatNo, Forename, Gender, Surname, PostCode, HouseNo.ToString(), DateT);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FlatNoExtremeMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string Gender = "Male";
            string FlatNo = "1000000000000000000";
            DateTime Date = DateTime.Now.Date;
            Date.AddYears(+1000);
            string DateT = Date.ToString();
            string Surname = "Samsung65325621478583254441251";
            string PostCode = "LE20AWLE200000000000";
            Int32 HouseNo = 40;
            string Forename = "Samsung65325621478583254441251";


            Error = AnCustomer.Valid(FlatNo, Forename, Gender, Surname, PostCode, HouseNo.ToString(), DateT);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void Email()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string Gender = "Male";
            string Email = "Dean";
            DateTime Date = DateTime.Now.Date;
            Date.AddYears(+1000);
            string DateT = Date.ToString();
            string FlatNo = "1000000000000000000";
            string Surname = "Samsung65325621478583254441251";
            string PostCode = "LE20AWLE200000000000";
            Int32 HouseNo = 40;
            string Forename = "Samsung65325621478583254441251";

            Error = AnCustomer.Valid(Email, FlatNo, Forename, Gender, Surname, PostCode, HouseNo.ToString(), DateT);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMin()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string Gender = "Male";
            string Email = "123456";
            DateTime Date = DateTime.Now.Date;
            Date.AddYears(+1000);
            string DateT = Date.ToString();
            string FlatNo = "1000000000000000000";
            string Surname = "Samsung65325621478583254441251";
            string PostCode = "LE20AWLE200000000000";
            Int32 HouseNo = 40;
            string Forename = "Samsung65325621478583254441251";

            Error = AnCustomer.Valid(Email, FlatNo, Forename, Gender, Surname, PostCode, HouseNo.ToString(), DateT);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailMinPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string Gender = "Male";
            string Email = "1234567";
            DateTime Date = DateTime.Now.Date;
            Date.AddYears(+1000);
            string DateT = Date.ToString();
            string FlatNo = "1000000000000000000";
            string Surname = "Samsung65325621478583254441251";
            string PostCode = "LE20AWLE200000000000";
            Int32 HouseNo = 40;
            string Forename = "Samsung65325621478583254441251";

            Error = AnCustomer.Valid(Email, FlatNo, Forename, Gender, Surname, PostCode, HouseNo.ToString(), DateT);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailMaxMinusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string Gender = "Male";
            string Email = "Samsung1234567@Samsung1234567";
            DateTime Date = DateTime.Now.Date;
            Date.AddYears(+1000);
            string DateT = Date.ToString();
            string FlatNo = "1000000000000000000";
            string Surname = "Samsung65325621478583254441251";
            string PostCode = "LE20AWLE200000000000";
            Int32 HouseNo = 40;
            string Forename = "Samsung65325621478583254441251";

            Error = AnCustomer.Valid(Email, FlatNo, Forename, Gender, Surname, PostCode, HouseNo.ToString(), DateT);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string Gender = "Male";
            string Email = "Samsung1234567@Samsung12345671";
            DateTime Date = DateTime.Now.Date;
            Date.AddYears(+1000);
            string DateT = Date.ToString();
            string FlatNo = "1000000000000000000";
            string Surname = "Samsung65325621478583254441251";
            string PostCode = "LE20AWLE200000000000";
            Int32 HouseNo = 40;
            string Forename = "Samsung65325621478583254441251";

            Error = AnCustomer.Valid(Email, FlatNo, Forename, Gender, Surname, PostCode, HouseNo.ToString(), DateT);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailMaxPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string Gender = "Male";
            string Email = "Samsung1234567@Samsung123456711";
            DateTime Date = DateTime.Now.Date;
            Date.AddYears(+1000);
            string DateT = Date.ToString();
            string FlatNo = "1000000000000000000";
            string Surname = "Samsung65325621478583254441251";
            string PostCode = "LE20AWLE200000000000";
            Int32 HouseNo = 40;
            string Forename = "Samsung65325621478583254441251";

            Error = AnCustomer.Valid(Email, FlatNo, Forename, Gender, Surname, PostCode, HouseNo.ToString(), DateT);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void EmailMid()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string Gender = "Male";
            string Email = "Samsung123454";
            DateTime Date = DateTime.Now.Date;
            Date.AddYears(+1000);
            string DateT = Date.ToString();
            string FlatNo = "1000000000000000000";
            string Surname = "Samsung65325621478583254441251";
            string PostCode = "LE20AWLE200000000000";
            Int32 HouseNo = 40;
            string Forename = "Samsung65325621478583254441251";

            Error = AnCustomer.Valid(Email, FlatNo, Forename, Gender, Surname, PostCode, HouseNo.ToString(), DateT);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailExtremeMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string Gender = "Male";
            string Email = "Samsung1234567@Samsung12345671Samsung123";
            DateTime Date = DateTime.Now.Date;
            Date.AddYears(+1000);
            string DateT = Date.ToString();
            string FlatNo = "1000000000000000000";
            string Surname = "Samsung65325621478583254441251";
            string PostCode = "LE20AWLE200000000000";
            Int32 HouseNo = 40;
            string Forename = "Samsung65325621478583254441251";

            Error = AnCustomer.Valid(Email, FlatNo, Forename, Gender, Surname, PostCode, HouseNo.ToString(), DateT);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerID()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string Gender = "Male";
            string CustomerID = "Dean";
            DateTime Date = DateTime.Now.Date;
            Date.AddYears(+1000);
            string DateT = Date.ToString();
            string FlatNo = "1000000000000000000";
            string Surname = "Samsung65325621478583254441251";
            string PostCode = "LE20AWLE200000000000";
            Int32 HouseNo = 40;
            string Forename = "Samsung65325621478583254441251";

            Error = AnCustomer.Valid(CustomerID, Email, FlatNo, Forename, Gender, Surname, PostCode, HouseNo.ToString(), DateT);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ContactNo()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string Gender = "Male";
            String ContactNo = "2622345";
            DateTime Date = DateTime.Now.Date;
            Date.AddYears(+1000);
            string DateT = Date.ToString();
            string FlatNo = "1000000000000000000";
            string Surname = "Samsung65325621478583254441251";
            string PostCode = "LE20AWLE200000000000";
            Int32 HouseNo = 40;
            string Forename = "Samsung65325621478583254441251";
            string CustomerID = "Dean";

            Error = AnCustomer.Valid(ContactNo, CustomerID, Email, FlatNo, Forename, Gender, Surname, PostCode, HouseNo.ToString(), DateT);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ContactNoMin()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string Gender = "Male";
            String ContactNo = "000";
            DateTime Date = DateTime.Now.Date;
            Date.AddYears(+1000);
            string DateT = Date.ToString();
            string FlatNo = "1000000000000000000";
            string Surname = "Samsung65325621478583254441251";
            string PostCode = "LE20AWLE200000000000";
            Int32 HouseNo = 40;
            string Forename = "Samsung65325621478583254441251";
            string CustomerID = "Dean";

            Error = AnCustomer.Valid(ContactNo, CustomerID, Email, FlatNo, Forename, Gender, Surname, PostCode, HouseNo.ToString(), DateT);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ContactNoMinPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string Gender = "Male";
            String ContactNo = "0001";
            DateTime Date = DateTime.Now.Date;
            Date.AddYears(+1000);
            string DateT = Date.ToString();
            string FlatNo = "1000000000000000000";
            string Surname = "Samsung65325621478583254441251";
            string PostCode = "LE20AWLE200000000000";
            Int32 HouseNo = 40;
            string Forename = "Samsung65325621478583254441251";
            string CustomerID = "Dean";

            Error = AnCustomer.Valid(ContactNo, CustomerID, Email, FlatNo, Forename, Gender, Surname, PostCode, HouseNo.ToString(), DateT);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ContactNoMaxMinusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string Gender = "Male";
            String ContactNo = "2232232231";
            DateTime Date = DateTime.Now.Date;
            Date.AddYears(+1000);
            string DateT = Date.ToString();
            string FlatNo = "1000000000000000000";
            string Surname = "Samsung65325621478583254441251";
            string PostCode = "LE20AWLE200000000000";
            Int32 HouseNo = 40;
            string Forename = "Samsung65325621478583254441251";
            string CustomerID = "Dean";

            Error = AnCustomer.Valid(ContactNo, CustomerID, Email, FlatNo, Forename, Gender, Surname, PostCode, HouseNo.ToString(), DateT);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ContactNoMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string Gender = "Male";
            String ContactNo = "12345671211";
            DateTime Date = DateTime.Now.Date;
            Date.AddYears(+1000);
            string DateT = Date.ToString();
            string FlatNo = "1000000000000000000";
            string Surname = "Samsung65325621478583254441251";
            string PostCode = "LE20AWLE200000000000";
            Int32 HouseNo = 40;
            string Forename = "Samsung65325621478583254441251";
            string CustomerID = "Dean";

            Error = AnCustomer.Valid(ContactNo, CustomerID, Email, FlatNo, Forename, Gender, Surname, PostCode, HouseNo.ToString(), DateT);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ContactNoMaxPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string Gender = "Male";
            String ContactNo = "123456783331";
            DateTime Date = DateTime.Now.Date;
            Date.AddYears(+1000);
            string DateT = Date.ToString();
            string FlatNo = "1000000000000000000";
            string Surname = "Samsung65325621478583254441251";
            string PostCode = "LE20AWLE200000000000";
            Int32 HouseNo = 40;
            string Forename = "Samsung65325621478583254441251";
            string CustomerID = "Dean";

            Error = AnCustomer.Valid(ContactNo, CustomerID, Email, FlatNo, Forename, Gender, Surname, PostCode, HouseNo.ToString(), DateT);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ContactNoMid()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string Gender = "Male";
            String ContactNo = "154361";
            DateTime Date = DateTime.Now.Date;
            Date.AddYears(+1000);
            string DateT = Date.ToString();
            string FlatNo = "1000000000000000000";
            string Surname = "Samsung65325621478583254441251";
            string PostCode = "LE20AWLE200000000000";
            Int32 HouseNo = 40;
            string Forename = "Samsung65325621478583254441251";
            string CustomerID = "Dean";

            Error = AnCustomer.Valid(ContactNo, CustomerID, Email, FlatNo, Forename, Gender, Surname, PostCode, HouseNo.ToString(), DateT);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ContactNoExtremeMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string Gender = "Male";
            String ContactNo = "26661216461662612616111";
            DateTime Date = DateTime.Now.Date;
            Date.AddYears(+1000);
            string DateT = Date.ToString();
            string FlatNo = "1000000000000000000";
            string Surname = "Samsung65325621478583254441251";
            string PostCode = "LE20AWLE200000000000";
            Int32 HouseNo = 40;
            string Forename = "Dean";
            string CustomerID = "Dean";

            Error = AnCustomer.Valid(ContactNo, CustomerID, Email, FlatNo, Forename, Gender, Surname, PostCode, HouseNo.ToString(), DateT);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void Username()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string Gender = "Male";
            String Username = "mjdeandmu";
            DateTime Date = DateTime.Now.Date;
            Date.AddYears(+1000);
            string DateT = Date.ToString();
            string FlatNo = "1000000000000000000";
            string Surname = "Samsung65325621478583254441251";
            string PostCode = "LE20AWLE200000000000";
            Int32 HouseNo = 40;
            string Forename = "Dean";
            string CustomerID = "Dean";
            String ContactNo = "26661216461662612616111";

            Error = AnCustomer.Valid(Username, ContactNo, CustomerID, Email, FlatNo, Forename, Gender, Surname, PostCode, HouseNo.ToString(), DateT);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void UsernameMin()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string Gender = "Male";
            String Username = "12345";
            DateTime Date = DateTime.Now.Date;
            Date.AddYears(+1000);
            string DateT = Date.ToString();
            string FlatNo = "1000000000000000000";
            string Surname = "Samsung65325621478583254441251";
            string PostCode = "LE20AWLE200000000000";
            Int32 HouseNo = 40;
            string Forename = "Dean";
            string CustomerID = "Dean";
            String ContactNo = "26661216461662612616111";

            Error = AnCustomer.Valid(Username, ContactNo, CustomerID, Email, FlatNo, Forename, Gender, Surname, PostCode, HouseNo.ToString(), DateT);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void UsernameMinPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string Gender = "Male";
            String Username = "123456";
            DateTime Date = DateTime.Now.Date;
            Date.AddYears(+1000);
            string DateT = Date.ToString();
            string FlatNo = "1000000000000000000";
            string Surname = "Samsung65325621478583254441251";
            string PostCode = "LE20AWLE200000000000";
            Int32 HouseNo = 40;
            string Forename = "Dean";
            string CustomerID = "Dean";
            String ContactNo = "26661216461662612616111";

            Error = AnCustomer.Valid(Username, ContactNo, CustomerID, Email, FlatNo, Forename, Gender, Surname, PostCode, HouseNo.ToString(), DateT);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void UsernameMaxMinusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string Gender = "Male";
            String Username = "1234567890123456789";
            DateTime Date = DateTime.Now.Date;
            Date.AddYears(+1000);
            string DateT = Date.ToString();
            string FlatNo = "1000000000000000000";
            string Surname = "Samsung65325621478583254441251";
            string PostCode = "LE20AWLE200000000000";
            Int32 HouseNo = 40;
            string Forename = "Dean";
            string CustomerID = "Dean";
            String ContactNo = "26661216461662612616111";

            Error = AnCustomer.Valid(Username, ContactNo, CustomerID, Email, FlatNo, Forename, Gender, Surname, PostCode, HouseNo.ToString(), DateT);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void UsernameMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string Gender = "Male";
            String Username = "12345678901234567890";
            DateTime Date = DateTime.Now.Date;
            Date.AddYears(+1000);
            string DateT = Date.ToString();
            string FlatNo = "1000000000000000000";
            string Surname = "Samsung65325621478583254441251";
            string PostCode = "LE20AWLE200000000000";
            Int32 HouseNo = 40;
            string Forename = "Dean";
            string CustomerID = "Dean";
            String ContactNo = "26661216461662612616111";

            Error = AnCustomer.Valid(Username, ContactNo, CustomerID, Email, FlatNo, Forename, Gender, Surname, PostCode, HouseNo.ToString(), DateT);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void UsernameMaxPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string Gender = "Male";
            String Username = "123456789012345678901";
            DateTime Date = DateTime.Now.Date;
            Date.AddYears(+1000);
            string DateT = Date.ToString();
            string FlatNo = "1000000000000000000";
            string Surname = "Samsung65325621478583254441251";
            string PostCode = "LE20AWLE200000000000";
            Int32 HouseNo = 40;
            string Forename = "Dean";
            string CustomerID = "Dean";
            String ContactNo = "26661216461662612616111";

            Error = AnCustomer.Valid(Username, ContactNo, CustomerID, Email, FlatNo, Forename, Gender, Surname, PostCode, HouseNo.ToString(), DateT);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void UsernameMid()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string Gender = "Male";
            String Username = "1234567890123";
            DateTime Date = DateTime.Now.Date;
            Date.AddYears(+1000);
            string DateT = Date.ToString();
            string FlatNo = "1000000000000000000";
            string Surname = "Samsung65325621478583254441251";
            string PostCode = "LE20AWLE200000000000";
            Int32 HouseNo = 40;
            string Forename = "Dean";
            string CustomerID = "Dean";
            String ContactNo = "26661216461662612616111";

            Error = AnCustomer.Valid(Username, ContactNo, CustomerID, Email, FlatNo, Forename, Gender, Surname, PostCode, HouseNo.ToString(), DateT);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void UsernameExtremeMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string Gender = "Male";
            String Username = "1234567890123456789012345678901234567890";
            DateTime Date = DateTime.Now.Date;
            Date.AddYears(+1000);
            string DateT = Date.ToString();
            string FlatNo = "1000000000000000000";
            string Surname = "Samsung65325621478583254441251";
            string PostCode = "LE20AWLE200000000000";
            Int32 HouseNo = 40;
            string Forename = "Dean";
            string CustomerID = "Dean";
            String ContactNo = "26661216461662612616111";

            Error = AnCustomer.Valid(Username, ContactNo, CustomerID, Email, FlatNo, Forename, Gender, Surname, PostCode, HouseNo.ToString(), DateT);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void Password()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string Gender = "Male";
            String Password = "mjdeandmu";
            DateTime Date = DateTime.Now.Date;
            Date.AddYears(+1000);
            string DateT = Date.ToString();
            string FlatNo = "1000000000000000000";
            string Surname = "Samsung65325621478583254441251";
            string PostCode = "LE20AWLE200000000000";
            Int32 HouseNo = 40;
            string Forename = "Dean";
            string CustomerID = "Dean";
            String ContactNo = "26661216461662612616111";

            Error = AnCustomer.Valid(Password, Username, ContactNo, CustomerID, Email, FlatNo, Forename, Gender, Surname, PostCode, HouseNo.ToString(), DateT);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PasswordMin()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string Gender = "Male";
            String Password = "12345";
            DateTime Date = DateTime.Now.Date;
            Date.AddYears(+1000);
            string DateT = Date.ToString();
            string FlatNo = "1000000000000000000";
            string Surname = "Samsung65325621478583254441251";
            string PostCode = "LE20AWLE200000000000";
            Int32 HouseNo = 40;
            string Forename = "Dean";
            string CustomerID = "Dean";
            String ContactNo = "26661216461662612616111";

            Error = AnCustomer.Valid(Password, Username, ContactNo, CustomerID, Email, FlatNo, Forename, Gender, Surname, PostCode, HouseNo.ToString(), DateT);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PasswordMinPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string Gender = "Male";
            String Password = "123456";
            DateTime Date = DateTime.Now.Date;
            Date.AddYears(+1000);
            string DateT = Date.ToString();
            string FlatNo = "1000000000000000000";
            string Surname = "Samsung65325621478583254441251";
            string PostCode = "LE20AWLE200000000000";
            Int32 HouseNo = 40;
            string Forename = "Dean";
            string CustomerID = "Dean";
            String ContactNo = "26661216461662612616111";

            Error = AnCustomer.Valid(Password, Username, ContactNo, CustomerID, Email, FlatNo, Forename, Gender, Surname, PostCode, HouseNo.ToString(), DateT);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PasswordMaxMinusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string Gender = "Male";
            String Password = "1234567890123456789";
            DateTime Date = DateTime.Now.Date;
            Date.AddYears(+1000);
            string DateT = Date.ToString();
            string FlatNo = "1000000000000000000";
            string Surname = "Samsung65325621478583254441251";
            string PostCode = "LE20AWLE200000000000";
            Int32 HouseNo = 40;
            string Forename = "Dean";
            string CustomerID = "Dean";
            String ContactNo = "26661216461662612616111";

            Error = AnCustomer.Valid(Password, Username, ContactNo, CustomerID, Email, FlatNo, Forename, Gender, Surname, PostCode, HouseNo.ToString(), DateT);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PasswordMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string Gender = "Male";
            String Password = "12345678901234567890";
            DateTime Date = DateTime.Now.Date;
            Date.AddYears(+1000);
            string DateT = Date.ToString();
            string FlatNo = "1000000000000000000";
            string Surname = "Samsung65325621478583254441251";
            string PostCode = "LE20AWLE200000000000";
            Int32 HouseNo = 40;
            string Forename = "Dean";
            string CustomerID = "Dean";
            String ContactNo = "26661216461662612616111";

            Error = AnCustomer.Valid(Password, Username, ContactNo, CustomerID, Email, FlatNo, Forename, Gender, Surname, PostCode, HouseNo.ToString(), DateT);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PasswordMaxPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string Gender = "Male";
            String Password = "123456789012345678901";
            DateTime Date = DateTime.Now.Date;
            Date.AddYears(+1000);
            string DateT = Date.ToString();
            string FlatNo = "1000000000000000000";
            string Surname = "Samsung65325621478583254441251";
            string PostCode = "LE20AWLE200000000000";
            Int32 HouseNo = 40;
            string Forename = "Dean";
            string CustomerID = "Dean";
            String ContactNo = "26661216461662612616111";

            Error = AnCustomer.Valid(Password, Username, ContactNo, CustomerID, Email, FlatNo, Forename, Gender, Surname, PostCode, HouseNo.ToString(), DateT);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PasswordMid()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string Gender = "Male";
            String Password = "1234567890123";
            DateTime Date = DateTime.Now.Date;
            Date.AddYears(+1000);
            string DateT = Date.ToString();
            string FlatNo = "1000000000000000000";
            string Surname = "Samsung65325621478583254441251";
            string PostCode = "LE20AWLE200000000000";
            Int32 HouseNo = 40;
            string Forename = "Dean";
            string CustomerID = "Dean";
            String ContactNo = "26661216461662612616111";

            Error = AnCustomer.Valid(Password, Username, ContactNo, CustomerID, Email, FlatNo, Forename, Gender, Surname, PostCode, HouseNo.ToString(), DateT);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PasswordExtremeMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string Gender = "Male";
            String Password = "1234567890123456789012345678901234567890";
            DateTime Date = DateTime.Now.Date;
            Date.AddYears(+1000);
            string DateT = Date.ToString();
            string FlatNo = "1000000000000000000";
            string Surname = "Samsung65325621478583254441251";
            string PostCode = "LE20AWLE200000000000";
            Int32 HouseNo = 40;
            string Forename = "Dean";
            string CustomerID = "Dean";
            String ContactNo = "26661216461662612616111";

            Error = AnCustomer.Valid(Password, Username, ContactNo, CustomerID, Email, FlatNo, Forename, Gender, Surname, PostCode, HouseNo.ToString(), DateT);
            Assert.AreNotEqual(Error, "");
        }
    }
}
