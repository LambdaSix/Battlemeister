using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Battlemeister.RealmStatus;
using NUnit.Framework;

namespace Battlemeister.Tests
{
    [TestFixture]
    public class RealmStatusTests
    {
        [Test]
        public void ReturnsObject()
        {
            IRealmStatusApi api = new RealmStatusApi(new DefaultConfig());
            var result = api.GetAll().ToList();

            Assert.That(result.Count() != 0);

            Console.WriteLine("Realms:\n {0}", String.Join("\n", result.Select(x => x.Name)));
        }
    }
}
