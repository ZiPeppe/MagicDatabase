using MagicDatabase.DTOs;

namespace MagicDatabase.Services.Interfaces
{
    public interface ICardService
    {
        Task<CardDetailsDto> GetCardByIdAsync(int id);
        Task<IEnumerable<CardDetailsDto>> GetAllCardsAsync();
        Task<CardDetailsDto> AddCardAsync(CardDto cardDto);
        Task<bool> UpdateCardAsync(int id, CardUpdateDto cardUpdateDto);
        Task<bool> DeleteCardAsync(int id);
    }
}
