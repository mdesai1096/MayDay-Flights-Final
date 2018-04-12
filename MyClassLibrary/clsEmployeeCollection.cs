using System.Collections.Generic;
using System;

namespace MyClassLibrary
{
    public class clsEmployeeCollection
    {
        //private data member for the list
        List<clsEmployee> mEmployeesList = new List<clsEmployee>();
        public List<clsEmployee> EmployeesList
        {
            get
            {
                //return the private data
                return mEmployeesList;
            }
            set
            {
                //set the private data
                mEmployeesList = value;
            }
        }
        public int Count
        {
            get
            {
                //return count of the list
                return mEmployeesList.Count;
            }
            set
            {
                //worry bout later
            }
        }
        public clsEmployee ThisEmployee { get; set; }

        public clsEmployeeCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblEmployees_SelectAll");
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                //create blank employee
                clsEmployee AnEmployee = new clsEmployee();
                // read in fields from current record
                AnEmployee.EmployeeNo = Convert.ToInt32(DB.DataTable.Rows[Index]["EmployeeNo"]);
                AnEmployee.EmployeeName = Convert.ToString(DB.DataTable.Rows[Index]["EmployeeName"]);
                AnEmployee.EmployeeJoinDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["EmployeeJoinDate"]);
                AnEmployee.EmployeeRole = Convert.ToString(DB.DataTable.Rows[Index]["EmployeeRole"]);
                AnEmployee.EmployeeSalary = Convert.ToString(DB.DataTable.Rows[Index]["EmployeeSalary"]);
                AnEmployee.EmployeeEmail = Convert.ToString(DB.DataTable.Rows[Index]["EmployeeEmail"]);
                AnEmployee.EmployeeDOB = Convert.ToDateTime(DB.DataTable.Rows[Index]["EmployeeDOB"]);
                //add record to private data member
                mEmployeesList.Add(AnEmployee);
                //point to next record
                Index++;

            }
        }
    }
}