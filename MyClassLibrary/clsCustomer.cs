using System;

namespace MyClassLibrary
{
    public class clsCustomer
    {

        private string mContactNumber;
        public string ContactNumber
        {
            get
            {
                return mContactNumber;
            }
            set
            {
                mContactNumber = value;
            }

        }


        private DateTime mdateOfBirth;
        public DateTime dateOfBirth
        {
            get
            {
                return mdateOfBirth;
            }
            set
            {
                mdateOfBirth = value;
            }

        }

        private string mEmail;
        public string EMail
        {

            get
            {
                return mEmail;
            }
            set
            {
                mEmail = value;
            }

        }


        private string mFlatNo;
        public string FlatNo
        {
            get
            {
                return mFlatNo;
            }
            set
            {
                mFlatNo = value;
            }

        }

        private string mForeName;
        public string ForeName
        {
            get
            {
                return mForeName;
            }
            set
            {
                mForeName = value;
            }

        }


        private string mGender;
        public string Gender
        {
            get
            {
                return mGender;
            }
            set
            {
                mGender = value;
            }

        }

        private string mHouseNo;
        public string HouseNo
        {
            get
            {
                return mHouseNo;
            }
            set
            {
                mHouseNo = value;
            }

        }

        private string mPassword;
        public string Password
        {
            get
            {
                return mPassword;
            }
            set
            {
                mPassword = value;
            }

        }

        private string mPostCode;
        public string PostCode
        {
            get
            {
                return mPostCode;
            }
            set
            {
                mPostCode = value;
            }

        }

        private string mSurname;
        public string Surname
        {
            get
            {
                return mSurname;
            }
            set
            {
                mSurname = value;
            }

        }

        private string mUserName;
        public string UserName
        {
            get
            {
                return mUserName;
            }
            set
            {
                mUserName = value;
            }

        }

        private Int32 mCustomerID;
        public Int32 CustomerID
        {
            get
            {
                return mCustomerID;
            }
            set
            {
                mCustomerID = value;
            }

        }

        private string mName;
        public string Name
        {
            get
            {
                return mSurname + " " + mForeName;
            }
            set
            {
                mName = value;
            }

        }


        public string Valid(string foreName, string surname, string dateOfBirth, string gender, string contactNumber, string eMail, string flatNo, string houseNo, string postCode)
        {
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



            if (gender.Length < 1)
            {
                OK = OK + "gender is too short";
            }
            if (gender.Length > 6)
            {
                OK = OK + "gender is too long";
            }


            if (contactNumber.Length < 3)
            {
                OK = OK + "Contact Number is too short";
            }
            if (contactNumber.Length > 11)
            {
                OK = OK + "Contact Number is too long";
            }



            if (eMail.Length < 6)
            {
                OK = OK + "eMail is too short";
            }
            if (eMail.Length > 30)
            {
                OK = OK + "eMail is too long";
            }


            if (flatNo.Length < 1)
            {
                OK = OK + "flatNo is too short";
            }
            if (flatNo.Length > 6)
            {
                OK = OK + "flatNo is too long";
            }


            if (houseNo.Length < 1)
            {
                OK = OK + "houseNo is too short";
            }
            if (houseNo.Length > 6)
            {
                OK = OK + "houseNo is too long";
            }


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