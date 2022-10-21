using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblem
{
    public class UserDetials
    {
        public static string REGEX_FIRSTNAME = "^[A-Z]{1}[A-Za-z]{2,}$";
        //LastNameValidation
        public static string REGEX_LASTNAME = "^[A-Z]{1}[A-Za-z]{2,}$";
        public static string REGEX_EMAILADDRESS = "^[a-zA-Z0-9]([._+-]{0,1}[a-zA-Z0-9])*[@]{1}[a-zA-Z0-9]{1,}[.]{1}[a-zA-Z]{2,3}([.]{1}[a-zA-Z]{2,3}){0,1}$";
        public static string REGEX_PHONENUMBER = "^[9]{1}[1]{1}\\s[0-9]{10}$";
        public static string REGEX_PASSWORD = "(?=.*?[A-Z])(?=.*?[a-z])(?=.*[0-9]).{8,}$";
        public bool validateFirstname(string Firstname)
        {
            return Regex.IsMatch(Firstname, REGEX_FIRSTNAME);

        }
        public bool validateLastname(string Lastname)
        {
            return Regex.IsMatch(Lastname, REGEX_LASTNAME);
        }
        public bool validateEmailAddress(string EmailAddress)
        {
            return Regex.IsMatch(EmailAddress, REGEX_EMAILADDRESS);
        }
        //PhoneNumberValidation
        public bool validatephonenumber(string phonenumber)
        {
            return Regex.IsMatch(phonenumber, REGEX_PHONENUMBER);
        }
        //PassWordValidation
        public bool validatepassword(string password)
        {
            return Regex.IsMatch(password, REGEX_PASSWORD);
        }
    }
}
