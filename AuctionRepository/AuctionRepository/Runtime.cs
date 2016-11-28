using System;
using System.Threading;
using AuctionRepository.UI;
using AuctionRepository.Managers;

namespace AuctionRepository
{
    public class Runtime
    {
        public void Start()
        {
			AuctionManager auctionManager = new AuctionManager();
            //TODO: Starta programmet meny mfl

            bool isLoop = true;
            
            while (isLoop)
            {
                Menu.ShowStartMenu();

                ConsoleKey input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.D1:
						auctionManager.ShowAuctions();
						Console.ReadKey(true);
                        break;
                    case ConsoleKey.D2:
                        break;
                    case ConsoleKey.D3:
                        break;
                    case ConsoleKey.D4:
                        break;
                    case ConsoleKey.Escape:
                        isLoop = false;
                        break;
                }
            }
        }
    }
}