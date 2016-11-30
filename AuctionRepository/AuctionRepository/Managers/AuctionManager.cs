using AuctionRepository.Interfaces;
using AuctionRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionRepository.Managers
{
   public class AuctionManager : IManager
    {
		public List<ISellable> auctionList = new List<ISellable>
		{
			//new Bathroom {Name = "Olf Dolf", Price = 2999.99, Category = Category.BathRoom, ItemUsed = "yes" },
			//new Bathroom {Name = "Katt", Price = 299.99, Category = Category.BathRoom, ItemUsed = "no" },
			//new Bedroom {Name = "K-Stugan", Price = 29999.99, Category = Category.BedRoom, ItemUsed = "yes" },
			//new Bedroom {Name = "Bum Quarter", Price = 1.99, Category = Category.BedRoom, ItemUsed = "yes" },
			//new Kitchen {Name = "The not so tasty burger", Price = 45.99, Category = Category.Kitchen, ItemUsed = "no" },
			//new Kitchen {Name = "Help me sergeant!", Price = 7999.99, Category = Category.Kitchen, ItemUsed = "yes" },
			//new Livingroom {Name = "So cozy", Price = 892999.99, Category = Category.BathRoom, ItemUsed = "no" },
			//new Livingroom {Name = "Flanders", Price = 699.99, Category = Category.BathRoom, ItemUsed = "no" }

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

		public void AddBedroomAuctions(string nameText, string used, double price)
		{
			Bedroom newBedroom = new Bedroom();
            newBedroom.Name = nameText;
            newBedroom.Price = price;
            newBedroom.Category = Category.BedRoom;
            newBedroom.ItemUsed = used;
            auctionList.Add(newBedroom);
        }

		public void AddLivingroomAuctions(string nameText, string used, double price)
		{
			Livingroom newLivingroom = new Livingroom();
            newLivingroom.Name = nameText;
            newLivingroom.Price = price;
            newLivingroom.Category = Category.LivingRoom;
            newLivingroom.ItemUsed = used;
            auctionList.Add(newLivingroom);
        }

		public void AddKitchenAuctions(string nameText, string used, double price)
		{
			Kitchen newKitchen = new Kitchen();
            newKitchen.Name = nameText;
            newKitchen.Price = price;
            newKitchen.Category = Category.Kitchen;
            newKitchen.ItemUsed = used;
            auctionList.Add(newKitchen);
        }
	}
}
