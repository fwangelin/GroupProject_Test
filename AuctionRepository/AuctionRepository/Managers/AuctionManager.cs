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
			new Bathroom {Name = "Olf Dolf", Price = 2999.99, Category = Category.BathRoom, ItemUsed = "yes" },
			new Bathroom {Name = "Katt", Price = 299.99, Category = Category.BathRoom, ItemUsed = "no" },
			new Bedroom {Name = "K-Stugan", Price = 29999.99, Category = Category.BedRoom, ItemUsed = "yes" },
			new Bedroom {Name = "Bum Quarter", Price = 1.99, Category = Category.BedRoom, ItemUsed = "yes" },
			new Kitchen {Name = "The not so tasty burger", Price = 45.99, Category = Category.Kitchen, ItemUsed = "no" },
			new Kitchen {Name = "Help me sergeant!", Price = 7999.99, Category = Category.Kitchen, ItemUsed = "yes" },
			new Livingroom {Name = "So cozy", Price = 892999.99, Category = Category.BathRoom, ItemUsed = "no" },
			new Livingroom {Name = "Flanders", Price = 699.99, Category = Category.BathRoom, ItemUsed = "no" }

		};

		public void ShowAuctions(int input)
		{
            if (input == 1)
            {
                foreach (var i in auctionList.Where(p => p.Category == Category.BathRoom))
                {
                    Console.WriteLine(i);
                }
            }
		}

        public void ShowAll()
        {
            for (int i = 0; i < auctionList.Count; i++)
            {
                Console.WriteLine(auctionList[i]);
            }

        }

		public void AddBathroomAuctions(string nameText, string used, double price)
		{
			Bathroom newBathroom = new Bathroom();
			newBathroom.Name = nameText;
			newBathroom.Price = price;
			newBathroom.Category = Category.BathRoom;
			newBathroom.ItemUsed = used;
			auctionList.Add(newBathroom);
		}

		public void AddBedroomAuctions()
		{
			Bedroom newBathroom = new Bedroom();
		}

		public void AddLivingroomAuctions()
		{
			Livingroom newBathroom = new Livingroom();
		}

		public void AddKitchenAuctions()
		{
			Kitchen newBathroom = new Kitchen();
		}
	}
}
