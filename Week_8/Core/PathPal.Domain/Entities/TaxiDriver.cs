﻿using PathPal.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathPal.Domain.Entities
{
	public class TaxiDriver: Person
	{
		public string LicencePlate { get; set; }
	}
}
