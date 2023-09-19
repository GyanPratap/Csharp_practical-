using System;

class BankAccount
{
    public string AccountNumber { get; set; }
    public string AccountHolderName { get; set; }
    public double Balance { get; private set; }

    public BankAccount(string accountNumber, string accountHolderName, double initialBalance)
    {
        AccountNumber = accountNumber;
        AccountHolderName = accountHolderName;
        Balance = initialBalance;
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            Console.WriteLine($"Deposited Rs{amount:F2}. New balance: Rs{Balance:F2}");
        }
        else
        {
            Console.WriteLine("Invalid deposit amount.");
        }
    }

    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= Balance)
        {
            Balance -= amount;
            Console.WriteLine($"Withdrawn Rs{amount:F2}. New balance: Rs{Balance:F2}");
        }
        else
        {
            Console.WriteLine("Invalid withdrawal amount or insufficient balance.");
        }
    }

    public void DisplayAccountDetails()
    {
        Console.WriteLine($"Account Number: {AccountNumber}");
        Console.WriteLine($"Account Holder Name: {AccountHolderName}");
        Console.WriteLine($"Balance: Rs{Balance:F2}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter account number: ");
        string accountNumber = Console.ReadLine();

        Console.Write("Enter account holder name: ");
        string accountHolderName = Console.ReadLine();

        Console.Write("Enter initial balance: ");
        double initialBalance = double.Parse(Console.ReadLine());

        BankAccount account = new BankAccount(accountNumber, accountHolderName, initialBalance);

        Console.WriteLine("Account created successfully!");

        while (true)
        {
            Console.WriteLine("Select an option:");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Display Account Details");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter deposit amount: ");
                    double depositAmount = double.Parse(Console.ReadLine());
                    account.Deposit(depositAmount);
                    break;
                case 2:
                    Console.Write("Enter withdrawal amount: ");
                    double withdrawalAmount = double.Parse(Console.ReadLine());
                    account.Withdraw(withdrawalAmount);
                    break;
                case 3:
                    account.DisplayAccountDetails();
                    break;
                case 4:
                    Console.WriteLine("Exiting program.");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;
            }
        }
    }
}
