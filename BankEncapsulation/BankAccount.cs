using System;
namespace BankEncapsulation
{
	public class BankAccount
	{
		//Making the balance field private.
        private double balance;

		//Constructor
        public BankAccount()
		{
		}

		//Method to make a deposit.
		public void Deposit(double amount)
		{
			balance += amount;
		}

		//Method to retrieve current balance. 
		public double GetBalance()
		{
			return balance;
		}
	}
}

