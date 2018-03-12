using System;

namespace MyClassLibrary
{
    public class clsCustomer
    {

        public clsCustomer()
        {
        }

        public string ContactNumber { get; set; }
        public string dateOfBirth { get; set; }
        public string EMail { get; set; }
        public string FlatNo { get; set; }
        public string ForeName { get; set; }
        public string Gender { get; set; }
        public string HouseNo { get; set; }
        public string Password { get; set; }
        public string PostCode { get; set; }
        public string Surname { get; set; }
        public string UserName { get; set; }

        public string Valid(string userName, string password, string foreName, string surname, string dateOfBirth, string gender, string contactNumber, string eMail, string flatNo, string houseNo, string postCode)
        {
            DateTime DateTemp;
            string OK = "";

            if (userName.Length < 5)
            {
                OK = OK + "Username is too short";
            }
            if (userName.Length > 20)
            {
                OK = OK + "Username is too long";
            }

            //////////////////////////////////

            if (password.Length < 5)
            {
                OK = OK + "Password is too short";
            }
            if (password.Length > 20)
            {
                OK = OK + "Password is too long";
            }

            //////////////////////////////////

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
            { DateTemp = Convert.ToDateTime(dateOfBirth);

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
            //Always return true
            return true;
        }
        }
    }