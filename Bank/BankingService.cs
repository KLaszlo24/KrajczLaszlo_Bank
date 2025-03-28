using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
	internal abstract class BankingService
	{
		Owner owner;
		public Owner Owner { get => owner; }

		public BankingService(Owner owner)
		{
			this.owner = owner;
		}
	}

}
