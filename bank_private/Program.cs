using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_private
{
    public class bankaccount
    {
        private decimal balance;

        public decimal Balance
        {
            get { return balance; }
        }

        public void Deposit(decimal amount)
        {

            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Deposite: {amount:c}");
            }


            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }

        
        public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Withdrawn: {amount:C}");
            }
            else
            {
                Console.WriteLine("Insufficient funds or invalid withdrawal amount.");
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            bankaccount account = new bankaccount();


            account.Deposit(100);
            Console.WriteLine($"Current Balance: {account.Balance:C}");


            account.Withdraw(50);
            Console.WriteLine($"Current Balance: {account.Balance:C}");


            account.Withdraw(60);


            Console.WriteLine($"Final Balance: {account.Balance:C}");
            Console.ReadKey();
        }
    }
}


