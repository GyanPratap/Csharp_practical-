using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 5, 2, 8, 1, 9, 3 };

        Console.Write("Enter the number to search for: ");
        int target = int.Parse(Console.ReadLine());

        int index = FindElementIndex(numbers, target);

        if (index != -1)
        {
            Console.WriteLine($"The number {target} was found at index {index}.");
        }
        else
        {
            Console.WriteLine($"The number {target} was not found in the array.");
        }
    }

    static int FindElementIndex(int[] arr, int target)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == target)
            {
                return i;
            }
        }
        return -1; // Element not found
    }
}
