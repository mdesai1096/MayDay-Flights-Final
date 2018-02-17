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

       
    }
}


