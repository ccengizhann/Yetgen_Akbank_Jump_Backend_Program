using Microsoft.EntityFrameworkCore;
using PathPal.Domain.Common;
using PathPal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathPal.Persistence.Contexts
{
	public class Week_8DbContext : DbContext
	{
		public DbSet<BankAccount> BankAccounts { get; set; }

		public DbSet<Passenger> Passengers { get; set; }

		public DbSet<TaxiDriver> TaxiDrivers { get; set; }


		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseNpgsql(Configurations.GetString("ConnectionStrings:PostgreSQL"));
		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Person>()
				.HasOne(p => p.Account)
				.WithOne(ba => ba.Owner)
				.HasForeignKey<BankAccount>(ba => ba.Id);
			
			base.OnModelCreating(modelBuilder);
		}
	}
}
