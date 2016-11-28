using AuctionRepository.Interfaces;
using AuctionRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionRepository.Managers
{
    class AuctionManager : IManager
    {
		List<ISellable> auctionList = new List<ISellable>
		{
			new Bathroom {Name = "Olf Dolf", Price = 2999.99, Category = Category.BathRoom, isUsed = true },
			new Bathroom {Name = "Katt", Price = 299.99, Category = Category.BathRoom, isUsed = false },
			new Bedroom {Name = "K-Stugan", Price = 29999.99, Category = Category.BedRoom, isUsed = true },
			new Bedroom {Name = "Bum Quarter", Price = 1.99, Category = Category.BedRoom, isUsed = true },
			new Kitchen {Name = "The not so tasty burger", Price = 45.99, Category = Category.Kitchen, isUsed = false },
			new Kitchen {Name = "Help me sergeant!", Price = 7999.99, Category = Category.Kitchen, isUsed = true },
			new Livingroom {Name = "So cozy", Price = 892999.99, Category = Category.BathRoom, isUsed = false },
			new Livingroom {Name = "Flanders", Price = 699.99, Category = Category.BathRoom, isUsed = false }

		};

		public void ShowAuctions()
		{
			for (int i = 0; i < auctionList.Count; i++)
			{
				Console.WriteLine(auctionList[i]);
			}
		}
    }
}
