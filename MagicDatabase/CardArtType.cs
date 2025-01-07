using System.ComponentModel.DataAnnotations.Schema;

namespace MagicDatabase
{
    [Table("CardArtType")]
    public class CardArtType
    {
        public int CardArtTypeId { get; set; }
        public string CardArtTypeName { get; set; }
    }
}
