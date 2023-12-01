using System.Collections.Generic;
using Domain;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class GildedRoseTest
    {
        [Test]
        public void BlankTest()
        {
            IList<Item> items = new List<Item>
            {
                new() { Name = "foo", SellIn = 0, Quality = 0 }
            };
             
            var app = new GildedRose(items);

            app.UpdateQuality();
            Assert.AreEqual("foo", items[0].Name);
        }
    }
}
