using Domain.Interfaces;
using Domain.Items;

namespace Domain.Runners
{
    public class GildedRoseProcessor
    {
        private readonly IGetItemRepository _itemRepository;
        private readonly IWriteOutput _writer;

        public GildedRoseProcessor(IGetItemRepository itemRepository, IWriteOutput writer)
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

                _writer.WriteLine("");

                var saleableItems = items.OfType<SaleableItem>();

                foreach (var saleableItem in saleableItems)
                {
                    saleableItem.DecreaseSellInDateByOneDay();
                    saleableItem.UpdateQuality();
                }
            }
        }
    }
}