using System;
using AuctionRepository.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AuctionRepository.Managers;
using AuctionRepository.Models;

namespace UnitTest
{
    [TestClass]
    public class AuctionManagerUnitTest
    {
        [TestMethod]
        public void AddBathRoomAuctionListTest()
        {

            //Arrange
            AuctionManager manager = new AuctionManager();

            //Act

            manager.auctionList.Add(new Bathroom() { Category = Category.BathRoom, ItemUsed = "true", Name = "hej", Price = 90.0 });

            //Assert
            Assert.AreEqual(manager.auctionList[0].Category = Category.BathRoom, manager.auctionList[0].Category = Category.BathRoom);
            
        }
    }
}
