/*Implement a `BankAccount` class with `Deposit()` and `Withdraw()`.
 * Extend it to `SavingsAccount` with interest calculation.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicecsharp
{
    public class BankAccount
    {
        public int Balance;
        public void Deposit(int Amount)
        {
            if (Amount > 0)
            {
                Balance = Balance + Amount;
                Console.WriteLine("The balance after deposit is: " + Balance);
            }
            else
            {
                Console.WriteLine("Invalid amount");
            }
        }
        public void Withdraw(int Amount)
        {
            if (Amount > 0)
            {
                Balance = Balance - Amount;
                Console.WriteLine("The balance after withdrawal is: " + Balance);
            }
            else
            {
                Console.WriteLine("Invalid amount");
            }
        }

    }
    public class SavingsAccount : BankAccount
    {
        public void CalculateInterest()
        {
            Console.WriteLine("The interest is: " + Balance * 0.12);
        }
    }
}
