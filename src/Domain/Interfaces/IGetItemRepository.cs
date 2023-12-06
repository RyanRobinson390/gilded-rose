namespace Domain.Interfaces
{
    public interface IGetItemRepository
    {
        IList<Item> GetAllItems();
    }
}
