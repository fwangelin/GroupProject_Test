using System;
using System.Threading;
using AuctionRepository.UI;
using AuctionRepository.Managers;

namespace AuctionRepository
{
    public class Runtime
    {
        private int inputChoice;
        
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
                        Console.WriteLine("Press to show bathroom.");

                        try
                        {
                            inputChoice = int.Parse(Console.ReadLine());
                        }

                        catch(FormatException)
                        {
                            Console.WriteLine("Insert a number: ");
                        }

						auctionManager.ShowAuctions(inputChoice);
						Console.ReadKey(true);
                        break;
                    case ConsoleKey.D2:
						Console.WriteLine("Add Bathroom");
						Console.WriteLine("Type in product name");
						string nameInput = Console.ReadLine();
						Console.WriteLine("Type in price");
						double price = double.Parse(Console.ReadLine());
						Console.WriteLine("Type in if the item is used");
						string usedInput = Console.ReadLine();
						auctionManager.AddBathroomAuctions(nameInput, usedInput, price);
						Console.ReadKey(true);
                        break;
                    case ConsoleKey.D3:
                        // Edit products
                        break;
                    case ConsoleKey.D4:

                        break;
                    case ConsoleKey.D5:
                        //Filters
                        break;
                    case ConsoleKey.Escape:
                        isLoop = false;
                        break;
                }
            }
        }

        public void FilterMenu()
        {

        }
    }
}