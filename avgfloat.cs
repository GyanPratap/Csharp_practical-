using System;
class Avg
{
    public static void Main()
    {
        int[] arr = { 1, 2, 6, 2, 18 };

        int i = 0;
        int sum = 0;
        float average = 0.0F;

        for (i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }

        average = (float)sum / arr.Length;

        Console.WriteLine("Average of Array elements: " + average);
    }
}