using System.Linq;
using Battlemeister.AuctionInformation;
using NUnit.Framework;

namespace Battlemeister.Tests
{
    [TestFixture]
    public class AuctionTests
    {
         
        [Test]
        public void AuctionApi()
        {
            var auction = new AuctionApi(new DefaultConfig());

            var result = auction.Get("medivh");
            Assert.That(result.Alliance.Auctions.Count() != 0);
        }
    }
}