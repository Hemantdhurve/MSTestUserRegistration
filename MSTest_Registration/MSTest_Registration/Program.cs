// See https://aka.ms/new-console-template for more information
using MSTest_Registration;

Console.WriteLine("Hello, Welcome to REGEX User Registration Problems");

UserRegistration obj = new UserRegistration();

Console.WriteLine("Please enter the Phone Number :");
string PhoneNumber = Console.ReadLine();

if (obj.validateString(PhoneNumber))
{
    Console.WriteLine("Entered name is valid:" + PhoneNumber);
}
else
{
    Console.WriteLine("Entered name is invalid please try again :" + PhoneNumber);
}
