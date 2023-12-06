using Domain.Interfaces;

namespace Domain.Runners
{
    public class GildedRoseRunner
    {
        private readonly IGetItemRepository _itemRepository;

        public GildedRoseRunner(IGetItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }

        public void Run()
        {
            Console.WriteLine("OMGHAI!");

            var Items = _itemRepository.GetAllItems();

            var app = new GildedRose(Items);

            for (var i = 0; i < 31; i++)
            {
                Console.WriteLine("-------- day " + i + " --------");
                Console.WriteLine("name, sellIn, quality");
                for (var j = 0; j < Items.Count; j++)
                {
                    Console.WriteLine(Items[j]);
                }

                if (i < 30)
                {
                    Console.WriteLine("");
                }

                app.UpdateQuality();
            }
        }
    }
}
