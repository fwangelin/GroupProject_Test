using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionRepository.Models
{
    public enum Category { Kitchen = 1, LivingRoom, BathRoom, BedRoom}
    class AuctionItem
    {
        public double Price { get; set; }
        public Category Category { get; set; }
        public string Name { get; set; }
        public bool isUsed { get; set; }
        
    }
}
