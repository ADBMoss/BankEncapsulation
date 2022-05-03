using System;
namespace BankEncapsulation
{
    public class BankAccount
    {

        private double balance = 0;


        public BankAccount()
        {

        }


        public void Deposit(double value)
        {
            balance += value;

        }

        public double GetBalance()
        {
            return balance;

        }
    }
}
