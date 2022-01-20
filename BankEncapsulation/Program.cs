using System;

namespace BankEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount myAcc = new BankAccount();
            Console.WriteLine(myAcc.Balance);
            myAcc.Deposit(120.01);
            Console.WriteLine(myAcc.Balance);
        }
    }
}
