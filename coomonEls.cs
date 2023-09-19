using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array1 = { 5, 2, 8, 1, 9 };
        int[] array2 = { 3, 8, 5, 4, 6 };

        int[] commonElements = FindCommonElements(array1, array2);

        Console.WriteLine("Array 1:");
        PrintArray(array1);

        Console.WriteLine("\nArray 2:");
        PrintArray(array2);

        Console.WriteLine("\nCommon elements:");
        PrintArray(commonElements);
    }

    static int[] FindCommonElements(int[] arr1, int[] arr2)
    {
        int maxSize = Math.Max(arr1.Length, arr2.Length);
        int[] common = new int[maxSize];
        int commonCount = 0;

        foreach (int num1 in arr1)
        {
            foreach (int num2 in arr2)
            {
                if (num1 == num2)
                {
                    common[commonCount] = num1;
                    commonCount++;
                    break; // Move to the next number in the outer loop
                }
            }
        }

        // Create a new array with only the common elements
        int[] result = new int[commonCount];
        Array.Copy(common, result, commonCount);

        return result;
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
