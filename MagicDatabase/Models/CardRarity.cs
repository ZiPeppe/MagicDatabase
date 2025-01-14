using System.ComponentModel.DataAnnotations.Schema;

namespace MagicDatabase.Models
{
    [Table("CardRarity")]
    public class CardRarity
    {
        public int CardRarityId { get; set; }
        public string CardRarityName { get; set; }
    }
}
