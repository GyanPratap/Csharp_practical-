using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 5, 2, 8, 1, 9, 3 };

        Console.WriteLine("Original array:");
        PrintArray(numbers);

        Console.WriteLine("\nArray in reverse order:");
        PrintReverseArray(numbers);
    }

    static void PrintArray(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }

    static void PrintReverseArray(int[] arr)
    {
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }
}
