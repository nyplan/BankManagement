using BankManagement.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace BankManagement.DAL.Contexts.DataSeed
{
	public static class OrderStatusSeed
	{
		public static void Seed(ModelBuilder builder)
		{
			builder.Entity<OrderStatus>().HasData(
				new OrderStatus()
				{
					Id = 1,
					StatusKey = "Waiting",
					StatusValue = "Gözləyir"
				},
				new OrderStatus()
				{
					Id = 2,
					StatusKey = "Accepted",
					StatusValue = "Qəbul edildi"
				},
				new OrderStatus()
				{
					Id = 3,
					StatusKey = "Cancelled",
					StatusValue = "Ləğv edildi"
				}
				);
		}
	}
}
