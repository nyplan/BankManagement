using BankManagement.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace BankManagement.DAL.Contexts.FluentAPIs
{

	//this class make FluentAPIs for CardType class
	public static class CardTypeFluentAPI
	{
		public static void Fluent(ModelBuilder builder)
		{
			var entity = builder.Entity<CardType>();

			entity.Property(u => u.MaxCapacity).HasColumnType("decimal(12,2)");
			entity.Property(u => u.Comission).HasColumnType("decimal(10,2)");
			entity.Property(u => u.CashBack).HasColumnType("decimal(10,2)");

		}
	}
}
