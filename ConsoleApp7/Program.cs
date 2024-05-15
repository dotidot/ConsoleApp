// See https://aka.ms/new-console-template for more information
using System;
using System.Globalization;

Console.WriteLine("Write a C# program that creates a method that reads a date from the user in the\r\nformat \"dd/mm/yyyy\" and converts it to a DateTime object. Handle an exception if the\r\ninput format is invalid.");
Console.Write("Input: ");
var date = Console.ReadLine();

var isDate = DateTime.TryParseExact(date, "dd/mm/yyyy", System.Globalization.CultureInfo.CurrentCulture, DateTimeStyles.None, out var dateValue);
if (!isDate)
{
    throw new Exception("Not a valid date format");
}