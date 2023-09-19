using System;

class BankAccount
{
    public string AccountNumber { get; }
    public double Balance { get; protected set; }

    public BankAccount(string accountNumber, double balance)
    {
        AccountNumber = accountNumber;
        Balance = balance;
    }
}

sealed class SavingsAccount : BankAccount
{
    public double InterestRate { get; }

    public SavingsAccount(string accountNumber, double balance, double interestRate)
        : base(accountNumber, balance)
    {
        InterestRate = interestRate;
    }

    public void CalculateInterest()
    {
        double interest = Balance * (InterestRate / 100);
        Balance += interest;
        Console.WriteLine($"Interest calculated: {interest:C}. New balance: {Balance:C}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter account number: ");
        string accountNumber = Console.ReadLine();

        Console.Write("Enter initial balance: ");
        double initialBalance = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter interest rate (%): ");
        double interestRate = Convert.ToDouble(Console.ReadLine());

        SavingsAccount savingsAccount = new SavingsAccount(accountNumber, initialBalance, interestRate);

        Console.WriteLine($"Initial balance: {savingsAccount.Balance:C}");

        savingsAccount.CalculateInterest();
        Console.WriteLine($"Balance after interest: {savingsAccount.Balance:C}");
    }
}
