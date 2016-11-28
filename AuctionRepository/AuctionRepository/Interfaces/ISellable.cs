
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionRepository.Interfaces
{
	public enum Category { Kitchen = 1, LivingRoom, BathRoom, BedRoom }

	interface ISellable
    {
		 double Price { get; set; }
		 Category Category { get; set; }
		 string Name { get; set; }
		 bool isUsed { get; set; }

		 string ShowAuctionInfo();


		}
	}

