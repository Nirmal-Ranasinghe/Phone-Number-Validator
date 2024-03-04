using static System.Net.Mime.MediaTypeNames;
using System.Text.RegularExpressions;
using System.Reflection.Metadata;
using System;


class PhoneNumber {
    public static void Main(string[] args)
    {
        Console.Write("Enter the phone number: ");
        string phoneNumber = Console.ReadLine();
        string trimNumber = Regex.Replace(phoneNumber, @"\s", "");

        string pattern = @"^(0|\+?94)?([0-9]{9})$";

        string standardPhoneNumber = Regex.Replace(trimNumber, pattern, "94$2");

        Console.WriteLine("Standardized phone number: " + standardPhoneNumber);
    }
}