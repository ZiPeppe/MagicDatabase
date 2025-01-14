using MagicDatabase.Models;

namespace MagicDatabase.Seeds
{
    public static class CardArtTypeSeed
    {
        public static List<CardArtType> GetData()
        {
            return new List<CardArtType>
            {
                new CardArtType { CardArtTypeId = 1, CardArtTypeName = "Foil" },
                new CardArtType { CardArtTypeId = 2, CardArtTypeName = "Foil Etched" },
                new CardArtType { CardArtTypeId = 3, CardArtTypeName = "Reverse Foil" },
                new CardArtType { CardArtTypeId = 4, CardArtTypeName = "Full Art" },
                new CardArtType { CardArtTypeId = 5, CardArtTypeName = "Full Art Foil" },
                new CardArtType { CardArtTypeId = 6, CardArtTypeName = "Full Art Other Foilage" },
                new CardArtType { CardArtTypeId = 7, CardArtTypeName = "Double Art" },
                new CardArtType { CardArtTypeId = 8, CardArtTypeName = "Double Art Foil" },
                new CardArtType { CardArtTypeId = 9, CardArtTypeName = "Borderless" },
                new CardArtType { CardArtTypeId = 10, CardArtTypeName = "Borderless Foil" },
                new CardArtType { CardArtTypeId = 11, CardArtTypeName = "Alternative Art" },
                new CardArtType { CardArtTypeId = 12, CardArtTypeName = "Alternative Art Foil" },
                new CardArtType { CardArtTypeId = 13, CardArtTypeName = "Promo" },
                new CardArtType { CardArtTypeId = 14, CardArtTypeName = "Promo Foil" },
                new CardArtType { CardArtTypeId = 15, CardArtTypeName = "Missprint" },
                new CardArtType { CardArtTypeId = 16, CardArtTypeName = "None" }
            };
        }
    }
}
