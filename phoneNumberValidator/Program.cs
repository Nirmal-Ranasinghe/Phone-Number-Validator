using static System.Net.Mime.MediaTypeNames;
using System.Text.RegularExpressions;

Console.Write("Enter the phone number: ");
String phoneNumber = Console.ReadLine();

string trimNumber = Regex.Replace(phoneNumber, @"\s", "");

string message = (trimNumber.Length < 0 || trimNumber == null) ? "Please enter your number" : $"You number is {trimNumber}";
Console.Write(message);
