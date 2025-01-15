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
            return card == null ? null : _mapper.Map<CardDetailsDto>(card);
        }

        public async Task<IEnumerable<CardDetailsDto>> GetAllCardsAsync()
        {
            var cards = await _cardRepository.GetAllCardsAsync();
            return _mapper.Map<IEnumerable<CardDetailsDto>>(cards);
        }

        public async Task<CardDetailsDto> AddCardAsync(CardDto cardDto)
        {
            var card = _mapper.Map<Card>(cardDto);

            // Salva la carta e ottieni l'entità con l'ID aggiornato
            var savedCard = await _cardRepository.AddCardAsync(card);

            // Restituisci un DTO con i dettagli della carta salvata
            return _mapper.Map<CardDetailsDto>(savedCard);
        }

        public async Task<bool> UpdateCardAsync(int id, CardUpdateDto cardUpdateDto)
        {
            var existingCard = await _cardRepository.GetCardByIdAsync(id);
            if (existingCard == null)
            {
                return false;
            }

            _mapper.Map(cardUpdateDto, existingCard);
            return await _cardRepository.UpdateCardAsync(existingCard);
        }

        public async Task<bool> DeleteCardAsync(int id)
        {
            return await _cardRepository.DeleteCardAsync(id);
        }
    }
}
