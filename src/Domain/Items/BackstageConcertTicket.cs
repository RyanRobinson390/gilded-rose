namespace Domain.Items
{
    public class BackstageConcertTicket : SaleableItem
    {
        private const int TenDaysThreshold = 10;
        private const int FiveDaysThreshold = 5;

        public override void UpdateQuality()
        {
            if (IsOutOfDate())
            {
                Quality = 0;
                return;
            }

            if (IsTenDaysToConcert())
            {
                IncreaseQuality();
                IncreaseQuality();
                return;
            }

            if (IsFiveDaysToConcert())
            {
                IncreaseQuality();
                IncreaseQuality();
                IncreaseQuality();
                return;
            }

            IncreaseQuality();
        }

        private bool IsTenDaysToConcert()
        {
            return SellIn is < TenDaysThreshold and >= FiveDaysThreshold;
        }

        private bool IsFiveDaysToConcert()
        {
            return SellIn < FiveDaysThreshold;
        }
    }
}