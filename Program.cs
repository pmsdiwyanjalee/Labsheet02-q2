using System;

class BankAccount
{
    public string AccountNumber { get; private set; }
    public decimal Balance { get; private set; }

    public BankAccount(string accountNumber, decimal balance = 0)
    {
        AccountNumber = accountNumber;
        Balance = balance;
    }

    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            Console.WriteLine("Deposit successful.");
            Console.WriteLine("Updated balance: " + Balance);
        }
        else
        {
            Console.WriteLine("Invalid deposit amount.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        BankAccount account = new BankAccount("123456789");

        Console.Write("Enter the deposit amount: ");
        decimal depositAmount;
        if (decimal.TryParse(Console.ReadLine(), out depositAmount))
        {
            account.Deposit(depositAmount);
        }
        else
        {
            Console.WriteLine("Invalid input.");
        }
    }
}