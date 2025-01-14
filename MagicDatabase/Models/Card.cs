using System.ComponentModel.DataAnnotations;

namespace MagicDatabase.Models
{
    public class Card
    {
        [Key]
        public int CardId { get; set; }
        public string CardName { get; set; }


        // Relazioni con altre tabelle
        public int CardRarityId { get; set; }
        public CardRarity CardRarity { get; set; }

        public int CardStatusId { get; set; }
        public CardStatus CardStatus { get; set; }

        public int CardSubCategoryId { get; set; }
        public CardSubCategory CardSubCategory { get; set; }

        public int CardLanguageId { get; set; }
        public CardLanguage CardLanguage { get; set; }

        public int CardArtTypeId { get; set; }
        public CardArtType CardArtType { get; set; }
    }
}
