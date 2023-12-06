using Domain.Interfaces;

namespace Domain.Runners
{
    public class GildedRoseRunner
    {
        private readonly IGetItemRepository _itemRepository;
        private readonly IWriteOutput _writer;

        public GildedRoseRunner(IGetItemRepository itemRepository, IWriteOutput writer)
        {
            _itemRepository = itemRepository;
            _writer = writer;
        }

        public void Run()
        {
            _writer.WriteOutput("OMGHAI!");

            var items = _itemRepository.GetAllItems();
            var app = new GildedRose(items);

            for (var i = 0; i < 31; i++)
            {
                _writer.WriteOutput($"-------- day {i} --------");
                _writer.WriteOutput("name, sellIn, quality");

                for (var j = 0; j < items.Count; j++)
                {
                    Console.WriteLine(items[j]);
                }

                if (i < 30)
                {
                    _writer.WriteOutput("");
                }

                app.UpdateQuality();
            }
        }
    }
}
