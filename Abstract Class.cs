using System;

// Abstract base class
public abstract class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public abstract void MakeSound();
}

// Derived class for Dog
public class Dog : Animal
{
    public Dog(string name, int age) : base(name, age)
    {
    }

    public override void MakeSound()
    {
        Console.WriteLine("Dog barks: Woof woof!");
    }

    public void Fetch()
    {
        Console.WriteLine("Dog fetches the ball.");
    }
}

// Derived class for Cat
public class Cat : Animal
{
    public Cat(string name, int age) : base(name, age)
    {
    }

    public override void MakeSound()
    {
        Console.WriteLine("Cat meows: Meow meow!");
    }

    public void Climb()
    {
        Console.WriteLine("Cat climbs a tree.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Select an animal:");
        Console.WriteLine("1. Dog");
        Console.WriteLine("2. Cat");
        Console.Write("Enter your choice (1 or 2): ");
        int choice = int.Parse(Console.ReadLine());

        Console.Write("Enter the name of the animal: ");
        string name = Console.ReadLine();

        Console.Write("Enter the age of the animal: ");
        int age = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            Dog dog = new Dog(name, age);
            dog.MakeSound();
            dog.Fetch();
        }
        else if (choice == 2)
        {
            Cat cat = new Cat(name, age);
            cat.MakeSound();
            cat.Climb();
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }
    }
}
