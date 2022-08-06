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
        public static string Email = "^[A-Za-z]{3,}([.]{1}[A-Za-z]{3,})*[@][a-z]{2,}[.][a-z]{2,}([.][a-zA-Z]{2})?$";



        public bool validateString(string sample)
        {
            return Regex.IsMatch(sample, Email);
        }
    }
}
