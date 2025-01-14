using MagicDatabase.Models;

namespace MagicDatabase.Seeds
{
    public static class CardRaritySeed
    {
        public static List<CardRarity> GetData()
        {
            return new List<CardRarity>
            {
                new CardRarity { CardRarityId = 1, CardRarityName = "Common" },
                new CardRarity { CardRarityId = 2, CardRarityName = "Uncommon" },
                new CardRarity { CardRarityId = 3, CardRarityName = "Rare" },
                new CardRarity { CardRarityId = 4, CardRarityName = "Mythic Rare" }
            };
        }
    }

}
