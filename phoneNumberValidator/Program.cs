using System;
using System.Text.RegularExpressions;

string pattern = @"^(0|\+?94)?([0-9]{9})$";
string phoneNumber;
string trimNumber;
string standardPhoneNumber;
string responese;

while (true)
{
    Console.Write("Enter the phone number (enter 'q' to quit): ");
    phoneNumber = Console.ReadLine().Trim();

    if (phoneNumber.ToLower() == "q")
        break;

    trimNumber = Regex.Replace(phoneNumber, @"\s", "");

    if (trimNumber.Length < 9 || trimNumber.Length > 10)
    {
        Console.WriteLine("Invalid Phone Number");
        continue;
    }
    else
    {
        standardPhoneNumber = Regex.Replace(trimNumber, pattern, "+94$2");
        Console.WriteLine($"Is the number is correct: {standardPhoneNumber} Press 'y' for yes or 'n' for input again");
        responese = Console.ReadLine().Trim();

        if (responese == "y")
            Console.WriteLine("Standardized phone number: " + standardPhoneNumber);
    }
}
