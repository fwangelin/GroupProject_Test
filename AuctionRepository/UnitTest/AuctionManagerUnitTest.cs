using System;
using AuctionRepository.Models;
using AuctionRepository.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AuctionRepository.Managers;

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

        }
    }
}
