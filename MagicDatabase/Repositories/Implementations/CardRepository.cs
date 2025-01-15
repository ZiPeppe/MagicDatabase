using MagicCardsAPI.Data;
using MagicDatabase.Models;
using MagicDatabase.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MagicDatabase.Repositories.Implementations
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
        public async Task<Card> AddCardAsync(Card card)
        {
            // Aggiungi la nuova carta al contesto
            await _context.Cards.AddAsync(card);

            // Salva i cambiamenti
            int result = await _context.SaveChangesAsync();

            // Controlla se l'operazione ha avuto successo
            if (result > 0)
            {
                // Carica le relazioni della carta appena salvata
                return await _context.Cards
                    .Include(c => c.CardRarity)
                    .Include(c => c.CardStatus)
                    .Include(c => c.CardSubCategory)
                        .ThenInclude(sub => sub.CardCategory)
                    .Include(c => c.CardLanguage)
                    .Include(c => c.CardArtType)
                    .FirstOrDefaultAsync(c => c.CardId == card.CardId);
            }

            // In caso di fallimento, lancia un'eccezione o restituisci null
            throw new Exception("Non sono riuscito ad aggiungere la carta al database :( ");
        }

        // Aggiorna una carta esistente
        public async Task<bool> UpdateCardAsync(Card card)
        {
            var existingCard = await _context.Cards.FindAsync(card.CardId);

            if (existingCard == null)
            {
                return false; // La carta non esiste
            }

            // Segna l'entità come modificata
            _context.Entry(existingCard).CurrentValues.SetValues(card);

            // Salva i cambiamenti
            int result = await _context.SaveChangesAsync();

            // Restituisci true se l'operazione ha aggiornato almeno una riga
            return result > 0;
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
            int result = await _context.SaveChangesAsync();

            // Restituisci true se è stato eliminato almeno un record
            return result > 0;
        }
    }
}
