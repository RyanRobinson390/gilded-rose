namespace Domain.Items
{
    public class AgedBrie : Item
    {
        public void UpdateQuality()
        {
            if (Quality < 50)
            {
                Quality += 1;
            }

            SellIn -= 1;

            if (SellIn < 0)
            {
                if (Quality < 50)
                {
                    Quality += 1;
                }
            }
        }
    }
}
