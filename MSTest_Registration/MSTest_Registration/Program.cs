// See https://aka.ms/new-console-template for more information
using MSTest_Registration;

Console.WriteLine("Hello, Welcome to REGEX User Registration Problems");

UserRegistration obj = new UserRegistration();

Console.WriteLine("Please enter the Password Rule 4 :");
string PasswordRule4 = Console.ReadLine();

if (obj.validateString(PasswordRule4))
{
    Console.WriteLine("Entered value is valid:" + PasswordRule4);
}
else
{
    Console.WriteLine("Entered value is invalid please try again :" + PasswordRule4);
}
