using System.Collections.Generic;
using Domain;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class QualityControlTest
    {
        [Test]
        public void BlankTest()
        {
            IList<Item> items = new List<Item>
            {
                new() { Name = "foo", SellIn = 0, Quality = 0 }
            };
             
            var app = new QualityControl(items);

            app.Update();
            Assert.AreEqual("foo", items[0].Name);
        }
    }
}
