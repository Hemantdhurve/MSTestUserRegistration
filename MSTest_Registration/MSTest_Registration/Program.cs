// See https://aka.ms/new-console-template for more information
using MSTest_Registration;

Console.WriteLine("Hello, Welcome to REGEX User Registration Problems");

UserRegistration obj = new UserRegistration();

Console.WriteLine("Please enter the first name :");
string Firstname = Console.ReadLine();

if (obj.validateString(Firstname))
{
    Console.WriteLine("Entered name is valid:" + Firstname);
}
else
{
    Console.WriteLine("Entered name is invalid please try again :" + Firstname);
}
