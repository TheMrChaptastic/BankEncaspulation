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
            get { return balance; }
        }

        public void Deposit(double ammount)
        {
            balance = ammount;
        }
    }
}
