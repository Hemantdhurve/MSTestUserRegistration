using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MSTest_Registration
{
    public class UserRegistration
    {
        public static string PasswordRule1 = "^[a-zA-Z]{8}$";



        public bool validateString(string sample)
        {
            return Regex.IsMatch(sample, PasswordRule1);
        }
    }
}
