using Domain.Items;

namespace Domain.Interfaces
{
    public interface IGetItemRepository
    {
        IList<SaleableItem> GetAllItems();
    }
}
