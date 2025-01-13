namespace MagicDatabase
{
    public class CardSubCategory
    {
        public int CardSubCategoryId { get; set; }
        public string CardSubCategoryName { get; set; }

        // Relazione con CardCategory
        public int CardCategoryID { get; set; }
        public string CardCategoryName { get; set; }
        public CardCategory CardCategory { get; set; }
    }
}
