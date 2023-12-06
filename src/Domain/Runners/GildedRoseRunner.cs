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
            _writer.WriteLine("OMGHAI!");

            var items = _itemRepository.GetAllItems();

            for (var day = 0; day < 31; day++)
            {
                _writer.WriteNewDayHeader(day);

                foreach (var item in items)
                {
                    _writer.WriteLine($"{item}");
                }

                if (day < 30)
                {
                    _writer.WriteLine("");
                }

                foreach (var item in items)
                {
                    item.UpdateQuality();
                }
            }
        }
    }
}
