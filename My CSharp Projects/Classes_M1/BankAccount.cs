using System;

namespace Classes_M1;

public class BankAccount
{
    private static int s_nextAccountNumber = 1;
    public readonly int AccountNumber;
    public static double InterestRate;
    public double Balance = 0.0;
    public string AccountType = "Checking";
    public readonly string CustomerId;

    static BankAccount()
    {
        Random random = new();
        s_nextAccountNumber = random.Next(10000000, 20000000);
        InterestRate = 0;
    }

    public BankAccount(string customerIdNumber)
    {
        CustomerId = customerIdNumber;
        AccountNumber = s_nextAccountNumber++;
    }

    public BankAccount(string customerIdNumber, double balance, string accountType)
    {
        CustomerId = customerIdNumber;
        Balance = balance;
        AccountType = accountType;
        AccountNumber = s_nextAccountNumber++;
    }
}
