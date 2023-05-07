using BankManagement.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
					MaxCapacity=10000,
					CreatedAt = DateTime.Now //this code will add added time to CreatedAt column
				},

				new CardType()
				{
					Id = 2,
					Name= "Premium Kart",
					BankId = 1,
					Comission=0,
					CashBack=5,
					MaxCapacity=5000,
					CreatedAt = DateTime.Now
				},
				new CardType()
				{
					Id=3,
					Name= "Tam Kart",
					BankId = 2,
					Comission=5,
					CashBack=0,
					MaxCapacity=20000,
					CreatedAt = DateTime.Now
				},
				new CardType()
				{
					Id=4,
					Name = "Gənc Kart",
					BankId = 2,
					Comission=0,
					CashBack=10,
					MaxCapacity=10000,
					CreatedAt = DateTime.Now
				},
				new CardType()
				{
					Id=5,
					Name= "Mərkəz Kart",
					BankId = 3,
					Comission=5,
					CashBack=0,
					MaxCapacity=100000,
					CreatedAt = DateTime.Now
				}

				);
		}

	}
}
