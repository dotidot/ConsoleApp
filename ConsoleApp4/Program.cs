// See https://aka.ms/new-console-template for more information
Console.WriteLine("Write a C# program that reads a string from the user and converts it to an integer.\r\nHandle the exception if the input cannot be parsed into an integer.");

Console.Write("Input: ");
var input = Console.ReadLine();

var isNumber = int.TryParse(input, out var value);

if (!isNumber)
{
    throw new Exception("Not a number");
}

Console.WriteLine(value);
