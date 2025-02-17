﻿using MagicDatabase.Models;

namespace MagicDatabase.Seeds
{
    public static class CardCategorySeed
    {
        public static List<CardCategory> GetData()
        {
            return new List<CardCategory>
            {
                new CardCategory { CardCategoryId = 1, CardCategoryName = "Creatura" },
                new CardCategory { CardCategoryId = 2, CardCategoryName = "Incantesimo" },
                new CardCategory { CardCategoryId = 3, CardCategoryName = "Artefatto" },
                new CardCategory { CardCategoryId = 4, CardCategoryName = "Terra" },
                new CardCategory { CardCategoryId = 5, CardCategoryName = "Planeswalker" },
                new CardCategory { CardCategoryId = 6, CardCategoryName = "Istantaneo" },
                new CardCategory { CardCategoryId = 7, CardCategoryName = "Stregoneria" }
            };
        }
    }
}
