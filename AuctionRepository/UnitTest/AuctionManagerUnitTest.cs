using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AuctionRepository.Managers;

namespace UnitTest
{
	[TestClass]
	public class AuctionManagerUnitTest
	{
		[TestMethod]
		public void AddBathRoomAuctionTest()
		{
            AuctionManager manager = new AuctionManager();
            manager.AddBathroomAuctions("tjofräs", "hejEmir", 1982.98);
            Assert.AreEqual();
		}
	}
}
