// See https://aka.ms/new-console-template for more information
Console.WriteLine("Write a C# program that reads a list of integers from the user. Handle the exception\r\nthat occurs if the user enters a value outside the range of Int32.");


Console.Write("Input: ");
var input = Console.ReadLine();

var arr = input!.Split(",");

foreach (var item in arr)
{
    var isNumber = int.TryParse(item, out var value);
    if (!isNumber)
    {
        throw new Exception("Not a number");
    }
}