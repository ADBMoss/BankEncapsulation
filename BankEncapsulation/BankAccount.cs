using System;
namespace BankEncapsulation
{
    public class BankAccount
    {

        private double _balance = 0;


        public BankAccount(double balance)
        {
            _balance = balance;
        }


        public void Deposit(double amount)
        {
            _balance += amount;

        }

        public double GetBalance()
        {
            return _balance;

        }
    }
}
