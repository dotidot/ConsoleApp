// See https://aka.ms/new-console-template for more information
Console.WriteLine("Write a C# program that implements a method that divides two numbers. Handle the\r\nDivideByZeroException that occurs if the denominator is 0.");

int numerator = 2, denominator = 3;

DivideTwoNumber(numerator, denominator);


decimal DivideTwoNumber(int numerator, int denominator)
{
    if (denominator == 0)
    {
        throw new DivideByZeroException("Not allowed");
    }

    return numerator / denominator;
}