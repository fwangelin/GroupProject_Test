using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionRepository.UI
{
    class Menu
    {
        public static void ShowStartMenu()
        {   
                Console.Clear();

                Console.WriteLine("Auction Repository");
                Console.WriteLine();
                Console.WriteLine("1. Show product");
                Console.WriteLine("2. Add product");
                Console.WriteLine("3. Edit product");
                Console.WriteLine("4. Remove product");

                Console.WriteLine();
                Console.WriteLine("ESC. Exit");
        }
    }
}
