// See https://aka.ms/new-console-template for more information
Console.WriteLine("Write a C# program that creates a method that takes a string as input and converts it\r\nto uppercase. Handle the NullReferenceException that occurs if the input string is\r\nnull.");

Console.Write("Input: ");

var input = Console.ReadLine();

if (input is null)
{
    throw new NullReferenceException("Invalid input");
}

Console.Write(input.ToUpper());