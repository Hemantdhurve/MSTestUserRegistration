// See https://aka.ms/new-console-template for more information
using MSTest_Registration;

Console.WriteLine("Hello, Welcome to REGEX User Registration Problems");

UserRegistration obj = new UserRegistration();

Console.WriteLine("Please enter the Password Rule 2 :");
string PasswordRule2 = Console.ReadLine();

if (obj.validateString(PasswordRule2))
{
    Console.WriteLine("Entered name is valid:" + PasswordRule2);
}
else
{
    Console.WriteLine("Entered name is invalid please try again :" + PasswordRule2);
}
