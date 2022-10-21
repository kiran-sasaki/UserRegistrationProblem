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
        public bool validateFirstname(string Firstname)
        {
            return Regex.IsMatch(Firstname, REGEX_FIRSTNAME);

        }
        public bool validateLastname(string Lastname)
        {
            return Regex.IsMatch(Lastname, REGEX_LASTNAME);
        }
    }
}
