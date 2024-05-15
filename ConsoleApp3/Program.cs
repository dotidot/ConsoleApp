// See https://aka.ms/new-console-template for more information
Console.WriteLine("Write a C# program that implements a method that takes an array of integers as input\r\nand calculates the average value. Handle the exception if the array is empty.");

int[] arr = { 1, 2, 3 };

CalculateAverage(arr);


int CalculateAverage(int[] arr)
{
    if (arr.Length == 0)
    {
        throw new Exception("Array is empty");
    }


    var total = arr.Sum(x => x);
    var result = total / arr.Length;

    return result;
}