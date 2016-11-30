using System;
using AuctionRepository.Models;
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

        public void AddBathroomToListTest()
        {
            var manager = new AuctionManager();

            manager.AddBathroomAuctions("string1", "string2", 19.90);
            Assert.AreEqual(1, manager.auctionList.Count);

        }
        [TestMethod]
        public void AddBedroomToListTest()
        {
            var manager = new AuctionManager();

            manager.AddBedroomAuctions("string1", "string2", 21.90);
            Assert.AreEqual(1, manager.auctionList.Count);

        }
        [TestMethod]
        public void AddLivingroomToListTest()
        {
            var manager = new AuctionManager();

            manager.AddLivingroomAuctions("string1", "string2", 91.90);
            Assert.AreEqual(1, manager.auctionList.Count);

        }
        [TestMethod]
        public void AddKitchenToListTest()
        {
            var manager = new AuctionManager();

            manager.AddKitchenAuctions("string1", "string2", 78.97);
            Assert.AreEqual(1, manager.auctionList.Count);


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
