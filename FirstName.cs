using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UserRegistration1
{
    public class User
    {
        public static string User_FirstName = "^[A-Z]{1}[a-z]{2,}$";
        public bool FirstName(string firstName)
        {
            return Regex.IsMatch(firstName, User_FirstName);
        }
    }
}
