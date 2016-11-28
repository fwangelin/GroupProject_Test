using AuctionRepository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionRepository.Models
{
    

	public class AuctionItem: ISellable
    {
		public double Price { get; set; }
		public Category Category { get; set; }
		public string Name { get; set; }
		public bool isUsed { get; set; }

		public string ShowAuctionInfo()
		{
			return string.Format("{0} Price: {1} Category: {2} Is used: {3}",
				Name,
				Price,
				Category,
				isUsed
				);
		}
	}
}
