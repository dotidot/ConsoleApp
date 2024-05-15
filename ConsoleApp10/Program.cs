// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.Write("Input: ");
var input = Console.ReadLine();

var isValidInt = int.TryParse(input, out var inputAsInt);

if (isValidInt)
{
   var result = CalculateFactorial(inputAsInt);
    Console.Write(result);
} 

int CalculateFactorial(int num)
{
	try
	{
        var result = num;
        for (int i = 1; i < num; i++)
        {
            result *= (num - i);
        }

        return result;
    }
	catch (OverflowException ex)
	{

		throw ex;
	}

}
