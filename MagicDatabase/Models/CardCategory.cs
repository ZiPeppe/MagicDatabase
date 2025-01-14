using System.ComponentModel.DataAnnotations.Schema;

namespace MagicDatabase.Models
{
    [Table("CardCategory")]
    public class CardCategory
    {
        public int CardCategoryId { get; set; }
        public string CardCategoryName { get; set; }

        // Relazione con CardSubCategory
        public ICollection<CardSubCategory> CardSubCategories { get; set; }
    }
}
