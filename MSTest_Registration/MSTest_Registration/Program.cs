// See https://aka.ms/new-console-template for more information
using MSTest_Registration;

Console.WriteLine("Hello, Welcome to REGEX User Registration Problems");

UserRegistration obj = new UserRegistration();

Console.WriteLine("Please enter the Sample Emails :");
string SampleEmails = Console.ReadLine();

if (obj.validateString(SampleEmails))
{
    Console.WriteLine("Entered sample email is valid:" + SampleEmails);
}
else
{
    Console.WriteLine("Entered sample emails is invalid please try again :" + SampleEmails);
}
