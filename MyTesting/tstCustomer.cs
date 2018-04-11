using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;
using System;

//Author Ayub Osman

namespace MyTesting
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create a new instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //test to see if it exists
            Assert.IsNotNull(AnCustomer);
        }
        [TestMethod]
        public void PostCodeExist()
        {
            //create a new instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data
            string PostCode = "LE5";
            AnCustomer.PostCode = PostCode;
            //test to see if it exists
            Assert.AreEqual(AnCustomer.PostCode, PostCode);
        }


        [TestMethod]
        public void DateExist()
        {
            //create a new instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer(); ;
            //create some test data
            DateTime Date = DateTime.Now.Date;
            AnCustomer.dateOfBirth = Date;
            //test to see if it exists
            Assert.AreEqual(AnCustomer.dateOfBirth, Date);

        }

        [TestMethod]
        public void ValidExist()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); ;
            //string variable to store result of validation
            string AllOK = "";
            //create some test data to assign to property
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";
            //invoke method
            AllOK = TestItem.Valid(ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            //test to see if it exists
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); ;
            //boolean variable to store the result of the validisation
            Boolean Found = false;
            //create some test data to use the method 
            Int32 CustomerID = 1;
            //Invoke the method
            Found = TestItem.Find(CustomerID);
            //test to see if it exists 
            Assert.IsTrue(Found);

        }

        [TestMethod]
        public void ForeNameExist()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); ;
            //create some test data
            string ForeName = "fred";
            TestItem.ForeName = ForeName;
            //test to see if it exists
            Assert.AreEqual(TestItem.ForeName, ForeName);

        }

        [TestMethod]
        public void SurnameExist()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); ;
            //create some test data
            string Surname = "bloggs";
            TestItem.Surname = Surname;
            //test to see if it exists
            Assert.AreEqual(TestItem.Surname, Surname);

        }

        [TestMethod]
        public void GenderExist()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); ;
            //create some test data
            string Gender = "male";
            TestItem.Gender = Gender;
            //test to see if it exists
            Assert.AreEqual(TestItem.Gender, Gender);

        }

        [TestMethod]
        public void ContactNumberExist()
        {
            //create a new instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data
            string ContactNumber = "01161234567";
            AnCustomer.ContactNumber = ContactNumber;
            //test to see if it exists
            Assert.AreEqual(AnCustomer.ContactNumber, ContactNumber);

        }

        [TestMethod]
        public void EMailExist()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); ;
            //create some test data
            string EMail = "me@me.com";
            TestItem.EMail = EMail;
            //test to see if it exists
            Assert.AreEqual(TestItem.EMail, EMail);

        }

        [TestMethod]
        public void FlatNoExist()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); ;
            //create some test data
            string FlatNo = "1";
            TestItem.FlatNo = FlatNo;
            //test to see if it exists
            Assert.AreEqual(TestItem.FlatNo, FlatNo);

        }

        [TestMethod]
        public void HouseNoExist()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); ;
            //create some test data
            string HouseNo = "2";
            TestItem.HouseNo = HouseNo;
            //test to see if it exists
            Assert.AreEqual(TestItem.HouseNo, HouseNo);

        }

        [TestMethod]
        public void ForenameMinMinus1()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); ;
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string ForeName = "";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";
            //invoke method
            AllOK = TestItem.Valid(ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            //test to see if result correct
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void ForenameBoundaryMin()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); ;
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string ForeName = "A";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";
            //invoke method
            AllOK = TestItem.Valid(ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            //test to see if result correct
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void ForenameBoundaryMinPlus1()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); ;
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string ForeName = "ab";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";
            //invoke method
            AllOK = TestItem.Valid(ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            //test to see if result correct
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void ForenameBoundaryMaxMinus1()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); ;
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string ForeName = "Abcdefhjklmnjhsaqwe";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";
            //invoke method
            AllOK = TestItem.Valid(ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            //test to see if result correct
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void ForenameBoundaryMaxBoundary()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); ;
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string ForeName = "Abcdefhjklmnjhsaqweh";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";
            //invoke method
            AllOK = TestItem.Valid(ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            //test to see if result correct
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void ForenameBoundaryMaxPlus1()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); ;
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
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
            //invoke method
            AllOK = TestItem.Valid(ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            //test to see if result correct
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void ForenameBoundaryMid()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); ;
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
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
            //invoke method
            AllOK = TestItem.Valid(ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            //test to see if result correct
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void ForenameExtremeMax()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); ;
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
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
            //invoke method
            AllOK = TestItem.Valid(ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            //test to see if result correct
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void SurnameMinMinus1()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); ;
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string ForeName = "fred";
            string Surname = "";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";
            //invoke method
            AllOK = TestItem.Valid(ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            //test to see if result correct
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void SurnameBoundaryMin()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); ;
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string ForeName = "fred";
            string Surname = "A";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";
            //invoke method
            AllOK = TestItem.Valid(ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            //test to see if result correct
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void SurnameBoundaryMinPlus1()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); ;
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string ForeName = "fred";
            string Surname = "JB";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";
            //invoke method
            AllOK = TestItem.Valid(ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            //test to see if result correct
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void SurnameBoundaryMaxMinus1()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); ;
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string ForeName = "fred";
            string Surname = "Abcdefhjklmnjhsaqweasasa";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";
            //invoke method
            AllOK = TestItem.Valid(ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            //test to see if result correct
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void SurnameBoundaryMaxBoundary()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); ;
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string ForeName = "fred";
            string Surname = "Abcdefhjklmnjhsaqweasasaa";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";
            //invoke method
            AllOK = TestItem.Valid(ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            //test to see if result correct
            Assert.AreEqual(AllOK, "");
        }


        [TestMethod]
        public void SurnameBoundaryMaxPlus1()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); ;
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string ForeName = "fred";
            string Surname = "Abcdefhjklmnjhsaqweasasaas";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";
            //invoke method
            AllOK = TestItem.Valid(ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            //test to see if result correct
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void SurnameBoundaryMid()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); ;
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string ForeName = "fred";
            string Surname = "Abcdefhjkasav";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";
            //invoke method
            AllOK = TestItem.Valid(ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            //test to see if result correct
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void SurnameExtremeMax()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); ;
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string ForeName = "fred";
            string Surname = "Abcdefhjklmnjhsaqweaabdfvdfgvc";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";
            //invoke method
            AllOK = TestItem.Valid(ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            //test to see if result correct
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void DateTestMinMinus1()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); ;
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string ForeName = "fred";
            string Surname = "Abcdefhc";
            string DateOfBirth = DateTime.Now.Date.AddYears(-17).AddDays(+364).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";
            //invoke method
            AllOK = TestItem.Valid(ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            //test to see if result correct
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void DateTestBoundryMin()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); ;
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string ForeName = "fred";
            string Surname = "Abcdefhc";
            string DateOfBirth = DateTime.Now.Date.AddYears(-18).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";
            //invoke method
            AllOK = TestItem.Valid(ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            //test to see if result correct
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void DateTestBoundryMinPlus1()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); ;
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string ForeName = "fred";
            string Surname = "Abcdefhc";
            string DateOfBirth = DateTime.Now.Date.AddYears(-18).AddDays(+1).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";
            //invoke method
            AllOK = TestItem.Valid(ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            //test to see if result correct
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void DateTestMaxMinus1()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); ;
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string ForeName = "fred";
            string Surname = "Abcdefhc";
            string DateOfBirth = DateTime.Now.Date.AddYears(-149).AddDays(+364).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";
            //invoke method
            AllOK = TestItem.Valid(ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            //test to see if result correct
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void DateTestMaxBoundary()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); ;
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string ForeName = "fred";
            string Surname = "Abcdefhc";
            string DateOfBirth = DateTime.Now.Date.AddYears(-150).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";
            //invoke method
            AllOK = TestItem.Valid(ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            //test to see if result correct
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void DateTestBoundryMaxPlus1()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); ;
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string ForeName = "fred";
            string Surname = "Abcdefhc";
            string DateOfBirth = DateTime.Now.Date.AddYears(-150).AddDays(+1).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";
            //invoke method
            AllOK = TestItem.Valid(ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            //test to see if result correct
            Assert.AreEqual(AllOK, "");

        }

        [TestMethod]
        public void DateTestBoundryMid()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); ;
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string ForeName = "fred";
            string Surname = "Abcdefhc";
            string DateOfBirth = DateTime.Now.Date.AddYears(-75).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";
            //invoke method
            AllOK = TestItem.Valid(ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            //test to see if result correct
            Assert.AreEqual(AllOK, "");

        }

        [TestMethod]
        public void DateTestInvalidData()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); ;
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string ForeName = "fred";
            string Surname = "Abcdefhc";
            string DateOfBirth = "123";
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";
            //invoke method
            AllOK = TestItem.Valid(ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            //test to see if result correct
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void GenderMinMinus1()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); ;
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";
            //invoke method
            AllOK = TestItem.Valid(ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            //test to see if result correct
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void GenderBoundaryMin()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); ;
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "F";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";
            //invoke method
            AllOK = TestItem.Valid(ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            //test to see if result correct
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void GenderBoundaryMinPlus1()
        {

            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); ;
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "Fe";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";
            //invoke method
            AllOK = TestItem.Valid(ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            //test to see if result correct
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void GenderBoundaryMaxMinus1()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); ;
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "Femal";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";
            //invoke method
            AllOK = TestItem.Valid(ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            //test to see if result correct
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void GenderBoundaryMax()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); ;
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "Female";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";
            //invoke method
            AllOK = TestItem.Valid(ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            //test to see if result correct
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void GenderBoundaryMaxPlus1()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); ;
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "Females";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";
            //invoke method
            AllOK = TestItem.Valid(ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            //test to see if result correct
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void GenderBoundaryMid()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); ;
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "Fem";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";
            //invoke method
            AllOK = TestItem.Valid(ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            //test to see if result correct
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void GenderExtremeMax()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); ;
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "ABCDEFEJNKGFNGKGMGKG";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";
            //invoke method
            AllOK = TestItem.Valid(ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            //test to see if result correct
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void ContactNumberExtremeMin()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); ;
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";
            //invoke method
            AllOK = TestItem.Valid(ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            //test to see if result correct
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void ContactNumberBoundaryMinMinus1()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); ;
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "12";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";
            //invoke method
            AllOK = TestItem.Valid(ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            //test to see if result correct
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void ContactNumberBoundaryMin()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); ;
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "123";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";
            //invoke method
            AllOK = TestItem.Valid(ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            //test to see if result correct
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void ContactNumberBoundaryMinPlus1()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); ;
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "1234";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";
            //invoke method
            AllOK = TestItem.Valid(ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            //test to see if result correct
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void ContactNumberBoundaryMaxMinus1()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); ;
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "1234567890";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";
            //invoke method
            AllOK = TestItem.Valid(ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            //test to see if result correct
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void ContactNumberBoundaryMax()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); ;
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "12345678901";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";
            //invoke method
            AllOK = TestItem.Valid(ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            //test to see if result correct
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void ContactNumberBoundaryMaxPlus1()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); ;
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "123456789010";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";
            //invoke method
            AllOK = TestItem.Valid(ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            //test to see if result correct
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void ContactNumberBoundaryMid()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); ;
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "123456";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";
            //invoke method
            AllOK = TestItem.Valid(ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            //test to see if result correct
            Assert.AreEqual(AllOK, "");
        }


        [TestMethod]
        public void ContactNumberExtremeMax()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); ;
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "12345612345612345600";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";
            //invoke method
            AllOK = TestItem.Valid(ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            //test to see if result correct
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void EmailExtremeMin()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); ;
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";
            //invoke method
            AllOK = TestItem.Valid(ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            //test to see if result correct
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void EmailBoundaryMinMinus1()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); ;
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "12345";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";
            //invoke method
            AllOK = TestItem.Valid(ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            //test to see if result correct
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void EmailBoundaryMin()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); ;
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "123456";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";
            //invoke method
            AllOK = TestItem.Valid(ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            //test to see if result correct
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void EmailBoundaryMinPlus1()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); ;
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "1234567";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";
            //invoke method
            AllOK = TestItem.Valid(ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            //test to see if result correct
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void EmailBoundaryMaxMinus1()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); ;
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "Samsung1234567@Samsung1234567";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";
            //invoke method
            AllOK = TestItem.Valid(ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            //test to see if result correct
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void EmailBoundaryMax()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); ;
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "Samsung1234567@Samsung12345671";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";
            //invoke method
            AllOK = TestItem.Valid(ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            //test to see if result correct
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void EmailBoundaryMaxPlus1()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); ;
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "Samsung1234567@Samsung123456711";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";
            //invoke method
            AllOK = TestItem.Valid(ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            //test to see if result correct
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void EmailBoundaryMid()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); ;
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "Samsun@.co.uk";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";
            //invoke method
            AllOK = TestItem.Valid(ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            //test to see if result correct
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void EmailExtremeMax()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); ;
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "Samsung1234567@Samsung123456712345678951";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";
            //invoke method
            AllOK = TestItem.Valid(ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            //test to see if result correct
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void FlatNoBoundaryMinMinus1()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); ;
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";
            //invoke method
            AllOK = TestItem.Valid(ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            //test to see if result correct
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void FlatNoBoundaryMin()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); ;
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "6";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";
            //invoke method
            AllOK = TestItem.Valid(ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            //test to see if result correct
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void FlatNoBoundaryMinPlus1()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); ;
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "62";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";
            //invoke method
            AllOK = TestItem.Valid(ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            //test to see if result correct
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void FlatNoBoundaryMaxMinus1()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); ;
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "10000";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";
            //invoke method
            AllOK = TestItem.Valid(ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            //test to see if result correct
            Assert.AreEqual(AllOK, "");
        }


        [TestMethod]
        public void FlatNoBoundaryMax()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); ;
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "100000";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";
            //invoke method
            AllOK = TestItem.Valid(ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            //test to see if result correct
            Assert.AreEqual(AllOK, "");
        }


        [TestMethod]
        public void FlatNoBoundaryMaxPlus1()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); ;
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1000001";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";
            //invoke method
            AllOK = TestItem.Valid(ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            //test to see if result correct
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void FlatNoBoundaryMid()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); ;
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "100";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";
            //invoke method
            AllOK = TestItem.Valid(ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            //test to see if result correct
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void FlatNoExtremeMax()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); ;
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "10000000000000000000";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";
            //invoke method
            AllOK = TestItem.Valid(ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            //test to see if result correct
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void HouseNoBoundaryMinMinus1()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); ;
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "";
            string PostCode = "LE5 6HP";
            //invoke method
            AllOK = TestItem.Valid(ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            //test to see if result correct
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void HouseNoBoundaryMin()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); ;
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "6";
            string PostCode = "LE5 6HP";
            //invoke method
            AllOK = TestItem.Valid(ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            //test to see if result correct
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void HouseNoBoundaryMinPlus1()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); ;
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "62";
            string PostCode = "LE5 6HP";
            //invoke method
            AllOK = TestItem.Valid(ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            //test to see if result correct
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void HouseNoBoundaryMaxMinus1()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); ;
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "10000";
            string PostCode = "LE5 6HP";
            //invoke method
            AllOK = TestItem.Valid(ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            //test to see if result correct
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void HouseNoBoundaryMax()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); ;
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "100000";
            string PostCode = "LE5 6HP";
            //invoke method
            AllOK = TestItem.Valid(ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            //test to see if result correct
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void HouseNoBoundaryMaxPlus1()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); ;
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "1000001";
            string PostCode = "LE5 6HP";
            //invoke method
            AllOK = TestItem.Valid(ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            //test to see if result correct
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void HouseNoBoundaryMid()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); ;
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "100";
            string PostCode = "LE5 6HP";
            //invoke method
            AllOK = TestItem.Valid(ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            //test to see if result correct
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void HouseNoExtremeMax()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); ;
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "10000000000000000000";
            string PostCode = "LE5 6HP";
            //invoke method
            AllOK = TestItem.Valid(ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            //test to see if result correct
            Assert.AreNotEqual(AllOK, "");

        }

        [TestMethod]
        public void PostCodeExtremeMin()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); ;
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "";
            //invoke method
            AllOK = TestItem.Valid(ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            //test to see if result correct
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void PostCodeBoundaryMinMinus1()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); ;
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE11";
            //invoke method
            AllOK = TestItem.Valid(ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            //test to see if result correct
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void PostCodeBoundaryMin()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); ;
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE212";
            //invoke method
            AllOK = TestItem.Valid(ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            //test to see if result correct
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void PostCodeBoundaryMinPlus1()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); ;
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE2122";
            //invoke method
            AllOK = TestItem.Valid(ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            //test to see if result correct
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void PostCodeBoundaryMaxMinus1()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); ;
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE212232";
            //invoke method
            AllOK = TestItem.Valid(ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            //test to see if result correct
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void PostCodeBoundaryMax()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); ;
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE2122321";
            //invoke method
            AllOK = TestItem.Valid(ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            //test to see if result correct
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void PostCodeBoundaryMaxPlus1()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); ;
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE21223211";
            //invoke method
            AllOK = TestItem.Valid(ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            //test to see if result correct
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void PostCodeBoundaryMid()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); ;
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE221369";
            //invoke method
            AllOK = TestItem.Valid(ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            //test to see if result correct
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void PostCodeExtremeMax()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); ;
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string ForeName = "fred";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE20AWLE200000000000";
            //invoke method
            AllOK = TestItem.Valid(ForeName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            //test to see if result correct
            Assert.AreNotEqual(AllOK, "");
        }

        ///Testing Find Method///
        [TestMethod]
        public void TestcustIDFound()
        {
            //create a new instance of the class we want to create
            clsCustomer AC = new clsCustomer();
            //string variable to store result of validation
            Boolean Found = false;
            //create some test data to assign to property
            Int32 CustomerID = 1;
            //invoke method
            Found = AC.Find(CustomerID);
            //check the Customer ID
            if (AC.CustomerID != 1)
            {
                Found = false;
            }
            //test to see if it exists
            Assert.IsTrue(Found);
        }

        ///Testing Find Method///
        [TestMethod]
        public void TestSurnameFound()
        {
            //create a new instance of the class we want to create
            clsCustomer AC = new clsCustomer();
            //string variable to store result of validation
            Boolean Found = false;
            //create some test data to assign to property
            Int32 CustomerID = 1;
            //invoke method
            Found = AC.Find(CustomerID);
            //check the Customer ID
            if (AC.Surname != "osman")
            {
                Found = false;
            }
            //test to see if it exists
            Assert.IsTrue(Found);
        }

        ///Testing Find Method///
        [TestMethod]
        public void TestForenameFound()
        {
            //create a new instance of the class we want to create
            clsCustomer AC = new clsCustomer();
            //string variable to store result of validation
            Boolean Found = false;
            //create some test data to assign to property
            Int32 CustomerID = 1;
            //invoke method
            Found = AC.Find(CustomerID);
            //check the Customer ID
            if (AC.ForeName != "ayub")
            {
                Found = false;
            }
            //test to see if it exists
            Assert.IsTrue(Found);
        }

        ///Testing Find Method///
        [TestMethod]
        public void TestdateOfBirthFound()
        {
            //create a new instance of the class we want to create
            clsCustomer AC = new clsCustomer();
            //string variable to store result of validation
            Boolean Found = false;
            //create some test data to assign to property
            Int32 CustomerID = 1;
            //invoke method
            Found = AC.Find(CustomerID);
            //check the Customer ID
            if (AC.dateOfBirth != Convert.ToDateTime("19/09/1996"))
            {
                Found = false;
            }
            //test to see if it exists
            Assert.IsTrue(Found);
        }

        ///Testing Find Method///
        [TestMethod]
        public void TestPostCodeFound()
        {
            //create a new instance of the class we want to create
            clsCustomer AC = new clsCustomer();
            //string variable to store result of validation
            Boolean Found = false;
            //create some test data to assign to property
            Int32 CustomerID = 1;
            //invoke method
            Found = AC.Find(CustomerID);
            //check the Customer ID
            if (AC.PostCode != "LE2 5LP")
            {
                Found = false;
            }
            //test to see if it exists
            Assert.IsTrue(Found);
        }

        ///Testing Find Method///
        [TestMethod]
        public void TestEMailFound()
        {
            //create a new instance of the class we want to create
            clsCustomer AC = new clsCustomer();
            //string variable to store result of validation
            Boolean Found = false;
            //create some test data to assign to property
            Int32 CustomerID = 1;
            //invoke method
            Found = AC.Find(CustomerID);
            //check the Customer ID
            if (AC.EMail != "a@de.com")
            {
                Found = false;
            }
            //test to see if it exists
            Assert.IsTrue(Found);
        }

        ///Testing Find Method///
        [TestMethod]
        public void TestHouseNoFound()
        {
            //create a new instance of the class we want to create
            clsCustomer AC = new clsCustomer();
            //string variable to store result of validation
            Boolean Found = false;
            //create some test data to assign to property
            Int32 CustomerID = 1;
            //invoke method
            Found = AC.Find(CustomerID);
            //check the Customer ID
            if (AC.HouseNo != "71")
            {
                Found = false;
            }
            //test to see if it exists
            Assert.IsTrue(Found);
        }

        ///Testing Find Method///
        [TestMethod]
        public void TestFlatNoFound()
        {
            //create a new instance of the class we want to create
            clsCustomer AC = new clsCustomer();
            //string variable to store result of validation
            Boolean Found = false;
            //create some test data to assign to property
            Int32 CustomerID = 1;
            //invoke method
            Found = AC.Find(CustomerID);
            //check the Customer ID
            if (AC.FlatNo != "0")
            {
                Found = false;
            }
            //test to see if it exists
            Assert.IsTrue(Found);
        }

        ///Testing Find Method///
        [TestMethod]
        public void TestContactNumberFound()
        {
            //create a new instance of the class we want to create
            clsCustomer AC = new clsCustomer();
            //string variable to store result of validation
            Boolean Found = false;
            //create some test data to assign to property
            Int32 CustomerID = 1;
            //invoke method
            Found = AC.Find(CustomerID);
            //check the Customer ID
            if (AC.ContactNumber != "01162156")
            {
                Found = false;
            }
            //test to see if it exists
            Assert.IsTrue(Found);
        }
    }
}