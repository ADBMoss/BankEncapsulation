using System;

namespace BankEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var bankAccount = new BankAccount(100);
            Console.Write("How much would you like to deposit? :$");
            double amount = double.Parse(Console.ReadLine());
            bankAccount.Deposit(amount);
            Console.WriteLine($"Your new balance is: {bankAccount.GetBalance()}");


        }



    }
}
