// See https://aka.ms/new-console-template for more information
using MSTest_Registration;

Console.WriteLine("Hello, Welcome to REGEX User Registration Problems");

UserRegistration obj = new UserRegistration();

Console.WriteLine("Please enter the Email address :");
string Email = Console.ReadLine();

if (obj.validateString(Email))
{
    Console.WriteLine("Entered name is valid:" + Email);
}
else
{
    Console.WriteLine("Entered name is invalid please try again :" + Email);
}
