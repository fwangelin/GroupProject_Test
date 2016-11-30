using AuctionRepository.Interfaces;
using AuctionRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionRepository.Filters
{

	public delegate bool ListFilters(AuctionItem auctionItem);

	class Filter
	{
		public static bool IsExpensive(AuctionItem auctionItem)
		{
           return auctionItem.Price > 2000.00;
		}

		public bool IsCheap(AuctionItem auctionItem)
		{
            return auctionItem.Price <= 500.00;
		}

		public bool IsKitchen(AuctionItem auctionItem)
		{
            return auctionItem.Category == Category.Kitchen;
        }

		public bool IsBathroom(AuctionItem auctionItem)
		{
            return auctionItem.Category == Category.BathRoom;
            
        }

		public bool IsLivingroom(AuctionItem auctionItem)
		{
            return auctionItem.Category == Category.LivingRoom;
        }

		public bool IsBedroom(AuctionItem auctionItem)
		{
            return auctionItem.Category == Category.BedRoom;
		}
	}
}
