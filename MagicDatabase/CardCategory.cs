using System.ComponentModel.DataAnnotations.Schema;

namespace MagicDatabase
{
    [Table("CardCategory")]
    public class CardCategory
    {
        public int CardCategoryId { get; set; }
        public string CardCategoryName { get; set; }

        public ICollection<Card> Cards { get; set; } // Relazione 1 a molti prova per capire se funziona con MARKO
    }
}
