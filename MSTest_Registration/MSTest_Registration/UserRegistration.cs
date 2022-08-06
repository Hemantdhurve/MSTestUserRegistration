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
        public static string PhoneNumber = "^91([ ])?[5-9]{1}[0-9]{9}$";



        public bool validateString(string sample)
        {
            return Regex.IsMatch(sample, PhoneNumber);
        }
    }
}
