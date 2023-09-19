using System;

static class MathHelper
{
    public static double CalculateAverage(int[] numbers)
    {
        if (numbers.Length == 0)
        {
            throw new ArgumentException("Input array is empty.");
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        return (double)sum / numbers.Length;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of values: ");
        int count = int.Parse(Console.ReadLine());

        int[] values = new int[count];
        for (int i = 0; i < count; i++)
        {
            Console.Write($"Enter value {i + 1}: ");
            values[i] = int.Parse(Console.ReadLine());
        }

        double average = MathHelper.CalculateAverage(values);
        Console.WriteLine($"Average: {average:F2}");
    }
}
