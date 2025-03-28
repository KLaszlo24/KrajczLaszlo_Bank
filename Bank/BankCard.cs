using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
	internal class BankCard : BankingService
	{
		string accountBalance;
		string cardNumber;

		public string CardNumber { get; }
		public double AccountBalance { get; }

		public BankCard(Owner owner, string accountBalance, string cardNumber) : base(owner)
		{
			this.accountBalance = accountBalance;
			this.cardNumber = cardNumber;
		}

		public bool Purchase(double amount)
		{
			if(accountBalance - amount >= 0)
			{
				accountBalance -= amount;
			}
		}
	}
}
