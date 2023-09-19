// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 5, 2, 8, 1, 9, 3 };

        int smallest = int.MaxValue;
        int secondSmallest = int.MaxValue;

        foreach (int num in numbers)
        {
            if (num < smallest)
            {
                secondSmallest = smallest;
                smallest = num;
            }
            else if (num < secondSmallest && num != smallest)
            {
                secondSmallest = num;
            }
        }

        if (secondSmallest == int.MaxValue)
        {
            Console.WriteLine("There is no second smallest number.");
        }
        else
        {
            Console.WriteLine("The second smallest number is: " + secondSmallest);
        }
    }
}


