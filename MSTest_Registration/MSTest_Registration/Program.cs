// See https://aka.ms/new-console-template for more information
using MSTest_Registration;

Console.WriteLine("Hello, Welcome to REGEX User Registration Problems");

UserRegistration obj = new UserRegistration();

Console.WriteLine("Please enter the last name :");
string LastName = Console.ReadLine();

if (obj.validateString(LastName))
{
    Console.WriteLine("Entered name is valid:" + LastName);
}
else
{
    Console.WriteLine("Entered name is invalid please try again :" + LastName);
}
