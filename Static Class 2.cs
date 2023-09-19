using System;

static class Logger
{
    public static void LogMessage(string message)
    {
        Console.WriteLine($"[Log] {DateTime.Now}: {message}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a message to log: ");
        string inputMessage = Console.ReadLine();

        Logger.LogMessage(inputMessage);

        Console.WriteLine("Message logged successfully.");
    }
}
