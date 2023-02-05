using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Param.net.Models
{
	public class DataBase:DbContext
	{
		public DataBase(DbContextOptions<DataBase> options)
			: base(options)
		{

		}
		public DbSet<Country> Countries { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<Country>().HasData(
				new Country
				{
					CountryId = 0001,
					Pfirstname = " Ali Murat",
					Plastname = "Bilir",
					PassportID = 1243542,
					DateofBirth = new DateTime(2000, 03, 22),
					ValidateUntil = new DateTime(2025, 06, 18),
					Gender = Gender.Male

				}
				);
				modelBuilder.Entity<Country>().HasData(
				new Country
				{
					CountryId = 0022,
					Pfirstname = " Sarah",
					Plastname = "Hopkins",
					PassportID = 21614451,
					DateofBirth = new DateTime(1944, 12, 25),
					ValidateUntil = new DateTime(2024, 01, 23),
					Gender = Gender.Female

				}
				);
			modelBuilder.Entity<Country>().HasData(
				new Country
				{
					CountryId = 0022,
					Pfirstname = " Jeremy",
					Plastname = "Perkins",
					PassportID = 216427880,
					DateofBirth = new DateTime(1989, 03, 12),
					ValidateUntil = new DateTime(2030, 12, 11),
					Gender = Gender.Male

				}
				);
		}
	}

}
