using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class Atm
    {
        public delegate void TransactionHandler(string message);

        public event TransactionHandler OnWithdraw; // Event for withdrawal
        public event TransactionHandler OnDeposit;  // Event for deposit

        public void Withdraw(decimal amount)
        {
            // Check if withdrawal is possible
            if (amount > 0)
            {
                // Perform withdrawal
                OnWithdraw?.Invoke($"Withdrawal of {amount:C} successful.");
            }
            else
            {
                OnWithdraw?.Invoke("Invalid withdrawal amount.");
            }
        }

        public void Deposit(decimal amount)
        {
            // Check if deposit amount is valid
            if (amount > 0)
            {
                // Perform deposit
                OnDeposit?.Invoke($"Deposit of {amount:C} successful.");
            }
            else
            {
                OnDeposit?.Invoke("Invalid deposit amount.");
            }
        }
    }
}