using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        string pattern = @"^(0|\+?94)?([0-9]{9})$";

        string phoneNumber;
        string trimNumber;
        string standardPhoneNumber;

        while (true)
        {
            Console.Write("Enter the phone number (enter 'q' to quit): ");
            phoneNumber = Console.ReadLine().Trim();

            if (phoneNumber.ToLower() == "q")
                break;

            trimNumber = Regex.Replace(phoneNumber, @"\s", "");

            if (trimNumber.Length < 9)
            {
                Console.WriteLine("Invalid Phone Number");
                continue;
            }
            else
            {
                // Standardize the phone number
                standardPhoneNumber = Regex.Replace(trimNumber, pattern, "+94$2");
                Console.WriteLine($"Is your phone number is: {standardPhoneNumber} Press 'y' for yes or 'n' for input again");
                string responese = Console.ReadLine().Trim();

                if (responese == "y")
                    Console.WriteLine("Standardized phone number: " + standardPhoneNumber);
            }
        }
    }
}
