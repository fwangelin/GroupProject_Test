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
		public bool IsExpensive(AuctionItem auctionItem)
		{
			return false;
		}

		public bool IsCheap(AuctionItem auctionItem)
		{
			return false;
		}

		public bool IsKitchen(AuctionItem auctionItem)
		{
			return false;
		}

		public bool IsBathroom(AuctionItem auctionItem)
		{
			return false;
		}

		public bool IsLivingroom(AuctionItem auctionItem)
		{
			return false;
		}

		public bool IsBedroom(AuctionItem auctionItem)
		{
			return false;
		}
	}
}
