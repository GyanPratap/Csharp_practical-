using System;

class Employee
{
    public string Name { get; set; }
    public int Age { get; set; }
    public double Salary { get; set; }

    public void DisplayDetails()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Salary: Rs{Salary:F2}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Employee emp = new Employee();

        Console.Write("Enter employee name: ");
        emp.Name = Console.ReadLine();

        Console.Write("Enter employee age: ");
        emp.Age = int.Parse(Console.ReadLine());

        Console.Write("Enter employee salary: ");
        emp.Salary = double.Parse(Console.ReadLine());

        Console.WriteLine("Employee details:");
        emp.DisplayDetails();
    }
}
