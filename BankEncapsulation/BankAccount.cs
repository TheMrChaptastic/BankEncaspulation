using System;
using System.Collections.Generic;
using System.Text;

namespace BankEncapsulation
{
    public class BankAccount
    {
        private double balance = 0;

        public double Balance
        {
            get { return Math.Round(balance, 2); }
        }

        public void Deposit(double ammount)
        {
            balance += ammount;
        }

        public void Withdraw(double ammount)
        {
            if (ammount < balance)
            {
                balance -= ammount;
            }
            else Console.WriteLine("Not enough in account");
        }
    }
}
