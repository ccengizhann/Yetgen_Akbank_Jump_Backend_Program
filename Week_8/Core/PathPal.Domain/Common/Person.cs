﻿using PathPal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathPal.Domain.Common
{
	public class Person: EntityBase<Guid>
	{
		public string Name { get; set; }
		public string Surname { get; set; }
		public string PhoneNumber { get; set; }
		public BankAccount? Account { get; set; }


	}
}
