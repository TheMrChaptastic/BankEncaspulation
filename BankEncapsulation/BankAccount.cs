using System;
using System.Collections.Generic;
using System.Text;

namespace BankEncapsulation
{
    public class BankAccount
    {
        private double _balance = 0;

        public double Balance
        {
            get { return Math.Round(_balance, 2); }
        }

        public void Deposit(double ammount)
        {
            _balance += ammount;
            Console.WriteLine($"Current Balance after Deposit ${Math.Round(_balance, 2)}");
        }

        public void Withdraw(double ammount)
        {
            if (ammount < _balance)
            {
                _balance -= ammount;
            }
            else Console.WriteLine($"Not enough in account (Current Balance is ${Math.Round(_balance, 2)})");
        }
    }
}
