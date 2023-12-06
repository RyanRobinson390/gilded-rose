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
            var quality = new QualityControl(items);

            for (var day = 0; day < 31; day++)
            {
                _writer.WriteOutput($"-------- day {day} --------");
                _writer.WriteOutput("name, sellIn, quality");

                foreach (var item in items)
                {
                    _writer.WriteOutput($"{item}");
                }

                if (day < 30)
                {
                    _writer.WriteOutput("");
                }

                quality.UpdateQuality();
            }
        }
    }
}
