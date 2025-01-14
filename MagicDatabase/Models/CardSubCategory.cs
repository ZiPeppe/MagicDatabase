namespace MagicDatabase.Models
{
    public class CardSubCategory
    {
        public int CardSubCategoryId { get; set; }
        public string CardSubCategoryName { get; set; }

        // Foreign Key
        public int CardCategoryID { get; set; }

        // Relazione con CardCategory
        public CardCategory CardCategory { get; set; }
    }
}
