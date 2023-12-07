namespace Domain.Items
{
    public class AgedBrie : SaleableItem
    {
        public override void UpdateQuality()
        {
            if (IsOutOfDate())
            {
                IncreaseQuality();
                IncreaseQuality();
            }
            else
            {
                IncreaseQuality();
            }
        }
    }
}
