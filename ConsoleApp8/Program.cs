// See https://aka.ms/new-console-template for more information
Console.WriteLine("Write a C# program that reads a number from the user and calculates its square root.\r\nHandle the exception if the number is negative.");
Console.Write("Input: ");

var input = Console.ReadLine();

var isNumber = int.TryParse(input, out var value);

if (!isNumber)
{
    throw new Exception("Not a valid number");
}

if (value < 0)
{
    throw new Exception("Negative number not allowed");
}

Console.Write(value * value);