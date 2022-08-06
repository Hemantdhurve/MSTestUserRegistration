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
        public static string PasswordRule3 = "(?=.*[0-9])(?=.*[A-Z])[a-zA-Z0-9]{8}";



        public bool validateString(string sample)
        {
            return Regex.IsMatch(sample, PasswordRule3);
        }
    }
}
