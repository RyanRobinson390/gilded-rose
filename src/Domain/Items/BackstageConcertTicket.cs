namespace Domain.Items
{
    public class BackstageConcertTicket : Item
    {
        public void UpdateQuality()
        {
            if (Quality < 50)
            {
                Quality += 1;

                if (SellIn < 11)
                {
                    if (Quality < 50)
                    {
                        Quality += 1;
                    }
                }

                if (SellIn < 6)
                {
                    if (Quality < 50)
                    {
                        Quality += 1;
                    }
                }
            }

            SellIn -= 1;

            if (SellIn < 0)
            {
                Quality -= Quality;
            }
        }
    }
}
