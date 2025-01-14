using MagicDatabase.Models;

namespace MagicDatabase.Seeds
{
    public static class CardStatusSeed
    {
        public static List<CardStatus> GetData()
        {
            return new List<CardStatus>
            {
                new CardStatus { CardStatusId = 1, CardStatusName = "Trashed" },
                new CardStatus { CardStatusId = 2, CardStatusName = "Damaged" },
                new CardStatus { CardStatusId = 3, CardStatusName = "Poor" },
                new CardStatus { CardStatusId = 4, CardStatusName = "Heavily Played" },
                new CardStatus { CardStatusId = 5, CardStatusName = "Lightly Played" },
                new CardStatus { CardStatusId = 6, CardStatusName = "Good" },
                new CardStatus { CardStatusId = 7, CardStatusName = "Excellent" },
                new CardStatus { CardStatusId = 8, CardStatusName = "Near Mint" },
                new CardStatus { CardStatusId = 9, CardStatusName = "Mint" },
                new CardStatus { CardStatusId = 10, CardStatusName = "Sealed" },
            };
        }
    }
}
