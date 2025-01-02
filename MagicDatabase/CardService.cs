using MagicCardsAPI.Data;
using Microsoft.EntityFrameworkCore;

namespace MagicDatabase
{
    public class CardService
    {
        private readonly MagicCardsContext _context;

        public CardService(MagicCardsContext context)
        {
            _context = context;
        }

        public async Task<List<Card>> GetAllCardsAsync()
        {
            return await _context.Cards
                .Include(c => c.CardRarity)
                .Include(c => c.CardCategory)
                .ToListAsync();
        }

        public async Task<Card?> GetCardByIdAsync(int id)
        {
            return await _context.Cards
                .Include(c => c.CardRarity)
                .Include(c => c.CardCategory)
                .FirstOrDefaultAsync(c => c.CardId == id);
        }

        public async Task AddCardAsync(Card card)
        {
            _context.Cards.Add(card);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateCardAsync(Card card)
        {
            _context.Cards.Update(card);
            await _context.SaveChangesAsync();
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
