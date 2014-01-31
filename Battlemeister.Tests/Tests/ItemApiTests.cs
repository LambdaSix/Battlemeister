using Battlemeister.ItemInformation;
using NUnit.Framework;

namespace Battlemeister.Tests
{
    [TestFixture]
    public class ItemApiTests
    {
        [Test]
        public void GetSingleItem()
        {
            var itemApi = new ItemApi(new DefaultConfig());

            var result = itemApi.Get(845);

            Assert.That(result.Name == "Tanned Leather Pants");
        }
    }
}