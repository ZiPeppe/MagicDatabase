namespace MagicDatabase.API.DTOs
{
    public class CardUpdateDto
    {
        public string CardName { get; set; }
        public int CardRarityId { get; set; }
        public int CardStatusId { get; set; }
        public int CardSubCategoryId { get; set; }
        public int CardLanguageId { get; set; }
        public int CardArtTypeId { get; set; }
    }
}
