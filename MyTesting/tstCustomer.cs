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
            AnCustomer.dateOfBirth = Date;
            Assert.AreEqual(AnCustomer.dateOfBirth, Date);

        }

        [TestMethod]
        public void ValidExist()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string AllOK = "";
            string UserName = "freda";
            string Password = "password";
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";

            AllOK = AnCustomer.Valid(UserName, Password, ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void UsernameExtremeMin()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string AllOK = "";
            string UserName = "";
            string Password = "password";
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";

            AllOK = AnCustomer.Valid(UserName, Password, ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void UsernameMinMinus1()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string AllOK = "";
            string UserName = "aaaa";
            string Password = "password";
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";

            AllOK = AnCustomer.Valid(UserName, Password, ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void UsernameBoundryMin()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string AllOK = "";
            string UserName = "aaaaa";
            string Password = "password";
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";

            AllOK = AnCustomer.Valid(UserName, Password, ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void UsernameBoundryMinPlus1()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string AllOK = "";
            string UserName = "aaaaaa";
            string Password = "password";
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";

            AllOK = AnCustomer.Valid(UserName, Password, ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void UsernameBoundryMaxMinus1()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string AllOK = "";
            string UserName = "";
            UserName = UserName.PadRight(19, 'a');
            string Password = "password";
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";

            AllOK = AnCustomer.Valid(UserName, Password, ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void UsernameBoundryMaxBoundry()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string AllOK = "";
            string UserName = "";
            UserName = UserName.PadRight(20, 'a');
            string Password = "password";
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";

            AllOK = AnCustomer.Valid(UserName, Password, ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void UsernameBoundryMaxPlus1()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string AllOK = "";
            string UserName = "";
            UserName = UserName.PadRight(21, 'a');
            string Password = "password";
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";

            AllOK = AnCustomer.Valid(UserName, Password, ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void UsernameBoundryMid()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string AllOK = "";
            string UserName = "";
            UserName = UserName.PadRight(13, 'a');
            string Password = "password";
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";

            AllOK = AnCustomer.Valid(UserName, Password, ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            Assert.AreEqual(AllOK, "");
        }


        [TestMethod]
        public void UsernameExtremeMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string AllOK = "";
            string UserName = "";
            UserName = UserName.PadRight(100, 'a');
            string Password = "password";
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";

            AllOK = AnCustomer.Valid(UserName, Password, ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            Assert.AreNotEqual(AllOK, "");
        }
        [TestMethod]
        public void PasswordExtremeMin()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string AllOK = "";
            string UserName = "freda";
            string Password = "";
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";

            AllOK = AnCustomer.Valid(UserName, Password, ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void PasswordMinMinus1()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string AllOK = "";
            string UserName = "freda";
            string Password = "aaaa";
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";

            AllOK = AnCustomer.Valid(UserName, Password, ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            Assert.AreNotEqual(AllOK, "");

        }

        [TestMethod]
        public void PasswordBoundaryMin()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string AllOK = "";
            string UserName = "freda";
            string Password = "aaaaa";
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";

            AllOK = AnCustomer.Valid(UserName, Password, ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            Assert.AreEqual(AllOK, "");

        }

        [TestMethod]
        public void PasswordBoundaryMinPlus1()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string AllOK = "";
            string UserName = "freda";
            string Password = "aaaaaa";
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";

            AllOK = AnCustomer.Valid(UserName, Password, ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            Assert.AreEqual(AllOK, "");

        }

        [TestMethod]
        public void PasswordBoundaryMaxMinus1()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string AllOK = "";
            string UserName = "freda";
            string Password = "ashjklkjmnhjklikjhg";
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";

            AllOK = AnCustomer.Valid(UserName, Password, ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            Assert.AreEqual(AllOK, "");

        }

        [TestMethod]
        public void PasswordBoundaryMaxBoundary()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string AllOK = "";
            string UserName = "freda";
            string Password = "ashjklkjmnhjklikjhga";
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";

            AllOK = AnCustomer.Valid(UserName, Password, ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            Assert.AreEqual(AllOK, "");

        }

        [TestMethod]
        public void PasswordBoundaryMaxPlus1()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string AllOK = "";
            string UserName = "freda";
            string Password = "ashjklkjmnhjklikjhgaa";
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";

            AllOK = AnCustomer.Valid(UserName, Password, ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            Assert.AreNotEqual(AllOK, "");

        }

        [TestMethod]
        public void PasswordBoundaryMid()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string AllOK = "";
            string UserName = "freda";
            string Password = "ashasdfghjklo";
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";

            AllOK = AnCustomer.Valid(UserName, Password, ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            Assert.AreEqual(AllOK, "");

        }

        [TestMethod]
        public void PasswordExtremeMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string AllOK = "";
            string UserName = "freda";
            string Password = "asdfghjkloasdfghjkloasdfghjkloasdfghjklo";
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";

            AllOK = AnCustomer.Valid(UserName, Password, ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            Assert.AreNotEqual(AllOK, "");

        }

        [TestMethod]
        public void ForenameMinMinus1()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string AllOK = "";
            string UserName = "freda";
            string Password = "password";
            string ForeName = "";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";

            AllOK = AnCustomer.Valid(UserName, Password, ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void ForenameBoundaryMin()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string AllOK = "";
            string UserName = "freda";
            string Password = "password";
            string ForeName = "A";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";

            AllOK = AnCustomer.Valid(UserName, Password, ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void ForenameBoundaryMinPlus1()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string AllOK = "";
            string UserName = "freda";
            string Password = "password";
            string ForeName = "ab";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";

            AllOK = AnCustomer.Valid(UserName, Password, ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void ForenameBoundaryMaxMinus1()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string AllOK = "";
            string UserName = "freda";
            string Password = "password";
            string ForeName = "Abcdefhjklmnjhsaqwe";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";

            AllOK = AnCustomer.Valid(UserName, Password, ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void ForenameBoundaryMaxBoundary()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string AllOK = "";
            string UserName = "freda";
            string Password = "password";
            string ForeName = "Abcdefhjklmnjhsaqweh";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";

            AllOK = AnCustomer.Valid(UserName, Password, ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void ForenameBoundaryMaxPlus1()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string AllOK = "";
            string UserName = "freda";
            string Password = "password";
            string ForeName = "";
            ForeName = ForeName.PadRight(26, 'a');
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";

            AllOK = AnCustomer.Valid(UserName, Password, ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void ForenameBoundaryMid()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string AllOK = "";
            string UserName = "freda";
            string Password = "password";
            string ForeName = "";
            ForeName = ForeName.PadRight(13, 'a');
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";

            AllOK = AnCustomer.Valid(UserName, Password, ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void ForenameExtremeMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string AllOK = "";
            string UserName = "freda";
            string Password = "password";
            string ForeName = "";
            ForeName = ForeName.PadRight(30, 'a');
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";

            AllOK = AnCustomer.Valid(UserName, Password, ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void SurnameMinMinus1()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string AllOK = "";
            string UserName = "freda";
            string Password = "password";
            string ForeName = "fred";
            string Surname = "";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";

            AllOK = AnCustomer.Valid(UserName, Password, ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void SurnameBoundaryMin()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string AllOK = "";
            string UserName = "freda";
            string Password = "password";
            string ForeName = "fred";
            string Surname = "A";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";

            AllOK = AnCustomer.Valid(UserName, Password, ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void SurnameBoundaryMinPlus1()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string AllOK = "";
            string UserName = "freda";
            string Password = "password";
            string ForeName = "fred";
            string Surname = "JB";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";

            AllOK = AnCustomer.Valid(UserName, Password, ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void SurnameBoundaryMaxMinus1()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string AllOK = "";
            string UserName = "freda";
            string Password = "password";
            string ForeName = "fred";
            string Surname = "Abcdefhjklmnjhsaqweasasa";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";

            AllOK = AnCustomer.Valid(UserName, Password, ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void SurnameBoundaryMaxBoundary()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string AllOK = "";
            string UserName = "freda";
            string Password = "password";
            string ForeName = "fred";
            string Surname = "Abcdefhjklmnjhsaqweasasaa";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";

            AllOK = AnCustomer.Valid(UserName, Password, ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            Assert.AreEqual(AllOK, "");
        }


        [TestMethod]
        public void SurnameBoundaryMaxPlus1()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string AllOK = "";
            string UserName = "freda";
            string Password = "password";
            string ForeName = "fred";
            string Surname = "Abcdefhjklmnjhsaqweasasaas";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";

            AllOK = AnCustomer.Valid(UserName, Password, ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void SurnameBoundaryMid()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string AllOK = "";
            string UserName = "freda";
            string Password = "password";
            string ForeName = "fred";
            string Surname = "Abcdefhjkasav";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";

            AllOK = AnCustomer.Valid(UserName, Password, ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void SurnameExtremeMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string AllOK = "";
            string UserName = "freda";
            string Password = "password";
            string ForeName = "fred";
            string Surname = "Abcdefhjklmnjhsaqweaabdfvdfgvc";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";

            AllOK = AnCustomer.Valid(UserName, Password, ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void DateTestMinMinus1()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string AllOK = "";
            string UserName = "freda";
            string Password = "password";
            string ForeName = "fred";
            string Surname = "Abcdefhc";
            string DateOfBirth = DateTime.Now.Date.AddYears(-17).AddDays(+364).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";

            AllOK = AnCustomer.Valid(UserName, Password, ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void DateTestBoundryMin()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string AllOK = "";
            string UserName = "freda";
            string Password = "password";
            string ForeName = "fred";
            string Surname = "Abcdefhc";
            string DateOfBirth = DateTime.Now.Date.AddYears(-18).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";

            AllOK = AnCustomer.Valid(UserName, Password, ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void DateTestBoundryMinPlus1()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string AllOK = "";
            string UserName = "freda";
            string Password = "password";
            string ForeName = "fred";
            string Surname = "Abcdefhc";
            string DateOfBirth = DateTime.Now.Date.AddYears(-18).AddDays(+1).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";

            AllOK = AnCustomer.Valid(UserName, Password, ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void DateTestMaxMinus1()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string AllOK = "";
            string UserName = "freda";
            string Password = "password";
            string ForeName = "fred";
            string Surname = "Abcdefhc";
            string DateOfBirth = DateTime.Now.Date.AddYears(-149).AddDays(+364).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";

            AllOK = AnCustomer.Valid(UserName, Password, ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void DateTestMaxBoundary()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string AllOK = "";
            string UserName = "freda";
            string Password = "password";
            string ForeName = "fred";
            string Surname = "Abcdefhc";
            string DateOfBirth = DateTime.Now.Date.AddYears(-150).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";

            AllOK = AnCustomer.Valid(UserName, Password, ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void DateTestBoundryMaxPlus1()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string AllOK = "";
            string UserName = "freda";
            string Password = "password";
            string ForeName = "fred";
            string Surname = "Abcdefhc";
            string DateOfBirth = DateTime.Now.Date.AddYears(-150).AddDays(+1).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";

            AllOK = AnCustomer.Valid(UserName, Password, ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            Assert.AreEqual(AllOK, "");

        }

        [TestMethod]
        public void DateTestBoundryMid()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string AllOK = "";
            string UserName = "freda";
            string Password = "password";
            string ForeName = "fred";
            string Surname = "Abcdefhc";
            string DateOfBirth = DateTime.Now.Date.AddYears(-75).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";

            AllOK = AnCustomer.Valid(UserName, Password, ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            Assert.AreEqual(AllOK, "");

        }

        [TestMethod]
        public void DateTestInvalidData()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string AllOK = "";
            string UserName = "freda";
            string Password = "password";
            string ForeName = "fred";
            string Surname = "Abcdefhc";
            string DateOfBirth = "123";
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";

            AllOK = AnCustomer.Valid(UserName, Password, ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void GenderMinMinus1()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string AllOK = "";
            string UserName = "freda";
            string Password = "password";
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";

            AllOK = AnCustomer.Valid(UserName, Password, ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void GenderBoundaryMin()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string AllOK = "";
            string UserName = "freda";
            string Password = "password";
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "F";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";

            AllOK = AnCustomer.Valid(UserName, Password, ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void GenderBoundaryMinPlus1()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string AllOK = "";
            string UserName = "freda";
            string Password = "password";
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "Fe";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";

            AllOK = AnCustomer.Valid(UserName, Password, ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void GenderBoundaryMaxMinus1()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string AllOK = "";
            string UserName = "freda";
            string Password = "password";
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "Femal";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";

            AllOK = AnCustomer.Valid(UserName, Password, ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void GenderBoundaryMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string AllOK = "";
            string UserName = "freda";
            string Password = "password";
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "Female";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";

            AllOK = AnCustomer.Valid(UserName, Password, ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void GenderBoundaryMaxPlus1()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string AllOK = "";
            string UserName = "freda";
            string Password = "password";
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "Females";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";

            AllOK = AnCustomer.Valid(UserName, Password, ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void GenderBoundaryMid()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string AllOK = "";
            string UserName = "freda";
            string Password = "password";
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "Fem";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";

            AllOK = AnCustomer.Valid(UserName, Password, ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void GenderExtremeMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string AllOK = "";
            string UserName = "freda";
            string Password = "password";
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "ABCDEFEJNKGFNGKGMGKG";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";

            AllOK = AnCustomer.Valid(UserName, Password, ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void ContactNumberExtremeMin()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string AllOK = "";
            string UserName = "freda";
            string Password = "password";
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";

            AllOK = AnCustomer.Valid(UserName, Password, ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void ContactNumberBoundaryMinMinus1()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string AllOK = "";
            string UserName = "freda";
            string Password = "password";
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "12";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";

            AllOK = AnCustomer.Valid(UserName, Password, ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void ContactNumberBoundaryMin()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string AllOK = "";
            string UserName = "freda";
            string Password = "password";
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "123";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";

            AllOK = AnCustomer.Valid(UserName, Password, ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void ContactNumberBoundaryMinPlus1()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string AllOK = "";
            string UserName = "freda";
            string Password = "password";
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "1234";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";

            AllOK = AnCustomer.Valid(UserName, Password, ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void ContactNumberBoundaryMaxMinus1()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string AllOK = "";
            string UserName = "freda";
            string Password = "password";
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "1234567890";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";

            AllOK = AnCustomer.Valid(UserName, Password, ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void ContactNumberBoundaryMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string AllOK = "";
            string UserName = "freda";
            string Password = "password";
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "12345678901";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";

            AllOK = AnCustomer.Valid(UserName, Password, ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void ContactNumberBoundaryMaxPlus1()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string AllOK = "";
            string UserName = "freda";
            string Password = "password";
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "123456789010";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";

            AllOK = AnCustomer.Valid(UserName, Password, ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void ContactNumberBoundaryMid()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string AllOK = "";
            string UserName = "freda";
            string Password = "password";
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "123456";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";

            AllOK = AnCustomer.Valid(UserName, Password, ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            Assert.AreEqual(AllOK, "");
        }


        [TestMethod]
        public void ContactNumberExtremeMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string AllOK = "";
            string UserName = "freda";
            string Password = "password";
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "12345612345612345600";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";

            AllOK = AnCustomer.Valid(UserName, Password, ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void EmailExtremeMin()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string AllOK = "";
            string UserName = "freda";
            string Password = "password";
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";

            AllOK = AnCustomer.Valid(UserName, Password, ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void EmailBoundaryMinMinus1()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string AllOK = "";
            string UserName = "freda";
            string Password = "password";
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "12345";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";

            AllOK = AnCustomer.Valid(UserName, Password, ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void EmailBoundaryMin()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string AllOK = "";
            string UserName = "freda";
            string Password = "password";
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "123456";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";

            AllOK = AnCustomer.Valid(UserName, Password, ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void EmailBoundaryMinPlus1()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string AllOK = "";
            string UserName = "freda";
            string Password = "password";
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "1234567";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";

            AllOK = AnCustomer.Valid(UserName, Password, ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void EmailBoundaryMaxMinus1()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string AllOK = "";
            string UserName = "freda";
            string Password = "password";
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "Samsung1234567@Samsung1234567";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";

            AllOK = AnCustomer.Valid(UserName, Password, ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void EmailBoundaryMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string AllOK = "";
            string UserName = "freda";
            string Password = "password";
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "Samsung1234567@Samsung12345671";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";

            AllOK = AnCustomer.Valid(UserName, Password, ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void EmailBoundaryMaxPlus1()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string AllOK = "";
            string UserName = "freda";
            string Password = "password";
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "Samsung1234567@Samsung123456711";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";

            AllOK = AnCustomer.Valid(UserName, Password, ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void EmailBoundaryMid()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string AllOK = "";
            string UserName = "freda";
            string Password = "password";
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "Samsun@.co.uk";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";

            AllOK = AnCustomer.Valid(UserName, Password, ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void EmailExtremeMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string AllOK = "";
            string UserName = "freda";
            string Password = "password";
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "Samsung1234567@Samsung123456712345678951";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";

            AllOK = AnCustomer.Valid(UserName, Password, ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void FlatNoBoundaryMinMinus1()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string AllOK = "";
            string UserName = "freda";
            string Password = "password";
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";

            AllOK = AnCustomer.Valid(UserName, Password, ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void FlatNoBoundaryMin()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string AllOK = "";
            string UserName = "freda";
            string Password = "password";
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "6";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";

            AllOK = AnCustomer.Valid(UserName, Password, ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void FlatNoBoundaryMinPlus1()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string AllOK = "";
            string UserName = "freda";
            string Password = "password";
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "62";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";

            AllOK = AnCustomer.Valid(UserName, Password, ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void FlatNoBoundaryMaxMinus1()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string AllOK = "";
            string UserName = "freda";
            string Password = "password";
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "10000";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";

            AllOK = AnCustomer.Valid(UserName, Password, ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            Assert.AreEqual(AllOK, "");
        }


        [TestMethod]
        public void FlatNoBoundaryMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string AllOK = "";
            string UserName = "freda";
            string Password = "password";
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "100000";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";

            AllOK = AnCustomer.Valid(UserName, Password, ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            Assert.AreEqual(AllOK, "");
        }


        [TestMethod]
        public void FlatNoBoundaryMaxPlus1()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string AllOK = "";
            string UserName = "freda";
            string Password = "password";
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1000001";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";

            AllOK = AnCustomer.Valid(UserName, Password, ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void FlatNoBoundaryMid()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string AllOK = "";
            string UserName = "freda";
            string Password = "password";
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "100";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";

            AllOK = AnCustomer.Valid(UserName, Password, ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void FlatNoExtremeMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string AllOK = "";
            string UserName = "freda";
            string Password = "password";
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "10000000000000000000";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";

            AllOK = AnCustomer.Valid(UserName, Password, ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void HouseNoBoundaryMinMinus1()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string AllOK = "";
            string UserName = "freda";
            string Password = "password";
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "";
            string PostCode = "LE5 6HP";

            AllOK = AnCustomer.Valid(UserName, Password, ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void HouseNoBoundaryMin()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string AllOK = "";
            string UserName = "freda";
            string Password = "password";
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "6";
            string PostCode = "LE5 6HP";

            AllOK = AnCustomer.Valid(UserName, Password, ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void HouseNoBoundaryMinPlus1()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string AllOK = "";
            string UserName = "freda";
            string Password = "password";
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "62";
            string PostCode = "LE5 6HP";

            AllOK = AnCustomer.Valid(UserName, Password, ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void HouseNoBoundaryMaxMinus1()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string AllOK = "";
            string UserName = "freda";
            string Password = "password";
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "10000";
            string PostCode = "LE5 6HP";

            AllOK = AnCustomer.Valid(UserName, Password, ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void HouseNoBoundaryMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string AllOK = "";
            string UserName = "freda";
            string Password = "password";
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "100000";
            string PostCode = "LE5 6HP";

            AllOK = AnCustomer.Valid(UserName, Password, ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void HouseNoBoundaryMaxPlus1()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string AllOK = "";
            string UserName = "freda";
            string Password = "password";
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "1000001";
            string PostCode = "LE5 6HP";

            AllOK = AnCustomer.Valid(UserName, Password, ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void HouseNoBoundaryMid()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string AllOK = "";
            string UserName = "freda";
            string Password = "password";
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "100";
            string PostCode = "LE5 6HP";

            AllOK = AnCustomer.Valid(UserName, Password, ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void HouseNoExtremeMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string AllOK = "";
            string UserName = "freda";
            string Password = "password";
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "10000000000000000000";
            string PostCode = "LE5 6HP";

            AllOK = AnCustomer.Valid(UserName, Password, ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            Assert.AreNotEqual(AllOK, "");

        }

        [TestMethod]
        public void PostCodeExtremeMin()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string AllOK = "";
            string UserName = "freda";
            string Password = "password";
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "";

            AllOK = AnCustomer.Valid(UserName, Password, ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void PostCodeBoundaryMinMinus1()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string AllOK = "";
            string UserName = "freda";
            string Password = "password";
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE11";

            AllOK = AnCustomer.Valid(UserName, Password, ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void PostCodeBoundaryMin()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string AllOK = "";
            string UserName = "freda";
            string Password = "password";
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE212";

            AllOK = AnCustomer.Valid(UserName, Password, ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void PostCodeBoundaryMinPlus1()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string AllOK = "";
            string UserName = "freda";
            string Password = "password";
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE2122";

            AllOK = AnCustomer.Valid(UserName, Password, ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void PostCodeBoundaryMaxMinus1()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string AllOK = "";
            string UserName = "freda";
            string Password = "password";
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE212232";

            AllOK = AnCustomer.Valid(UserName, Password, ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void PostCodeBoundaryMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string AllOK = "";
            string UserName = "freda";
            string Password = "password";
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE2122321";

            AllOK = AnCustomer.Valid(UserName, Password, ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void PostCodeBoundaryMaxPlus1()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string AllOK = "";
            string UserName = "freda";
            string Password = "password";
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE21223211";

            AllOK = AnCustomer.Valid(UserName, Password, ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void PostCodeBoundaryMid()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string AllOK = "";
            string UserName = "freda";
            string Password = "password";
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE221369";

            AllOK = AnCustomer.Valid(UserName, Password, ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void PostCodeExtremeMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string AllOK = "";
            string UserName = "freda";
            string Password = "password";
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE20AWLE200000000000";

            AllOK = AnCustomer.Valid(UserName, Password, ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            Assert.AreNotEqual(AllOK, "");
        }
    }
}