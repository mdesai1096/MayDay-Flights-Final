using System;


//Author Ayub Osman
namespace MyClassLibrary
{
    public class clsCustomer
    {

        private string mContactNumber;

        //public property for ContactNumber
        public string ContactNumber
        {
            get
            {
                //return private data
                return mContactNumber;
            }
            set
            {
                //set the the value of the private memeber
                mContactNumber = value;
            }

        }


        private DateTime mdateOfBirth;

        //public property for dateOfBirth
        public DateTime dateOfBirth
        {
            get
            {
                //return private data
                return mdateOfBirth;
            }
            set
            {
                //set the the value of the private memeber
                mdateOfBirth = value;
            }

        }

        private string mEmail;

        //public property for eMail
        public string EMail
        {

            get
            {
                //return private data
                return mEmail;
            }
            set
            {
                //set the the value of the private memeber
                mEmail = value;
            }

        }


        private string mFlatNo;

        //public property for FlatNo
        public string FlatNo
        {
            get
            {
                //return private data
                return mFlatNo;
            }
            set
            {
                //set the the value of the private memeber
                mFlatNo = value;
            }

        }

        private string mForeName;

        //public property for ForeName
        public string ForeName
        {
            get
            {
                //return private data
                return mForeName;
            }
            set
            {
                //set the the value of the private memeber
                mForeName = value;
            }

        }


        private string mGender;
        //public property for Gender
        public string Gender
        {
            get
            {
                //return private data
                return mGender;
            }
            set
            {
                //set the the value of the private memeber
                mGender = value;
            }

        }

        private string mHouseNo;
        //public property for HouseNo
        public string HouseNo
        {
            get
            {
                //return private data
                return mHouseNo;
            }
            set
            {
                //set the the value of the private memeber
                mHouseNo = value;
            }

        }

        private string mPassword;
        //public property for Password
        public string Password
        {
            get
            {
                //return private data
                return mPassword;
            }
            set
            {
                //set the the value of the private memeber
                mPassword = value;
            }

        }

        private string mPostCode;

        //public property for Postcode
        public string PostCode
        {
            get
            {
                //return private data
                return mPostCode;
            }
            set
            {
                //set the the value of the private memeber
                mPostCode = value;
            }

        }

        private string mSurname;

        //public property for Surname
        public string Surname
        {
            get
            {
                //return private data
                return mSurname;
            }
            set
            {
                //set the the value of the private memeber
                mSurname = value;
            }

        }

        private string mUserName;

        //public property for UserName
        public string UserName
        {
            get
            {
                //return private data
                return mUserName;
            }
            set
            {
                //set the the value of the private memeber
                mUserName = value;
            }

        }

        private Int32 mCustomerID;
        public Int32 CustomerID
        {
            get
            {
                //return private data
                return mCustomerID;
            }
            set
            {
                //set the the value of the private memeber
                mCustomerID = value;
            }

        }

        private string mName;

        //public property for Name
        public string Name
        {
            get
            {
                //return private data
                return mSurname + " " + mForeName;
            }
            set
            {
                //set the the value of the private memeber
                mName = value;
            }

        }

        private string mAllDetails;

        //public property for AllDetails
        public string AllDetails
        {
            get
            {
                //return private data
                return mForeName + " " + mSurname + " " + mPostCode;
            }
            set
            {
                //set the the value of the private memeber
                mAllDetails = value;
            }

        }

        public string Valid(string foreName, string surname, string dateOfBirth, string gender, string contactNumber, string eMail, string flatNo, string houseNo, string postCode)
        {
            //temp variable to store start date
            DateTime DateTemp;
            string OK = "";


            if (foreName.Length < 1)
            {
                OK = OK + "foreName is too short";
            }
            if (foreName.Length > 25)
            {
                OK = OK + "foreName is too long";
            }

            /////////////////////////////

            if (surname.Length < 1)
            {
                OK = OK + "surname is too short";
            }
            if (surname.Length > 25)
            {
                OK = OK + "surname is too long";
            }



            try
            {
                DateTemp = Convert.ToDateTime(dateOfBirth);

                if (DateTemp >= DateTime.Now.Date.AddYears(-18))
                {
                    OK = OK + "You must be over 18 years old";
                }

                if (DateTemp <= DateTime.Now.Date.AddYears(-150))
                {
                    OK = OK + "You must be under 150 years old";
                }

            }
            catch
            {
                OK = OK + "Incorrect date entered";
            }

            // if statement for Gender

            if (gender.Length < 1)
            {
                OK = OK + "gender is too short";
            }
            if (gender.Length > 6)
            {
                OK = OK + "gender is too long";
            }

            // if statement for contactNo

            if (contactNumber.Length < 3)
            {
                OK = OK + "Contact Number is too short";
            }
            if (contactNumber.Length > 11)
            {
                OK = OK + "Contact Number is too long";
            }

            // if statement for email 

            if (eMail.Length < 6)
            {
                OK = OK + "eMail is too short";
            }
            if (eMail.Length > 30)
            {
                OK = OK + "eMail is too long";
            }

            // if statement for FlatNo

            if (flatNo.Length < 1)
            {
                OK = OK + "flatNo is too short";
            }
            if (flatNo.Length > 6)
            {
                OK = OK + "flatNo is too long";
            }

            // if statement for houseno

            if (houseNo.Length < 1)
            {
                OK = OK + "houseNo is too short";
            }
            if (houseNo.Length > 6)
            {
                OK = OK + "houseNo is too long";
            }

            // if statement for postcode

            if (postCode.Length < 5)
            {
                OK = OK + "postCode is too short";
            }
            if (postCode.Length > 9)
            {
                OK = OK + "postCode is too long";
            }

            return OK;

        }

        public bool Find(int CustomerID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the book ref to search for
            DB.AddParameter("@CustId", CustomerID);
            //execute stored procedure
            DB.Execute("sproc_FiltertblCustomerbyPK");
            //if one record is found
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["Customer_ID"]);
                mSurname = Convert.ToString(DB.DataTable.Rows[0]["surName"]);
                mForeName = Convert.ToString(DB.DataTable.Rows[0]["Forename"]);
                mGender = Convert.ToString(DB.DataTable.Rows[0]["Gender"]);
                mdateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[0]["DateofBirth"]);
                mPostCode = Convert.ToString(DB.DataTable.Rows[0]["Postcode"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mHouseNo = Convert.ToString(DB.DataTable.Rows[0]["HouseNo"]);
                mFlatNo = Convert.ToString(DB.DataTable.Rows[0]["FlatNo"]);
                mContactNumber = Convert.ToString(DB.DataTable.Rows[0]["ContactNo"]);
                //mUserName = Convert.ToString(DB.DataTable.Rows[0]["UserName"]);

                //return an record has been found
                return true;
            }
            //if no record is found
            else
            {
                //record no record has been found
                return false;
            }
        }
    }
}