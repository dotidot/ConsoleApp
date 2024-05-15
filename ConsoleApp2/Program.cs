// See https://aka.ms/new-console-template for more information
Console.WriteLine("Write a C# program that prompts the user to input a numeric integer and throws an\r\nexception if the number is less than 0 or greater than 1000.");


Console.Write("Input Number: ");
int number = int.Parse(Console.ReadLine()!);

if (number < 0)
{
    throw new Exception("Number is less than 0");
}

if (number > 1000)
{
    throw new Exception("Number is greater than 1000");
}

Console.WriteLine(number);

