using System;

namespace MyClassLibrary
{
    public class clsEmployee
    {
        private string mAddress;
        public string Address
        {
            get
            {
                return mAddress;

            }
            set
            {
                mAddress = value;
            }
        }
        private string mEmployeeContactNumber;
        public string EmployeeContactNumber
        {
            get
            {
                return mEmployeeContactNumber;
            }
            set
            {
                mEmployeeContactNumber = value;
            }
        }
        private DateTime mEmployeeDOB;
        public DateTime EmployeeDOB
        {
            get
            {
                return mEmployeeDOB;
            }
            set
            {
                mEmployeeDOB = value;
            }
        }

        private string mEmployeeEmail;
        public string EmployeeEmail
        {
            get
            {
                return mEmployeeEmail;
            }
            set
            {
                mEmployeeEmail = value;
            }
        }
        private DateTime mEmployeeJoinDate;
        public DateTime EmployeeJoinDate
        {
            get
            {
                return mEmployeeJoinDate;
            }
            set
            {
                mEmployeeJoinDate = value;
            }
        }
        private string mEmployeeName;
        public string EmployeeName
        {
            get
            {
                return mEmployeeName;
            }
            set
            {
                mEmployeeName = value;
            }
        }
        private string mEmployeeRole;
        public string EmployeeRole
        {
            get
            {
                return mEmployeeRole;
            }
            set
            {
                mEmployeeRole = value;
            }
        }
        private string mEmployeeSalary;
        public string EmployeeSalary
        {
            get
            {
                return mEmployeeSalary;
            }
            set
            {
                mEmployeeSalary = value;
            }
        }

        private Int32 mEmployeeNo;
        public int EmployeeNo
        {
            get
            {
                return mEmployeeNo;
            }
            set
            {
                mEmployeeNo = value;
            }
        }



        public string Valid(string employeeAddress, string employeeContactNumber, string employeeDOB, string employeeEmail, string employeeJoinDate, string employeeName, string employeeRole, string employeeSalary)
        {
            string Error = "";
            if (employeeAddress.Length == 0)
            {
                Error = Error + "The employee address may bot be blank : ";
            }
            if (employeeAddress.Length > 30)
            {
                Error = Error + "The employee address must be 30 characters or less : ";
            }
            if (employeeAddress.Length > 90)
            {
                Error = Error + "The employee address must be less than 90 characters : ";
            }
            if (employeeContactNumber.Length == 0)
            {
                Error = Error + "Contact number can't be empty ";
            }

            if (employeeContactNumber.Length < 11 | employeeContactNumber.Length > 15)
            {
                //set the error message
                Error = Error + "Length must be between 11 and 15 : ";
            }
            //if (employeeContactNumber.Length < 11)
            //{
            //    Error = Error + "Contact number can't be less than 11";
            //}
            //if (employeeContactNumber.Length < 15)
            //{
            //    Error = Error + "Contact number has to be less than 15 ";
            //}
            if (employeeEmail.Length == 0)
            {
                Error = Error + "The employee email may bot be blank : ";
            }

            if (employeeEmail.Length < 5)
            {
                Error = Error + "The employee address must be 5 characters or more : ";
            }
            if (employeeEmail.Length > 27)
            {
                Error = Error + "The employee address must be less than 27 characters : ";
            }

            try
            {

                DateTime DateTemp;
                DateTemp = Convert.ToDateTime(employeeDOB);

                if (DateTemp > DateTime.Now.Date.AddYears(-18))
                {
                    Error = Error + "You must be over 18 years old";
                }

                if (DateTemp < DateTime.Now.Date.AddYears(-150))
                {
                    Error = Error + "You must be under 150 years old";
                }

            }
            catch
            {
                Error = Error + "Incorrect date entered";
            }
            if (employeeRole.Length == 0)
            {
                Error = Error + "The employee role may bot be blank : ";
            }
            if (employeeRole.Length < 3)
            {
                Error = Error + "The employee role not be less than 3 characters : ";
            }
            if (employeeRole.Length > 12)
            {
                Error = Error + "The employee role not be more than 12 characters : ";
            }
            if (employeeSalary.Length < 3)
            {
                Error = Error + "The employee salary can't be less than 3 characters : ";
            }
            if (employeeSalary.Length == 0)
            {
                Error = Error + "The employee salary can't be blank ";
            }
            if (employeeSalary.Length > 8)
            {
                Error = Error + "The employee salary can't more than 8 characters ";
            }
            if (employeeName.Length == 0)
            {
                Error = Error + "The employee name cant be blank ";
            }
            if (employeeName.Length > 40)
            {
                Error = Error + "The employee name cant more than 40 characters ";
            }
            try
            {

                DateTime DateTemp1;
                DateTemp1 = Convert.ToDateTime(employeeJoinDate);

                if (DateTemp1 < DateTime.Now.Date.AddMonths(-1))
                {
                    Error = Error + "Join date must be over one month ago";
                }

                if (DateTemp1 > DateTime.Now.Date)
                {
                    Error = Error + "Join date cannot be in the future";
                }

            }
            catch
            {
                Error = Error + "Incorrect date entered";
            }
            return Error;
        }



        public bool Find(int EmployeeNo)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add parameter for the employee number to search for
            DB.AddParameter("@EmployeeNo", EmployeeNo);
            //execute procedure
            DB.Execute("sproc_tblEmployees_FilterByEmployeeNo");
            if (DB.Count == 1)
            {
                //copy data from datbaase to private data members
                mEmployeeNo = Convert.ToInt32(DB.DataTable.Rows[0]["EmployeeNo"]);
                mEmployeeName = Convert.ToString(DB.DataTable.Rows[0]["EmployeeName"]);
                mEmployeeJoinDate = Convert.ToDateTime(DB.DataTable.Rows[0]["EmployeeJoinDate"]);
                mEmployeeRole = Convert.ToString(DB.DataTable.Rows[0]["EmployeeRole"]);
                mEmployeeSalary = Convert.ToString(DB.DataTable.Rows[0]["EmployeeSalary"]);
                mEmployeeEmail = Convert.ToString(DB.DataTable.Rows[0]["EmployeeEmail"]);
                mEmployeeDOB = Convert.ToDateTime(DB.DataTable.Rows[0]["EmployeeDOB"]);
                return true;
            }
            else
            {
                return false;

            }


        }
    }
}