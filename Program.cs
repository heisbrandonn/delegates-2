using ATM;
using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        Atm atm = new Atm();

        // Subscribe to withdrawal event
        atm.OnWithdraw += HandleWithdrawal;

        // Subscribe to deposit event
        atm.OnDeposit += HandleDeposit;

        // Simulate transactions
        atm.Withdraw(100);
        atm.Deposit(500);
        atm.Withdraw(-50); // Invalid withdrawal amount
    }

    static void HandleWithdrawal(string message)
    {
        Console.WriteLine($"Handling Withdrawal: {message}");
    }

    static void HandleDeposit(string message)
    {
        Console.WriteLine($"Handling Deposit: {message}");
    }
}