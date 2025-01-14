using MagicCardsAPI.Data;
using MagicDatabase.Models;
using MagicDatabase.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MagicDatabase.Repositories
{
    public class CardRepository : ICardRepository
    {
        private readonly MagicCardsContext _context;

        public CardRepository(MagicCardsContext context)
        {
            _context = context;
        }

        // Recupera una carta per ID
        public async Task<Card> GetCardByIdAsync(int id)
        {
            return await _context.Cards
                .Include(c => c.CardRarity)
                .Include(c => c.CardStatus)
                .Include(c => c.CardSubCategory)
                    .ThenInclude(sub => sub.CardCategory)
                .Include(c => c.CardLanguage)
                .Include(c => c.CardArtType)
                .FirstOrDefaultAsync(c => c.CardId == id);
        }

        // Recupera tutte le carte
        public async Task<IEnumerable<Card>> GetAllCardsAsync()
        {
            return await _context.Cards
                .Include(c => c.CardRarity)
                .Include(c => c.CardStatus)
                .Include(c => c.CardSubCategory)
                    .ThenInclude(sub => sub.CardCategory)
                .Include(c => c.CardLanguage)
                .Include(c => c.CardArtType)
                .ToListAsync();
        }

        // Aggiunge una nuova carta
        public async Task AddCardAsync(Card card)
        {
            await _context.Cards.AddAsync(card);
            await _context.SaveChangesAsync();
        }

        // Aggiorna una carta esistente
        public async Task<bool> UpdateCardAsync(Card card)
        {
            var existingCard = await _context.Cards.FindAsync(card.CardId);
            if (existingCard == null)
            {
                return false;
            }

            // Aggiorna i campi esistenti con i nuovi valori
            existingCard.CardName = card.CardName;
            existingCard.CardRarityId = card.CardRarityId;
            existingCard.CardStatusId = card.CardStatusId;
            existingCard.CardSubCategoryId = card.CardSubCategoryId;
            existingCard.CardLanguageId = card.CardLanguageId;
            existingCard.CardArtTypeId = card.CardArtTypeId;

            _context.Cards.Update(existingCard);
            await _context.SaveChangesAsync();

            return true;
        }

        // Elimina una carta per ID
        public async Task<bool> DeleteCardAsync(int id)
        {
            var card = await _context.Cards.FindAsync(id);
            if (card == null)
            {
                return false;
            }

            _context.Cards.Remove(card);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
