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
        public static string SampleEmails = "^[a-zA-Z0-9]+([#$%+_-][a-zA-Z0-9]+)*[@][a-zA-Z0-9]{1,}[.][a-zA-Z]{2,3}([.][a-zA-Z]{2})?$";



        public bool validateString(string sample)
        {
            return Regex.IsMatch(sample, SampleEmails);
        }
    }
}
