using System;
using System.Collections.Generic;

namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAcccount();
            
            //account.balance = 300;
            Console.WriteLine("How much would you like to deposit?");
            var deposit = double.Parse(Console.ReadLine());
            
            account.Deposit(deposit);
            
            Console.WriteLine($"Your new balance = {account.GetBalance()}");
        }
    }
}
