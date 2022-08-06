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
        public static string FirstName = "^[A-Z][a-z]{2,15}$";

        public bool validateString(string sample)
        {
            return Regex.IsMatch(sample, FirstName);
        }
    }
}
