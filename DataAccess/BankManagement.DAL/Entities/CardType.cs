using BankManagement.DAL.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement.DAL.Entities
{
	public class CardType : BaseEntity
	{
		public string Name { get; set; }
		public double Comission { get; set; }
		public double CashBack { get; set; }
		public double MaxCapacity { get; set; }
		public int BankId { get; set; }
		public Bank Bank { get; set; }

		//reliationships here:

		//User and Card have one-to-one reliationship.
		//New Class: which contains CardTypeId and UserId also have CardNumber, CCV, ExpirationDate, OwnerName. 
		// These Properties are uniques for every users. So Cannot be in CardType Class(Table). New Class: (UserCard : BaseCard) => CardTypeId, UserId
		// 

	}
}
