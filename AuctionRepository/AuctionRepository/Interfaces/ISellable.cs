
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionRepository.Interfaces
{
	public enum Category { Kitchen = 1, LivingRoom, BathRoom, BedRoom }

	public interface ISellable
    {
		 double Price { get; set; }
		 Category Category { get; set; }
		 string Name { get; set; }
		 string ItemUsed { get; set; }

		 string ToString();


		}
	}

