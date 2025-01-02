namespace MagicDatabase
{
    public class CardCategory
    {
        public int CardCategoryId { get; set; }
        public string CardCategoryName { get; set; }

        public ICollection<Card> Cards { get; set; }
    }
}
