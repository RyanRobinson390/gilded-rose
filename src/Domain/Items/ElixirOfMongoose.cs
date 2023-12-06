namespace Domain.Items
{
    public class ElixirOfMongoose : SaleableItem
    {
        public override void UpdateQuality()
        {
            if (Quality > 0)
            {
                Quality -= 1;
            }

            SellIn -= 1;

            if (SellIn < 0)
            {
                if (Quality > 0)
                {
                    Quality -= 1;
                }
            }
        }
    }
}
