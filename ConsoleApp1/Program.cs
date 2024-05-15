// See https://aka.ms/new-console-template for more information
Console.WriteLine("Write a C# program that reads a file path from the user and tries to open the file.\r\nHandle exceptions if the file does not exist.");

Console.Write("input: ");

var filePath = Console.ReadLine();

if (!File.Exists(filePath))
{
    throw new Exception("File not exists");
}

File.Open(filePath, FileMode.Open);