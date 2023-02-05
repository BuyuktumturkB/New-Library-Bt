using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Param.net.Models
{
	public interface InterfaceCountry
	{
		Task<IEnumerable<Country>> Search(string name, Gender? gender);

		Task<Country> GetCountry(int countryid);
		Task<Country> GetCountry();
		Task<Country> AddPerson(Country country);
		Task<Country> UpdatePerson(Country country);
		Task<Country> DeletePerson(Country country);


	}
}
