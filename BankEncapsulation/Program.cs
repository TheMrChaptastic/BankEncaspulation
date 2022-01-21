using System;

namespace BankEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double uInput = 0.0;
            var isDouble = false;
            var uWord = "";
            BankAccount myAcc = new BankAccount();

            while (uWord != "exit")
            {
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("Deposit - Withdraw - Exit");
                Console.Write("Choose an Option: ");
                uWord = Console.ReadLine();

                if (uWord.ToLower() == "deposit")
                {
                    while (isDouble == false)
                    {
                        Console.WriteLine("----------------------------------");
                        Console.Write("Enter Deposit Ammount: ");
                        isDouble = double.TryParse(Console.ReadLine(), out uInput);
                    }
                    myAcc.Deposit(uInput);
                    isDouble = false;
                    Console.WriteLine(myAcc.Balance);
                }
                else if (uWord.ToLower() == "withdraw")
                {
                    while (isDouble == false)
                    {
                        Console.WriteLine("----------------------------------");
                        Console.Write("Enter Withdraw Ammount: ");
                        isDouble = double.TryParse(Console.ReadLine(), out uInput);
                    }
                    myAcc.Withdraw(uInput);
                    isDouble = false;
                    Console.WriteLine(myAcc.Balance);
                }
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            }
        }
    }
}
