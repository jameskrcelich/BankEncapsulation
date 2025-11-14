using System;
using System.Collections.Generic;

namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAcccount();
            double deposit = 0;

            do
            {
                Console.WriteLine("How much would you like to deposit? (Enter 0 to exit)");
                deposit = double.Parse(Console.ReadLine());

                if (deposit <= 0)
                {
                    break;
                }

                account.Deposit(deposit);
                Console.WriteLine($"You successfully deposited ${deposit}");
                Console.WriteLine($"Your new balance = {account.GetBalance()}");

            } while (deposit >= 0);

        }
    }
}
