using System.ComponentModel.DataAnnotations.Schema;

namespace MagicDatabase.Models
{
    [Table("CardArtType")]
    public class CardArtType
    {
        public int CardArtTypeId { get; set; }
        public string CardArtTypeName { get; set; }
    }
}
