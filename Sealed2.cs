using System;

public class Vehicle
{
    public void StartEngine()
    {
        Console.WriteLine("Engine started.");
    }

    public void StopEngine()
    {
        Console.WriteLine("Engine stopped.");
    }
}

public sealed class Car : Vehicle
{
    // Additional properties and methods specific to Car can be added here
}

class Program
{
    static void Main(string[] args)
    {
        Car car = new Car();
        car.StartEngine();
        car.StopEngine();
    }
}
