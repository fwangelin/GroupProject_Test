using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionRepository.Interfaces
{
	public interface IManager
	{
        void ShowAuctions(int input);
        void AddBathroomAuctions(string nameText, string used, double price);
		void AddBedroomAuctions();
		void AddLivingroomAuctions();
		void AddKitchenAuctions();

    }
}
