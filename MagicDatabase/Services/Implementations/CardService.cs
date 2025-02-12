using AutoMapper;
using MagicDatabase.DTOs;
using MagicDatabase.Models;
using MagicDatabase.Repositories.Interfaces;
using MagicDatabase.Services.Interfaces;

namespace MagicDatabase.Services.Implementations
{
    public class CardService : ICardService
    {
        private readonly ICardRepository _cardRepository;
        private readonly IMapper _mapper;

        public CardService(ICardRepository cardRepository, IMapper mapper)
        {
            _cardRepository = cardRepository;
            _mapper = mapper;
        }

        public async Task<CardDetailsDto> GetCardByIdAsync(int id)
        {
            var card = await _cardRepository.GetCardByIdAsync(id);
            // Se non troviamo la carta, restituiamo null
            if (card == null)
            {
                return null;
            }

            return _mapper.Map<CardDetailsDto>(card);
        }

        public async Task<IEnumerable<CardDetailsDto>> GetAllCardsAsync()
        {
            var cards = await _cardRepository.GetAllCardsAsync();
            return _mapper.Map<IEnumerable<CardDetailsDto>>(cards);
        }

        public async Task<CardDetailsDto> AddCardAsync(CardDto cardDto)
        {
            // Mappa il DTO all'entità Card
            var card = _mapper.Map<Card>(cardDto);

            // Salva la carta tramite il repository
            var savedCard = await _cardRepository.AddCardAsync(card);

            if (savedCard == null)
            {
                // Se qualcosa va storto nel salvataggio, restituiamo null
                return null;
            }

            // Carica le relazioni usando un metodo esistente o dedicato
            var cardWithRelations = await _cardRepository.GetCardByIdAsync(savedCard.CardId);

            if (cardWithRelations == null)
            {
                // Se non troviamo la carta con le relazioni, restituiamo null
                return null;
            }

            // Restituisci un DTO completo della carta salvata
            return _mapper.Map<CardDetailsDto>(cardWithRelations);
        }

        public async Task<bool> UpdateCardAsync(int id, CardUpdateDto cardUpdateDto)
        {
            // Controlla se la carta esiste
            var existingCard = await _cardRepository.GetCardByIdAsync(id);
            if (existingCard == null)
            {
                // Se non esiste, restituiamo false
                return false;
            }

            // Applica gli aggiornamenti
            _mapper.Map(cardUpdateDto, existingCard);
            // Restituisci true o false a seconda del risultato
            return await _cardRepository.UpdateCardAsync(existingCard);
        }

        public async Task<bool> DeleteCardAsync(int id)
        {
            // Restituisce true o false a seconda del successo
            return await _cardRepository.DeleteCardAsync(id);
        }
    }
}
