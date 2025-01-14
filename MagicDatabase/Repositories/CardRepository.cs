using MagicCardsAPI.Data;
using Microsoft.EntityFrameworkCore;

namespace MagicDatabase.Repositories
{
    public class CardRepository
    {
        private readonly MagicCardsContext _context;

        public CardRepository(MagicCardsContext context)
        {
            _context = context;
        }

        public async Task<List<Card>> GetAllCardsAsync()
        {
            return await _context.Cards
                .Include(c => c.CardRarity)
                .Include(c => c.CardSubCategory)
                .Include(c => c.CardLanguage)
                .Include(c => c.CardArtType)
                .Include(c => c.CardStatus)
                .ToListAsync();
        }

        public async Task<Card?> GetCardByIdAsync(int id)
        {
            return await _context.Cards
                .Include(c => c.CardRarity)
                .Include(c => c.CardSubCategory)
                .Include(c => c.CardLanguage)
                .Include(c => c.CardArtType)
                .Include(c => c.CardStatus)
                .FirstOrDefaultAsync(c => c.CardId == id);
        }

        public async Task AddCardAsync(Card card)
        {
            _context.Cards.Add(card);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> UpdateCardAsync(Card card)
        {
            var existingCard = await _context.Cards.FindAsync(card.CardId);
            if (existingCard == null)
            {
                return false; // La carta non esiste
            }

            // Aggiorna le proprietà
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

        public async Task DeleteCardAsync(int id)
        {
            var card = await _context.Cards.FindAsync(id);
            if (card != null)
            {
                _context.Cards.Remove(card);
                await _context.SaveChangesAsync();
            }
        }
    }

}
