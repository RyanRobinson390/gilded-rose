using Domain.Items;

namespace Domain
{
    public class QualityControl
    {
        readonly IList<SaleableItem> _items;

        public QualityControl(IList<SaleableItem> items)
        {
            _items = items;
        }

        public void Update()
        {
            foreach (var item in _items)
            {
                item.UpdateQuality();
            }
        }
    }
}
