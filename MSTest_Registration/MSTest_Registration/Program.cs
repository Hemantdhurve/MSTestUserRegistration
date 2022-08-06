// See https://aka.ms/new-console-template for more information
using MSTest_Registration;

Console.WriteLine("Hello, Welcome to REGEX User Registration Problems");

UserRegistration obj = new UserRegistration();

Console.WriteLine("Please enter the Password Rule 3 :");
string PasswordRule3 = Console.ReadLine();

if (obj.validateString(PasswordRule3))
{
    Console.WriteLine("Entered name is valid:" + PasswordRule3);
}
else
{
    Console.WriteLine("Entered name is invalid please try again :" + PasswordRule3);
}
