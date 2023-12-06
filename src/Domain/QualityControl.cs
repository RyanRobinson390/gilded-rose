using Domain.Items;

namespace Domain
{
    public class QualityControl
    {
        readonly IList<Item> _items;

        public QualityControl(IList<Item> items)
        {
            _items = items;
        }

        public void Update()
        {
            foreach (var item in _items)
            {
                if (item.Name == "Aged Brie")
                {
                    ((AgedBrie)item).UpdateQuality();
                }
                else if (item.Name == "Backstage passes to a TAFKAL80ETC concert")
                {
                    ((BackstageConcertTicket)item).UpdateQuality();
                }
                else
                {
                    //if (item.Quality < 50)
                    //{
                    //    item.Quality += 1;

                    //    if (item.SellIn < 11)
                    //    {
                    //        if (item.Quality < 50)
                    //        {
                    //            item.Quality += 1;
                    //        }
                    //    }

                    //    if (item.SellIn < 6)
                    //    {
                    //        if (item.Quality < 50)
                    //        {
                    //            item.Quality += 1;
                    //        }
                    //    }
                    //}

                    //else
                    //{
                        if (item.Quality > 0)
                        {
                            if (item.Name != "Sulfuras, Hand of Ragnaros")
                            {
                                item.Quality -= 1;
                            }
                        }
                    //}

                    if (item.Name != "Sulfuras, Hand of Ragnaros")
                    {
                        item.SellIn -= 1;
                    }

                    HandleExpiredItems(item);
                }
            }
        }

        private void HandleExpiredItems(Item item)
        {
            if (item.SellIn < 0)
            {
                if (item.Name != "Aged Brie")
                {
                    if (item.Name != "Backstage passes to a TAFKAL80ETC concert")
                    {
                        if (item.Quality > 0)
                        {
                            if (item.Name != "Sulfuras, Hand of Ragnaros")
                            {
                                item.Quality -= 1;
                            }
                        }
                    }
                    else
                    {
                        item.Quality -= item.Quality;
                    }
                }
                else
                {
                    if (item.Quality < 50)
                    {
                        item.Quality += 1;
                    }
                }
            }
        }
    }
}
