namespace Domain.Items
{
    public class BackstageConcertTicket : SaleableItem
    {
        public override void UpdateQuality()
        {
            if (IsOutOfDate())
            {
                Quality = 0;
                return;
            }

            switch (SellIn)
            {
                case < 10 and >= 5:
                    IncreaseQuality();
                    IncreaseQuality();
                    break;

                case < 5:
                    IncreaseQuality();
                    IncreaseQuality();
                    IncreaseQuality();
                    break;

                default:
                    IncreaseQuality();
                    break;
            }
        }
    }
}