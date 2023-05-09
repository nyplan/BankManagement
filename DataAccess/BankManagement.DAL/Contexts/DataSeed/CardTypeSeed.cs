using BankManagement.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace BankManagement.DAL.Contexts.DataSeed
{
	//this Class help Seeding CardTypes
	public static class CardTypeSeed
	{
		public static void Seed(this ModelBuilder builder)
		{
			builder.Entity<CardType>().HasData(
				new CardType()
				{
					Id= 1,
					Name = "Bir Kart",
					BankId = 1,
					Comission=10,
					CashBack=0,
					ExpireYear=3,
					MaxCapacity=10000
				},

				new CardType()
				{
					Id = 2,
					Name= "Premium Kart",
					BankId = 1,
					Comission=0,
					CashBack=5,
                    ExpireYear = 5,
                    MaxCapacity =5000
				},
				new CardType()
				{
					Id=3,
					Name= "Tam Kart",
					BankId = 2,
					Comission=5,
                    ExpireYear = 3,
                    CashBack =0,
					MaxCapacity=20000
				},
				new CardType()
				{
					Id=4,
					Name = "Gənc Kart",
					BankId = 2,
					Comission=0,
                    ExpireYear = 5,
                    CashBack =10,
					MaxCapacity=10000
				},
				new CardType()
				{
					Id=5,
					Name= "Mərkəz Kart",
					BankId = 3,
					Comission=5,
                    ExpireYear = 3,
                    CashBack =0,
					MaxCapacity=100000
				});
		}

	}
}
