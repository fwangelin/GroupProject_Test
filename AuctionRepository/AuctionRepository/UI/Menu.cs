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
                Console.WriteLine("5. Filters");

                Console.WriteLine();
                Console.WriteLine("ESC. Exit");
        }

        public static void FilterMenuGraphics()
        {
            Console.Clear();
            Console.WriteLine("Filters:");
            Console.WriteLine();
            Console.WriteLine("1. Products over 2000:-");
            Console.WriteLine("2. Products under 500:-");
            Console.WriteLine("3. Kitchen products");
            Console.WriteLine("4. Bathroom products");
            Console.WriteLine("5. Livingroom products");
            Console.WriteLine("6. Bedroom products");
            Console.WriteLine();
            Console.WriteLine("ESC. Exit");
        }
    }
}
