using MagicDatabase.Models;

namespace MagicDatabase.Repositories.Interfaces
{
    public interface ICardRepository
    {
        // Recupera una carta per ID
        Task<Card> GetCardByIdAsync(int id);

        // Recupera tutte le carte
        Task<IEnumerable<Card>> GetAllCardsAsync();

        // Aggiunge una nuova carta
        Task<Card> AddCardAsync(Card card);

        // Aggiorna una carta esistente
        Task<bool> UpdateCardAsync(Card card);

        // Elimina una carta per ID
        Task<bool> DeleteCardAsync(int id);
    }
}
