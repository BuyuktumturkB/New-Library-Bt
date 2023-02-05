using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Param.net
{
	public class Country
	{
		public int CountryId { get; set; }
		public string Pfirstname { get; set; }

		public string Plastname { get; set; }
		public Gender Gender { get; set; } 
		public int PassportID { get; set; } 

		public DateTime  DateofBirth { get; set; }
		public DateTime ValidateUntil { get; set; }


	}
}
