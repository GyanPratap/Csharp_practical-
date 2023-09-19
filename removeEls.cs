using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 5, 2, 8, 1, 9, 3, 2, 5, 8 };

        int[] uniqueNumbers = RemoveDuplicates(numbers);

        Console.WriteLine("Original array:");
        PrintArray(numbers);

        Console.WriteLine("\nArray with duplicates removed:");
        PrintArray(uniqueNumbers);
    }

    static int[] RemoveDuplicates(int[] arr)
    {
        return arr.Distinct().ToArray();
    }

    static void PrintArray(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
