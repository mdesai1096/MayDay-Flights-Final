using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;
using System.Collections.Generic;

namespace MyTesting
{
    [TestClass]
    public class tstEmployeeCollection
    {

        [TestMethod]
        public void InstanceOK()
        {
            //create instance of class we want to create
            clsEmployeeCollection AllEmployees = new clsEmployeeCollection();
            //test to see that it exists
            Assert.IsNotNull(AllEmployees);
        }

        [TestMethod]
        public void EmployeeListOK()
        {
            //create instance of class
            clsEmployeeCollection AllEmployees = new clsEmployeeCollection();
            //create some test data to assign to property
            //in this case data needs to be list of objects
            List<clsEmployee> TestList = new List<clsEmployee>();
            // add new item to list
            //create item of test data
            clsEmployee TestItem = new clsEmployee();
            //set properties
            TestItem.EmployeeNo = 1;
            TestItem.EmployeeName = "Vinay Kumar";
            TestItem.Address = "golden mile";
            TestItem.EmployeeRole = "Sales";
            TestItem.EmployeeJoinDate = Convert.ToDateTime("12/04/2018");
            TestItem.EmployeeDOB = Convert.ToDateTime("19/09/1985");
            TestItem.EmployeeEmail = "vk@mayday.com";
            TestItem.EmployeeSalary = "10";
            TestItem.EmployeeContactNumber = "554";
            //add item to test list
            TestList.Add(TestItem);
            //asign data to property
            AllEmployees.EmployeesList = TestList;
            //test to see two values are the same
            Assert.AreEqual(AllEmployees.EmployeesList, TestList);

        }



        [TestMethod]
        public void ThisEmployeePropertyOK()
        {
            //create instance of class we want to create
            clsEmployeeCollection AllEmployees = new clsEmployeeCollection();
            //create some test data to assign to the property
            clsEmployee TestEmployee = new clsEmployee();
            //set property of the test objects
            TestEmployee.EmployeeNo = 1;
            TestEmployee.EmployeeName = "Vinay Kumar";
            TestEmployee.Address = "golden mile";
            TestEmployee.EmployeeRole = "Sales";
            TestEmployee.EmployeeJoinDate = Convert.ToDateTime("12/04/2018");
            TestEmployee.EmployeeDOB = Convert.ToDateTime("19/09/1985");
            TestEmployee.EmployeeEmail = "vk@mayday.com";
            TestEmployee.EmployeeSalary = "10";
            TestEmployee.EmployeeContactNumber = "554";
            //assign data to the property
            AllEmployees.ThisEmployee = TestEmployee;
            //test to see that two values are the same
            Assert.AreEqual(AllEmployees.ThisEmployee, TestEmployee);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsEmployeeCollection AllEmployees = new clsEmployeeCollection();
            //create test data to assign to property
            //in this case teh data needs to be a list of ojbects
            List<clsEmployee> TestList = new List<clsEmployee>();
            //add item to the list
            //create the item of test data
            clsEmployee TestItem = new clsEmployee();
            //set property
            TestItem.EmployeeNo = 1;
            TestItem.EmployeeName = "Vinay Kumar";
            TestItem.Address = "golden mile";
            TestItem.EmployeeRole = "Sales";
            TestItem.EmployeeJoinDate = Convert.ToDateTime("12/04/2018");
            TestItem.EmployeeDOB = Convert.ToDateTime("19/09/1985");
            TestItem.EmployeeEmail = "vk@mayday.com";
            TestItem.EmployeeSalary = "10";
            TestItem.EmployeeContactNumber = "554";
            //add item to the list
            TestList.Add(TestItem);
            //asign data to property
            AllEmployees.EmployeesList = TestList;
            //test to see two values are the same
            Assert.AreEqual(AllEmployees.Count, TestList.Count);

        }




    }
}




