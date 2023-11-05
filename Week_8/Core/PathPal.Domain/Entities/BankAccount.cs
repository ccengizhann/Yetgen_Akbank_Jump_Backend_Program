using PathPal.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathPal.Domain.Entities
{
	public class BankAccount:EntityBase<Guid>
	{
		public Person? Owner { get; set; }

		public Decimal Balance { get; set; }
	}
}
