namespace Domain.Items
{
    public class SaleableItem : Item
    {
        private const int MaxQuality = 50;
        private const int MinQuality = 0;

        public virtual void DecreaseSellInDateByOneDay()
        {
            SellIn -= 1;
        }

        public virtual void UpdateQuality()
        {
            if (IsOutOfDate())
            {
                DecreaseQuality();
                DecreaseQuality();
            }
            else
            {
                DecreaseQuality();
            }
        }

        protected bool IsOutOfDate()
        {
            return SellIn < 0;
        }

        protected void DecreaseQuality()
        {
            if (Quality <= MinQuality)
            {
                return;
            }

            Quality -= 1;
        }

        protected void IncreaseQuality()
        {
            if (Quality >= MaxQuality)
            {
                return;
            }

            Quality += 1;
        }
    }
}