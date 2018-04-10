using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;

namespace MyTesting
{
    [TestClass]
    public class tstEmployee
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create a new instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //test to see if it exists
            Assert.IsNotNull(AnEmployee);
        }

        [TestMethod]
        public void EmployeeAddressOK()
        {
            //create instance of class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //create some test data to assign to the property
            string TestData = "Some Address";
            //assign the data to the property
            AnEmployee.Address = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnEmployee.Address, TestData);
        }

        [TestMethod]
        public void EmployeeContactNumberOK()
        {
            //create instance of class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //create some test data to assign to the property
            string TestData = "07777777777";
            //assign the data to the property
            AnEmployee.EmployeeContactNumber = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnEmployee.EmployeeContactNumber, TestData);
        }


        [TestMethod]
        public void EmployeeEmail()
        {
            //create instance of class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //create some test data to assign to the property
            string TestData = "ddddd@hotmail.com";
            //assign the data to the property
            AnEmployee.EmployeeEmail = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnEmployee.EmployeeEmail, TestData);
        }

        [TestMethod]
        public void EmployeeName()
        {
            //create instance of class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //create some test data to assign to the property
            string TestData = "Vinay";
            //assign the data to the property
            AnEmployee.EmployeeName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnEmployee.EmployeeName, TestData);


        }

        [TestMethod]
        public void EmployeeRole()
        {
            //create instance of class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //create some test data to assign to the property
            string TestData = "Accountant";
            //assign the data to the property
            AnEmployee.EmployeeRole = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnEmployee.EmployeeRole, TestData);
        }

        [TestMethod]
        public void EmployeeDOB()
        {
            //create instance of class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnEmployee.EmployeeDOB = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnEmployee.EmployeeDOB, TestData);
        }

        [TestMethod]
        public void EmployeeJoinDate()
        {
            //create instance of class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnEmployee.EmployeeJoinDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnEmployee.EmployeeJoinDate, TestData);
        }

        [TestMethod]
        public void EmployeeSalary()
        {
            //create instance of class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //create some test data to assign to the property
            string TestData = "18000";
            //assign the data to the property
            AnEmployee.EmployeeSalary = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnEmployee.EmployeeSalary, TestData);
        }

        [TestMethod]
        public void ValidExist()
        {
            //create a new instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string EmployeeAddress = "Some Address";
            string EmployeeContactNumber = "076666666661";
            string EmployeeDOB = DateTime.Now.Date.AddYears(-19).ToString();
            string EmployeeEmail = "ddddd@hotmail.com";
            string EmployeeJoinDate = DateTime.Now.Date.ToString();
            string EmployeeName = "Vinay";
            string EmployeeRole = "Accountant";
            string EmployeeSalary = "1800";
            //invoke method
            OK = AnEmployee.Valid(EmployeeAddress, EmployeeContactNumber, EmployeeDOB, EmployeeEmail, EmployeeJoinDate, EmployeeName, EmployeeRole, EmployeeSalary);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void AddressMinLessOne()
        {
            //create a new instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string EmployeeAddress = "";
            string EmployeeContactNumber = "07666666666";
            string EmployeeDOB = DateTime.Now.Date.ToString();
            string EmployeeEmail = "ddddd@hotmail.com";
            string EmployeeJoinDate = DateTime.Now.Date.ToString();
            string EmployeeName = "Vinay";
            string EmployeeRole = "Accountant";
            string EmployeeSalary = "1800";
            //invoke method
            OK = AnEmployee.Valid(EmployeeAddress, EmployeeContactNumber, EmployeeDOB, EmployeeEmail, EmployeeJoinDate, EmployeeName, EmployeeRole, EmployeeSalary);
            //test to see if it exists
            Assert.AreNotEqual(OK, "");
        }

        [TestMethod]
        public void AddressMinBoundary()
        {
            //create a new instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string EmployeeAddress = "f";
            string EmployeeContactNumber = "076666666661";
            string EmployeeDOB = DateTime.Now.Date.AddYears(-19).ToString();
            string EmployeeEmail = "ddddd@hotmail.com";
            string EmployeeJoinDate = DateTime.Now.Date.ToString();
            string EmployeeName = "Vinay";
            string EmployeeRole = "Accountant";
            string EmployeeSalary = "1800";
            //invoke method
            OK = AnEmployee.Valid(EmployeeAddress, EmployeeContactNumber, EmployeeDOB, EmployeeEmail, EmployeeJoinDate, EmployeeName, EmployeeRole, EmployeeSalary);
            //test to see if it exists
            Assert.AreEqual(OK, "");

        }

        [TestMethod]
        public void AddressMinPlusOne()
        {
            //create a new instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string EmployeeAddress = "ff";
            string EmployeeContactNumber = "076666666661";
            string EmployeeDOB = DateTime.Now.Date.AddYears(-19).ToString();
            string EmployeeEmail = "ddddd@hotmail.com";
            string EmployeeJoinDate = DateTime.Now.Date.ToString();
            string EmployeeName = "Vinay";
            string EmployeeRole = "Accountant";
            string EmployeeSalary = "1800";
            //invoke method
            OK = AnEmployee.Valid(EmployeeAddress, EmployeeContactNumber, EmployeeDOB, EmployeeEmail, EmployeeJoinDate, EmployeeName, EmployeeRole, EmployeeSalary);
            //test to see if it exists
            Assert.AreEqual(OK, "");

        }

        [TestMethod]
        public void AddressMaxMinusOne()
        {
            //create a new instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string EmployeeAddress = "";
            EmployeeAddress = EmployeeAddress.PadRight(29, 'a');
            string EmployeeContactNumber = "076666666661";
            string EmployeeDOB = DateTime.Now.Date.AddYears(-19).ToString();
            string EmployeeEmail = "ddddd@hotmail.com";
            string EmployeeJoinDate = DateTime.Now.Date.ToString();
            string EmployeeName = "Vinay";
            string EmployeeRole = "Accountant";
            string EmployeeSalary = "1800";
            //invoke method
            OK = AnEmployee.Valid(EmployeeAddress, EmployeeContactNumber, EmployeeDOB, EmployeeEmail, EmployeeJoinDate, EmployeeName, EmployeeRole, EmployeeSalary);
            //test to see if it exists
            Assert.AreEqual(OK, "");

        }

        [TestMethod]
        public void AddressMaxBoundary()
        {
            //create a new instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string EmployeeAddress = "";
            EmployeeAddress = EmployeeAddress.PadRight(30, 'a');
            string EmployeeContactNumber = "076666666661";
            string EmployeeDOB = DateTime.Now.Date.AddYears(-19).ToString();
            string EmployeeEmail = "ddddd@hotmail.com";
            string EmployeeJoinDate = DateTime.Now.Date.ToString();
            string EmployeeName = "Vinay";
            string EmployeeRole = "Accountant";
            string EmployeeSalary = "1800";
            //invoke method
            OK = AnEmployee.Valid(EmployeeAddress, EmployeeContactNumber, EmployeeDOB, EmployeeEmail, EmployeeJoinDate, EmployeeName, EmployeeRole, EmployeeSalary);
            //test to see if it exists
            Assert.AreEqual(OK, "");

        }

        [TestMethod]
        public void AddressMaxPlusOne()
        {
            //create a new instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string EmployeeAddress = "";
            EmployeeAddress = EmployeeAddress.PadRight(31, 'a');
            string EmployeeContactNumber = "07666666666";
            string EmployeeDOB = DateTime.Now.Date.ToString();
            string EmployeeEmail = "ddddd@hotmail.com";
            string EmployeeJoinDate = DateTime.Now.Date.ToString();
            string EmployeeName = "Vinay";
            string EmployeeRole = "Accountant";
            string EmployeeSalary = "1800";
            //invoke method
            OK = AnEmployee.Valid(EmployeeAddress, EmployeeContactNumber, EmployeeDOB, EmployeeEmail, EmployeeJoinDate, EmployeeName, EmployeeRole, EmployeeSalary);
            //test to see if it exists
            Assert.AreNotEqual(OK, "");
        }

        [TestMethod]
        public void AddressMid()
        {
            //create a new instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string EmployeeAddress = "";
            EmployeeAddress = EmployeeAddress.PadRight(15, 'a');
            string EmployeeContactNumber = "076666666661";
            string EmployeeDOB = DateTime.Now.Date.AddYears(-19).ToString();
            string EmployeeEmail = "ddddd@hotmail.com";
            string EmployeeJoinDate = DateTime.Now.Date.ToString();
            string EmployeeName = "Vinay";
            string EmployeeRole = "Accountant";
            string EmployeeSalary = "1800";
            //invoke method
            OK = AnEmployee.Valid(EmployeeAddress, EmployeeContactNumber, EmployeeDOB, EmployeeEmail, EmployeeJoinDate, EmployeeName, EmployeeRole, EmployeeSalary);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void AddressExtremeMax()
        {
            //create a new instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string EmployeeAddress = "";
            EmployeeAddress = EmployeeAddress.PadRight(90, 'a');
            string EmployeeContactNumber = "07666666666";
            string EmployeeDOB = DateTime.Now.Date.ToString();
            string EmployeeEmail = "ddddd@hotmail.com";
            string EmployeeJoinDate = DateTime.Now.Date.ToString();
            string EmployeeName = "Vinay";
            string EmployeeRole = "Accountant";
            string EmployeeSalary = "1800";
            //invoke method
            OK = AnEmployee.Valid(EmployeeAddress, EmployeeContactNumber, EmployeeDOB, EmployeeEmail, EmployeeJoinDate, EmployeeName, EmployeeRole, EmployeeSalary);
            //test to see if it exists
            Assert.AreNotEqual(OK, "");
        }

        [TestMethod]
        public void ContactNumberExtremeMin()
        {
            //create a new instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string EmployeeAddress = "dddd";
            string EmployeeContactNumber = "";
            string EmployeeDOB = DateTime.Now.Date.ToString();
            string EmployeeEmail = "ddddd@hotmail.com";
            string EmployeeJoinDate = DateTime.Now.Date.ToString();
            string EmployeeName = "Vinay";
            string EmployeeRole = "Accountant";
            string EmployeeSalary = "1800";
            //invoke method
            OK = AnEmployee.Valid(EmployeeAddress, EmployeeContactNumber, EmployeeDOB, EmployeeEmail, EmployeeJoinDate, EmployeeName, EmployeeRole, EmployeeSalary);
            //test to see if it exists
            Assert.AreNotEqual(OK, "");
        }

        [TestMethod]
        public void ContactNumberMinMinusOne()
        {
            //create a new instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string EmployeeAddress = "dddd";
            string EmployeeContactNumber = "3333333333";
            string EmployeeDOB = DateTime.Now.Date.ToString();
            string EmployeeEmail = "ddddd@hotmail.com";
            string EmployeeJoinDate = DateTime.Now.Date.ToString();
            string EmployeeName = "Vinay";
            string EmployeeRole = "Accountant";
            string EmployeeSalary = "1800";
            //invoke method
            OK = AnEmployee.Valid(EmployeeAddress, EmployeeContactNumber, EmployeeDOB, EmployeeEmail, EmployeeJoinDate, EmployeeName, EmployeeRole, EmployeeSalary);
            //test to see if it exists
            Assert.AreNotEqual(OK, "");
        }

        [TestMethod]
        public void ContactNumberMinBoundary()
        {
            //create a new instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string EmployeeAddress = "dddd";
            string EmployeeContactNumber = "07666666666";
            string EmployeeDOB = DateTime.Now.Date.AddYears(-19).ToString();
            string EmployeeEmail = "ddddd@hotmail.com";
            string EmployeeJoinDate = DateTime.Now.Date.ToString();
            string EmployeeName = "Vinay";
            string EmployeeRole = "Accountant";
            string EmployeeSalary = "1800";
            //invoke method
            OK = AnEmployee.Valid(EmployeeAddress, EmployeeContactNumber, EmployeeDOB, EmployeeEmail, EmployeeJoinDate, EmployeeName, EmployeeRole, EmployeeSalary);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void ContactNumberMinPlusOne()
        {
            //create a new instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string EmployeeAddress = "dddd";
            string EmployeeContactNumber = "333333333333";
            string EmployeeDOB = DateTime.Now.Date.AddYears(-19).ToString();
            string EmployeeEmail = "ddddd@hotmail.com";
            string EmployeeJoinDate = DateTime.Now.Date.ToString();
            string EmployeeName = "Vinay";
            string EmployeeRole = "Accountant";
            string EmployeeSalary = "1800";
            //invoke method
            OK = AnEmployee.Valid(EmployeeAddress, EmployeeContactNumber, EmployeeDOB, EmployeeEmail, EmployeeJoinDate, EmployeeName, EmployeeRole, EmployeeSalary);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void ContactNumberMaxPlusOne()
        {
            //create a new instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string EmployeeAddress = "dddd";
            string EmployeeContactNumber = "233333333333";
            string EmployeeDOB = DateTime.Now.Date.AddYears(-19).ToString();
            string EmployeeEmail = "ddddd@hotmail.com";
            string EmployeeJoinDate = DateTime.Now.Date.ToString();
            string EmployeeName = "Vinay";
            string EmployeeRole = "Accountant";
            string EmployeeSalary = "1800";
            //invoke method
            OK = AnEmployee.Valid(EmployeeAddress, EmployeeContactNumber, EmployeeDOB, EmployeeEmail, EmployeeJoinDate, EmployeeName, EmployeeRole, EmployeeSalary);
            //test to see if it exists
            Assert.AreEqual(OK, "");

        }

        [TestMethod]
        public void ContactNumberMaxMinusOne()
        {
            //create a new instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string EmployeeAddress = "dddd";
            string EmployeeContactNumber = "2222222222222";
            string EmployeeDOB = DateTime.Now.Date.AddYears(-19).ToString();
            string EmployeeEmail = "ddddd@hotmail.com";
            string EmployeeJoinDate = DateTime.Now.Date.ToString();
            string EmployeeName = "Vinay";
            string EmployeeRole = "Accountant";
            string EmployeeSalary = "1800";
            //invoke method
            OK = AnEmployee.Valid(EmployeeAddress, EmployeeContactNumber, EmployeeDOB, EmployeeEmail, EmployeeJoinDate, EmployeeName, EmployeeRole, EmployeeSalary);
            //test to see if it exists
            Assert.AreEqual(OK, "");

        }

        [TestMethod]
        public void ContactNumberMaxBoundary()
        {
            //create a new instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string EmployeeAddress = "dddd";
            string EmployeeContactNumber = "22222222222222";
            string EmployeeDOB = DateTime.Now.Date.AddYears(-19).ToString();
            string EmployeeEmail = "ddddd@hotmail.com";
            string EmployeeJoinDate = DateTime.Now.Date.ToString();
            string EmployeeName = "Vinay";
            string EmployeeRole = "Accountant";
            string EmployeeSalary = "1800";
            //invoke method
            OK = AnEmployee.Valid(EmployeeAddress, EmployeeContactNumber, EmployeeDOB, EmployeeEmail, EmployeeJoinDate, EmployeeName, EmployeeRole, EmployeeSalary);
            //test to see if it exists
            Assert.AreEqual(OK, "");

        }

        [TestMethod]
        public void ContactNumberMaxBoundaryPlusOne()
        {
            //create a new instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string EmployeeAddress = "dddd";
            string EmployeeContactNumber = "076666666661";
            string EmployeeDOB = DateTime.Now.Date.AddYears(-19).ToString();
            string EmployeeEmail = "ddddd@hotmail.com";
            string EmployeeJoinDate = DateTime.Now.Date.ToString();
            string EmployeeName = "Vinay";
            string EmployeeRole = "Accountant";
            string EmployeeSalary = "1800";
            //invoke method
            OK = AnEmployee.Valid(EmployeeAddress, EmployeeContactNumber, EmployeeDOB, EmployeeEmail, EmployeeJoinDate, EmployeeName, EmployeeRole, EmployeeSalary);
            //test to see if it exists
            Assert.AreEqual(OK, "");

        }

        [TestMethod]
        public void ContactNumberMid()
        {
            //create a new instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string EmployeeAddress = "dddd";
            string EmployeeContactNumber = "33333333";
            string EmployeeDOB = DateTime.Now.Date.ToString();
            string EmployeeEmail = "ddddd@hotmail.com";
            string EmployeeJoinDate = DateTime.Now.Date.ToString();
            string EmployeeName = "Vinay";
            string EmployeeRole = "Accountant";
            string EmployeeSalary = "1800";
            //invoke method
            OK = AnEmployee.Valid(EmployeeAddress, EmployeeContactNumber, EmployeeDOB, EmployeeEmail, EmployeeJoinDate, EmployeeName, EmployeeRole, EmployeeSalary);
            //test to see if it exists
            Assert.AreNotEqual(OK, "");

        }

        [TestMethod]
        public void EmployeeEmailExtremeMin()
        {
            //create a new instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string EmployeeAddress = "ffffff";
            string EmployeeContactNumber = "07666666666";
            string EmployeeDOB = DateTime.Now.Date.ToString();
            string EmployeeEmail = "";
            string EmployeeJoinDate = DateTime.Now.Date.ToString();
            string EmployeeName = "Vinay";
            string EmployeeRole = "Accountant";
            string EmployeeSalary = "1800";
            //invoke method
            OK = AnEmployee.Valid(EmployeeAddress, EmployeeContactNumber, EmployeeDOB, EmployeeEmail, EmployeeJoinDate, EmployeeName, EmployeeRole, EmployeeSalary);
            //test to see if it exists
            Assert.AreNotEqual(OK, "");
        }

        [TestMethod]
        public void EmployeeEmailMinMinusOne()
        {
            //create a new instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string EmployeeAddress = "ffffff";
            string EmployeeContactNumber = "07666666666";
            string EmployeeDOB = DateTime.Now.Date.ToString();
            string EmployeeEmail = "fff";
            string EmployeeJoinDate = DateTime.Now.Date.ToString();
            string EmployeeName = "Vinay";
            string EmployeeRole = "Accountant";
            string EmployeeSalary = "1800";
            //invoke method
            OK = AnEmployee.Valid(EmployeeAddress, EmployeeContactNumber, EmployeeDOB, EmployeeEmail, EmployeeJoinDate, EmployeeName, EmployeeRole, EmployeeSalary);
            //test to see if it exists
            Assert.AreNotEqual(OK, "");
        }

        [TestMethod]
        public void EmployeeEmailMinBoundary()
        {
            //create a new instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string EmployeeAddress = "ffffff";
            string EmployeeContactNumber = "07666666666";
            string EmployeeDOB = DateTime.Now.Date.AddYears(-19).ToString();
            string EmployeeEmail = "fffff";
            string EmployeeJoinDate = DateTime.Now.Date.ToString();
            string EmployeeName = "Vinay";
            string EmployeeRole = "Accountant";
            string EmployeeSalary = "1800";
            //invoke method
            OK = AnEmployee.Valid(EmployeeAddress, EmployeeContactNumber, EmployeeDOB, EmployeeEmail, EmployeeJoinDate, EmployeeName, EmployeeRole, EmployeeSalary);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void EmployeeEmailMinPlusOne()
        {
            //create a new instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string EmployeeAddress = "ffffff";
            string EmployeeContactNumber = "07666666666";
            string EmployeeDOB = DateTime.Now.Date.AddYears(-19).ToString();
            string EmployeeEmail = "ffffff";
            string EmployeeJoinDate = DateTime.Now.Date.ToString();
            string EmployeeName = "Vinay";
            string EmployeeRole = "Accountant";
            string EmployeeSalary = "1800";
            //invoke method
            OK = AnEmployee.Valid(EmployeeAddress, EmployeeContactNumber, EmployeeDOB, EmployeeEmail, EmployeeJoinDate, EmployeeName, EmployeeRole, EmployeeSalary);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void EmployeeEmailMaxMinusOne()
        {
            //create a new instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string EmployeeAddress = "ffffff";
            string EmployeeContactNumber = "07666666666";
            string EmployeeDOB = DateTime.Now.Date.AddYears(-19).ToString();
            string EmployeeEmail = "";
            EmployeeEmail = EmployeeEmail.PadRight(25, 'a');
            string EmployeeJoinDate = DateTime.Now.Date.ToString();
            string EmployeeName = "Vinay";
            string EmployeeRole = "Accountant";
            string EmployeeSalary = "1800";
            //invoke method
            OK = AnEmployee.Valid(EmployeeAddress, EmployeeContactNumber, EmployeeDOB, EmployeeEmail, EmployeeJoinDate, EmployeeName, EmployeeRole, EmployeeSalary);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void EmployeeEmailMaxBoundary()
        {
            //create a new instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string EmployeeAddress = "ffffff";
            string EmployeeContactNumber = "07666666666";
            string EmployeeDOB = DateTime.Now.Date.AddYears(-19).ToString();
            string EmployeeEmail = "";
            EmployeeEmail = EmployeeEmail.PadRight(26, 'a');
            string EmployeeJoinDate = DateTime.Now.Date.ToString();
            string EmployeeName = "Vinay";
            string EmployeeRole = "Accountant";
            string EmployeeSalary = "1800";
            //invoke method
            OK = AnEmployee.Valid(EmployeeAddress, EmployeeContactNumber, EmployeeDOB, EmployeeEmail, EmployeeJoinDate, EmployeeName, EmployeeRole, EmployeeSalary);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void EmployeeEmailMaxPlusOne()
        {
            //create a new instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string EmployeeAddress = "ffffff";
            string EmployeeContactNumber = "07666666666";
            string EmployeeDOB = DateTime.Now.Date.ToString();
            string EmployeeEmail = "";
            EmployeeEmail = EmployeeEmail.PadRight(28, 'a');
            string EmployeeJoinDate = DateTime.Now.Date.ToString();
            string EmployeeName = "Vinay";
            string EmployeeRole = "Accountant";
            string EmployeeSalary = "1800";
            //invoke method
            OK = AnEmployee.Valid(EmployeeAddress, EmployeeContactNumber, EmployeeDOB, EmployeeEmail, EmployeeJoinDate, EmployeeName, EmployeeRole, EmployeeSalary);
            //test to see if it exists
            Assert.AreNotEqual(OK, "");
        }

        [TestMethod]
        public void EmployeeEmailMid()
        {
            //create a new instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string EmployeeAddress = "ffffff";
            string EmployeeContactNumber = "07666666666";
            string EmployeeDOB = DateTime.Now.Date.AddYears(-19).ToString();
            string EmployeeEmail = "";
            EmployeeEmail = EmployeeEmail.PadRight(13, 'a');
            string EmployeeJoinDate = DateTime.Now.Date.ToString();
            string EmployeeName = "Vinay";
            string EmployeeRole = "Accountant";
            string EmployeeSalary = "1800";
            //invoke method
            OK = AnEmployee.Valid(EmployeeAddress, EmployeeContactNumber, EmployeeDOB, EmployeeEmail, EmployeeJoinDate, EmployeeName, EmployeeRole, EmployeeSalary);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void EmployeeEmailExMax()
        {
            //create a new instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string EmployeeAddress = "ffffff";
            string EmployeeContactNumber = "07666666666";
            string EmployeeDOB = DateTime.Now.Date.ToString();
            string EmployeeEmail = "";
            EmployeeEmail = EmployeeEmail.PadRight(60, 'a');
            string EmployeeJoinDate = DateTime.Now.Date.ToString();
            string EmployeeName = "Vinay";
            string EmployeeRole = "Accountant";
            string EmployeeSalary = "1800";
            //invoke method
            OK = AnEmployee.Valid(EmployeeAddress, EmployeeContactNumber, EmployeeDOB, EmployeeEmail, EmployeeJoinDate, EmployeeName, EmployeeRole, EmployeeSalary);
            //test to see if it exists
            Assert.AreNotEqual(OK, "");
        }

        [TestMethod]
        public void EmployeeDOBMinMinusOne()
        {
            //create a new instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string EmployeeAddress = "ffffff";
            string EmployeeContactNumber = "07666666666";
            //create variable to store the data
            DateTime SomeDate;
            //set date to todays date
            SomeDate = DateTime.Now.Date;
            //change date to -17 years & -364 days
            SomeDate = SomeDate.AddYears(-17).AddDays(-364);
            string EmployeeDOB = SomeDate.ToString();
            string EmployeeEmail = "";
            EmployeeEmail.PadRight(12, 'a');
            string EmployeeJoinDate = DateTime.Now.Date.ToString();
            string EmployeeName = "Vinay";
            string EmployeeRole = "Accountant";
            string EmployeeSalary = "1800";
            //invoke method
            OK = AnEmployee.Valid(EmployeeAddress, EmployeeContactNumber, EmployeeDOB, EmployeeEmail, EmployeeJoinDate, EmployeeName, EmployeeRole, EmployeeSalary);
            //test to see if it exists
            Assert.AreNotEqual(OK, "");
        }

        [TestMethod]
        public void EmployeeDOBMinBoundary()
        {
            //create a new instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string EmployeeAddress = "ffffff";
            string EmployeeContactNumber = "07666666666";
            //create variable to store the data
            DateTime SomeDate;
            //set date to todays date
            SomeDate = DateTime.Now.Date;
            //change date to -18 years
            SomeDate = SomeDate.AddYears(-18);
            string EmployeeDOB = SomeDate.ToString();
            string EmployeeEmail = "ffffffffffffffffffffff";
            EmployeeEmail.PadRight(12, 'a');
            string EmployeeJoinDate = DateTime.Now.Date.ToString();
            string EmployeeName = "Vinay";
            string EmployeeRole = "Accountant";
            string EmployeeSalary = "1800";
            //invoke method
            OK = AnEmployee.Valid(EmployeeAddress, EmployeeContactNumber, EmployeeDOB, EmployeeEmail, EmployeeJoinDate, EmployeeName, EmployeeRole, EmployeeSalary);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }
        [TestMethod]
        public void EmployeeDOBExMin()
        {
            //create a new instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string EmployeeAddress = "ffffff";
            string EmployeeContactNumber = "07666666666";
            //create variable to store the data
            DateTime SomeDate;
            //set date to todays date
            SomeDate = DateTime.Now.Date;
            //change date to -200 years
            SomeDate = SomeDate.AddYears(-200);
            string EmployeeDOB = SomeDate.ToString();
            string EmployeeEmail = "";
            EmployeeEmail.PadRight(12, 'a');
            string EmployeeJoinDate = DateTime.Now.Date.ToString();
            string EmployeeName = "Vinay";
            string EmployeeRole = "Accountant";
            string EmployeeSalary = "1800";
            //invoke method
            OK = AnEmployee.Valid(EmployeeAddress, EmployeeContactNumber, EmployeeDOB, EmployeeEmail, EmployeeJoinDate, EmployeeName, EmployeeRole, EmployeeSalary);
            //test to see if it exists
            Assert.AreNotEqual(OK, "");
        }

        [TestMethod]
        public void EmployeeDOBMinPlusOne()
        {
            //create a new instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string EmployeeAddress = "fffffffff";
            string EmployeeContactNumber = "07666666666";
            //create variable to store the data
            DateTime SomeDate;
            //set date to todays date
            SomeDate = DateTime.Now.Date;
            //change date to -200 years
            SomeDate = SomeDate.AddYears(-18).AddDays(-1);
            string EmployeeDOB = SomeDate.ToString();
            string EmployeeEmail = "ffffff@ffff.com";
            EmployeeEmail.PadRight(12, 'a');
            string EmployeeJoinDate = DateTime.Now.Date.ToString();
            string EmployeeName = "Vinay";
            string EmployeeRole = "Accountant";
            string EmployeeSalary = "1800";
            //invoke method
            OK = AnEmployee.Valid(EmployeeAddress, EmployeeContactNumber, EmployeeDOB, EmployeeEmail, EmployeeJoinDate, EmployeeName, EmployeeRole, EmployeeSalary);
            //test to see if it exists
            Assert.AreEqual(OK, "");

        }

        [TestMethod]
        public void EmployeeDOBMaxMinusOne()
        {
            //create a new instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string EmployeeAddress = "fffffffff";
            string EmployeeContactNumber = "07666666666";
            //create variable to store the data
            DateTime SomeDate;
            //set date to todays date
            SomeDate = DateTime.Now.Date;
            //change date to -200 years
            SomeDate = SomeDate.AddYears(-149).AddDays(-364);
            string EmployeeDOB = SomeDate.ToString();
            string EmployeeEmail = "ffffff@ffff.com";
            EmployeeEmail.PadRight(12, 'a');
            string EmployeeJoinDate = DateTime.Now.Date.ToString();
            string EmployeeName = "Vinay";
            string EmployeeRole = "Accountant";
            string EmployeeSalary = "1800";
            //invoke method
            OK = AnEmployee.Valid(EmployeeAddress, EmployeeContactNumber, EmployeeDOB, EmployeeEmail, EmployeeJoinDate, EmployeeName, EmployeeRole, EmployeeSalary);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void EmployeeDOBMaxBoundary()
        {
            //create a new instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string EmployeeAddress = "fffffffff";
            string EmployeeContactNumber = "07666666666";
            //create variable to store the data
            DateTime SomeDate;
            //set date to todays date
            SomeDate = DateTime.Now.Date;
            //change date to -200 years
            SomeDate = SomeDate.AddYears(-150);
            string EmployeeDOB = SomeDate.ToString();
            string EmployeeEmail = "ffffff@ffff.com";
            EmployeeEmail.PadRight(12, 'a');
            string EmployeeJoinDate = DateTime.Now.Date.ToString();
            string EmployeeName = "Vinay";
            string EmployeeRole = "Accountant";
            string EmployeeSalary = "1800";
            //invoke method
            OK = AnEmployee.Valid(EmployeeAddress, EmployeeContactNumber, EmployeeDOB, EmployeeEmail, EmployeeJoinDate, EmployeeName, EmployeeRole, EmployeeSalary);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void EmployeeDOBMaxPlusOne()
        {
            //create a new instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string EmployeeAddress = "fffffffff";
            string EmployeeContactNumber = "07666666666";
            //create variable to store the data
            DateTime SomeDate;
            //set date to todays date
            SomeDate = DateTime.Now.Date;
            //change date to -200 years
            SomeDate = SomeDate.AddYears(-150).AddDays(-1);
            string EmployeeDOB = SomeDate.ToString();
            string EmployeeEmail = "ffffff@ffff.com";
            EmployeeEmail.PadRight(12, 'a');
            string EmployeeJoinDate = DateTime.Now.Date.ToString();
            string EmployeeName = "Vinay";
            string EmployeeRole = "Accountant";
            string EmployeeSalary = "1800";
            //invoke method
            OK = AnEmployee.Valid(EmployeeAddress, EmployeeContactNumber, EmployeeDOB, EmployeeEmail, EmployeeJoinDate, EmployeeName, EmployeeRole, EmployeeSalary);
            //test to see if it exists
            Assert.AreNotEqual(OK, "");
        }

        [TestMethod]
        public void EmployeeRoleExtremeMin()
        {
            //create a new instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string EmployeeAddress = "dddd";
            string EmployeeContactNumber = "333333333333";
            string EmployeeDOB = DateTime.Now.Date.AddYears(-19).ToString();
            string EmployeeEmail = "ddddd@hotmail.com";
            string EmployeeJoinDate = DateTime.Now.Date.ToString();
            string EmployeeName = "Vinay";
            string EmployeeRole = "";
            string EmployeeSalary = "1800";
            //invoke method
            OK = AnEmployee.Valid(EmployeeAddress, EmployeeContactNumber, EmployeeDOB, EmployeeEmail, EmployeeJoinDate, EmployeeName, EmployeeRole, EmployeeSalary);
            //test to see if it exists
            Assert.AreNotEqual(OK, "");
        }

        [TestMethod]
        public void EmployeeRoleMinMinusOne()
        {
            //create a new instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string EmployeeAddress = "dddd";
            string EmployeeContactNumber = "333333333333";
            string EmployeeDOB = DateTime.Now.Date.AddYears(-19).ToString();
            string EmployeeEmail = "ddddd@hotmail.com";
            string EmployeeJoinDate = DateTime.Now.Date.ToString();
            string EmployeeName = "Vinay";
            string EmployeeRole = "aa";
            string EmployeeSalary = "1800";
            //invoke method
            OK = AnEmployee.Valid(EmployeeAddress, EmployeeContactNumber, EmployeeDOB, EmployeeEmail, EmployeeJoinDate, EmployeeName, EmployeeRole, EmployeeSalary);
            //test to see if it exists
            Assert.AreNotEqual(OK, "");
        }

        [TestMethod]
        public void EmployeeRoleBoundary()
        {
            //create a new instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string EmployeeAddress = "dddd";
            string EmployeeContactNumber = "333333333333";
            string EmployeeDOB = DateTime.Now.Date.AddYears(-19).ToString();
            string EmployeeEmail = "ddddd@hotmail.com";
            string EmployeeJoinDate = DateTime.Now.Date.ToString();
            string EmployeeName = "Vinay";
            string EmployeeRole = "aaa";
            string EmployeeSalary = "1800";
            //invoke method
            OK = AnEmployee.Valid(EmployeeAddress, EmployeeContactNumber, EmployeeDOB, EmployeeEmail, EmployeeJoinDate, EmployeeName, EmployeeRole, EmployeeSalary);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void EmployeeRoleMinPlusOne()
        {
            //create a new instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string EmployeeAddress = "dddd";
            string EmployeeContactNumber = "333333333333";
            string EmployeeDOB = DateTime.Now.Date.AddYears(-19).ToString();
            string EmployeeEmail = "ddddd@hotmail.com";
            string EmployeeJoinDate = DateTime.Now.Date.ToString();
            string EmployeeName = "Vinay";
            string EmployeeRole = "aaaa";
            string EmployeeSalary = "1800";
            //invoke method
            OK = AnEmployee.Valid(EmployeeAddress, EmployeeContactNumber, EmployeeDOB, EmployeeEmail, EmployeeJoinDate, EmployeeName, EmployeeRole, EmployeeSalary);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void EmployeeRoleMaxMinusOne()
        {
            //create a new instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string EmployeeAddress = "dddd";
            string EmployeeContactNumber = "333333333333";
            string EmployeeDOB = DateTime.Now.Date.AddYears(-19).ToString();
            string EmployeeEmail = "ddddd@hotmail.com";
            string EmployeeJoinDate = DateTime.Now.Date.ToString();
            string EmployeeName = "Vinay";
            string EmployeeRole = "aaaaaaaaaaa";
            string EmployeeSalary = "1800";
            //invoke method
            OK = AnEmployee.Valid(EmployeeAddress, EmployeeContactNumber, EmployeeDOB, EmployeeEmail, EmployeeJoinDate, EmployeeName, EmployeeRole, EmployeeSalary);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void EmployeeRoleMaxBoundary()
        {
            //create a new instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string EmployeeAddress = "dddd";
            string EmployeeContactNumber = "333333333333";
            string EmployeeDOB = DateTime.Now.Date.AddYears(-19).ToString();
            string EmployeeEmail = "ddddd@hotmail.com";
            string EmployeeJoinDate = DateTime.Now.Date.ToString();
            string EmployeeName = "Vinay";
            string EmployeeRole = "aaaaaaaaaaaa";
            string EmployeeSalary = "1800";
            //invoke method
            OK = AnEmployee.Valid(EmployeeAddress, EmployeeContactNumber, EmployeeDOB, EmployeeEmail, EmployeeJoinDate, EmployeeName, EmployeeRole, EmployeeSalary);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void EmployeeRoleMaxBoundaryPlusOne()
        {
            //create a new instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string EmployeeAddress = "dddd";
            string EmployeeContactNumber = "333333333333";
            string EmployeeDOB = DateTime.Now.Date.AddYears(-19).ToString();
            string EmployeeEmail = "ddddd@hotmail.com";
            string EmployeeJoinDate = DateTime.Now.Date.ToString();
            string EmployeeName = "Vinay";
            string EmployeeRole = "aaaaaaaaaaaaa";
            string EmployeeSalary = "1800";
            //invoke method
            OK = AnEmployee.Valid(EmployeeAddress, EmployeeContactNumber, EmployeeDOB, EmployeeEmail, EmployeeJoinDate, EmployeeName, EmployeeRole, EmployeeSalary);
            //test to see if it exists
            Assert.AreNotEqual(OK, "");
        }

        [TestMethod]
        public void EmployeeRoleMid()
        {
            //create a new instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string EmployeeAddress = "dddd";
            string EmployeeContactNumber = "333333333333";
            string EmployeeDOB = DateTime.Now.Date.AddYears(-19).ToString();
            string EmployeeEmail = "ddddd@hotmail.com";
            string EmployeeJoinDate = DateTime.Now.Date.ToString();
            string EmployeeName = "Vinay";
            string EmployeeRole = "aaaaaa";
            string EmployeeSalary = "1800";
            //invoke method
            OK = AnEmployee.Valid(EmployeeAddress, EmployeeContactNumber, EmployeeDOB, EmployeeEmail, EmployeeJoinDate, EmployeeName, EmployeeRole, EmployeeSalary);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void EmployeeRoleExMax()
        {
            //create a new instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string EmployeeAddress = "dddd";
            string EmployeeContactNumber = "333333333333";
            string EmployeeDOB = DateTime.Now.Date.AddYears(-19).ToString();
            string EmployeeEmail = "ddddd@hotmail.com";
            string EmployeeJoinDate = DateTime.Now.Date.ToString();
            string EmployeeName = "Vinay";
            string EmployeeRole = "";
            EmployeeRole = EmployeeRole.PadRight(90, 'a');
            string EmployeeSalary = "1800";
            //invoke method
            OK = AnEmployee.Valid(EmployeeAddress, EmployeeContactNumber, EmployeeDOB, EmployeeEmail, EmployeeJoinDate, EmployeeName, EmployeeRole, EmployeeSalary);
            //test to see if it exists
            Assert.AreNotEqual(OK, "");
        }

        [TestMethod]
        public void EmployeeSalaryMin()
        {
            //create a new instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string EmployeeAddress = "dddd";
            string EmployeeContactNumber = "333333333333";
            string EmployeeDOB = DateTime.Now.Date.AddYears(-19).ToString();
            string EmployeeEmail = "ddddd@hotmail.com";
            string EmployeeJoinDate = DateTime.Now.Date.ToString();
            string EmployeeName = "Vinay";
            string EmployeeRole = "aaaaaa";
            string EmployeeSalary = "130";
            //invoke method
            OK = AnEmployee.Valid(EmployeeAddress, EmployeeContactNumber, EmployeeDOB, EmployeeEmail, EmployeeJoinDate, EmployeeName, EmployeeRole, EmployeeSalary);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void EmployeeSalaryMinMinusOne()
        {
            //create a new instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string EmployeeAddress = "dddd";
            string EmployeeContactNumber = "333333333333";
            string EmployeeDOB = DateTime.Now.Date.AddYears(-19).ToString();
            string EmployeeEmail = "ddddd@hotmail.com";
            string EmployeeJoinDate = DateTime.Now.Date.ToString();
            string EmployeeName = "Vinay";
            string EmployeeRole = "aaaaaa";
            string EmployeeSalary = "13";
            //invoke method
            OK = AnEmployee.Valid(EmployeeAddress, EmployeeContactNumber, EmployeeDOB, EmployeeEmail, EmployeeJoinDate, EmployeeName, EmployeeRole, EmployeeSalary);
            //test to see if it exists
            Assert.AreNotEqual(OK, "");
        }

        [TestMethod]
        public void EmployeeSalaryExMin()
        {
            //create a new instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string EmployeeAddress = "dddd";
            string EmployeeContactNumber = "333333333333";
            string EmployeeDOB = DateTime.Now.Date.AddYears(-19).ToString();
            string EmployeeEmail = "ddddd@hotmail.com";
            string EmployeeJoinDate = DateTime.Now.Date.ToString();
            string EmployeeName = "Vinay";
            string EmployeeRole = "aaaaaa";
            string EmployeeSalary = "";
            //invoke method
            OK = AnEmployee.Valid(EmployeeAddress, EmployeeContactNumber, EmployeeDOB, EmployeeEmail, EmployeeJoinDate, EmployeeName, EmployeeRole, EmployeeSalary);
            //test to see if it exists
            Assert.AreNotEqual(OK, "");
        }

        [TestMethod]
        public void EmployeeSalaryMinPlusOne()
        {
            //create a new instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string EmployeeAddress = "dddd";
            string EmployeeContactNumber = "333333333333";
            string EmployeeDOB = DateTime.Now.Date.AddYears(-19).ToString();
            string EmployeeEmail = "ddddd@hotmail.com";
            string EmployeeJoinDate = DateTime.Now.Date.ToString();
            string EmployeeName = "Vinay";
            string EmployeeRole = "aaaaaa";
            string EmployeeSalary = "1301";
            //invoke method
            OK = AnEmployee.Valid(EmployeeAddress, EmployeeContactNumber, EmployeeDOB, EmployeeEmail, EmployeeJoinDate, EmployeeName, EmployeeRole, EmployeeSalary);
            //test to see if it exists
            Assert.AreEqual(OK, "");

        }

        [TestMethod]
        public void EmployeeSalaryMaxMinusOne()
        {
            //create a new instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string EmployeeAddress = "dddd";
            string EmployeeContactNumber = "333333333333";
            string EmployeeDOB = DateTime.Now.Date.AddYears(-19).ToString();
            string EmployeeEmail = "ddddd@hotmail.com";
            string EmployeeJoinDate = DateTime.Now.Date.ToString();
            string EmployeeName = "Vinay";
            string EmployeeRole = "aaaaaa";
            string EmployeeSalary = "1234567";
            //invoke method
            OK = AnEmployee.Valid(EmployeeAddress, EmployeeContactNumber, EmployeeDOB, EmployeeEmail, EmployeeJoinDate, EmployeeName, EmployeeRole, EmployeeSalary);
            //test to see if it exists
            Assert.AreEqual(OK, "");

        }

        [TestMethod]
        public void EmployeeSalaryMaxBoundary()
        {
            //create a new instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string EmployeeAddress = "dddd";
            string EmployeeContactNumber = "333333333333";
            string EmployeeDOB = DateTime.Now.Date.AddYears(-19).ToString();
            string EmployeeEmail = "ddddd@hotmail.com";
            string EmployeeJoinDate = DateTime.Now.Date.ToString();
            string EmployeeName = "Vinay";
            string EmployeeRole = "aaaaaa";
            string EmployeeSalary = "13000000";
            //invoke method
            OK = AnEmployee.Valid(EmployeeAddress, EmployeeContactNumber, EmployeeDOB, EmployeeEmail, EmployeeJoinDate, EmployeeName, EmployeeRole, EmployeeSalary);
            //test to see if it exists
            Assert.AreEqual(OK, "");

        }

        [TestMethod]
        public void EmployeeSalaryMaxPlusOne()
        {
            //create a new instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string EmployeeAddress = "dddd";
            string EmployeeContactNumber = "333333333333";
            string EmployeeDOB = DateTime.Now.Date.AddYears(-19).ToString();
            string EmployeeEmail = "ddddd@hotmail.com";
            string EmployeeJoinDate = DateTime.Now.Date.ToString();
            string EmployeeName = "Vinay";
            string EmployeeRole = "aaaaaa";
            string EmployeeSalary = "123456789";
            //invoke method
            OK = AnEmployee.Valid(EmployeeAddress, EmployeeContactNumber, EmployeeDOB, EmployeeEmail, EmployeeJoinDate, EmployeeName, EmployeeRole, EmployeeSalary);
            //test to see if it exists
            Assert.AreNotEqual(OK, "");
        }

        [TestMethod]
        public void EmployeeSalaryMid()
        {
            //create a new instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string EmployeeAddress = "dddd";
            string EmployeeContactNumber = "333333333333";
            string EmployeeDOB = DateTime.Now.Date.AddYears(-19).ToString();
            string EmployeeEmail = "ddddd@hotmail.com";
            string EmployeeJoinDate = DateTime.Now.Date.ToString();
            string EmployeeName = "Vinay";
            string EmployeeRole = "aaaaaa";
            string EmployeeSalary = "1234";
            //invoke method
            OK = AnEmployee.Valid(EmployeeAddress, EmployeeContactNumber, EmployeeDOB, EmployeeEmail, EmployeeJoinDate, EmployeeName, EmployeeRole, EmployeeSalary);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }
    }
}

