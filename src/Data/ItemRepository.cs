using Domain.Interfaces;
using Domain.Items;

namespace Data
{
    public class ItemRepository : IGetItemRepository
    {
        public IList<SaleableItem> GetAllItems()
        {
            var items = new List<SaleableItem>
            {
                new() { Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20 },
                new AgedBrie { Name = "Aged Brie", SellIn = 2, Quality = 0 },
                new() { Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7 },
                new Sulfuras { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80 },
                new Sulfuras { Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = 80 },
                new BackstageConcertTicket
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 15,
                    Quality = 20
                },
                new BackstageConcertTicket
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 10,
                    Quality = 49
                },
                new BackstageConcertTicket
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 5,
                    Quality = 49
                },

                new() { Name = "Conjured Mana Cake", SellIn = 3, Quality = 6 }
            };

            return items;
        }
    }
}
