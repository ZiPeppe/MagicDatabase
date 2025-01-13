namespace MagicDatabase.Seeds
{
    public class CardSubCategorySeed
    {
        public static List<CardSubCategory> GetData()
        {
            return new List<CardSubCategory>
            {
                new CardSubCategory { CardSubCategoryId = 1, CardSubCategoryName = "Elfo", CardCategoryID = 1 },
                new CardSubCategory { CardSubCategoryId = 2, CardSubCategoryName = "Zombie", CardCategoryID = 1 },
                new CardSubCategory { CardSubCategoryId = 3, CardSubCategoryName = "Aura", CardCategoryID = 2 },
                new CardSubCategory { CardSubCategoryId = 4, CardSubCategoryName = "Equipaggiamento", CardCategoryID = 3 }
            };
        }
    }
};
