using Microsoft.AspNetCore.Mvc;
using MagicCardsAPI.Data;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using MagicDatabase.Repositories;
using MagicDatabase.Models;
using MagicDatabase.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using MagicDatabase.DTOs;


namespace MagicDatabase.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class CardsController : ControllerBase
    {
        private readonly ICardService _cardService;
        private readonly IMapper _mapper;

        public CardsController(ICardService cardService, IMapper mapper)
        {
            _cardService = cardService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CardDetailsDto>>> GetAllCards()
        {
            try
            {
                // Recupera le carte tramite il servizio
                var cards = await _cardService.GetAllCardsAsync();

                if (cards == null || !cards.Any())
                {
                    return NotFound("No cards found.");
                }

                return Ok(cards); // Restituisce le carte trovate
            }
            catch (Exception ex)
            {
                // Log dell'errore
                Console.WriteLine($"Errore nel cercare le carte: {ex.Message}");
                return StatusCode(500, "Errore nel ritornare le carte.");
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CardDetailsDto>> GetCard(int id)
        {
            try
            {
                // Usa il servizio per recuperare il DTO
                var cardDetailsDto = await _cardService.GetCardByIdAsync(id);

                if (cardDetailsDto == null)
                {
                    return NotFound(new { message = $"Card with ID {id} not found." });
                }

                return Ok(cardDetailsDto); // Restituisci direttamente il DTO
            }
            catch (Exception ex)
            {
                // Log dell'errore
                Console.WriteLine($"Errore nel cercare la carta: {ex.Message}");
                return StatusCode(500, "Errore nel ritornare la carta.");
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateCard([FromBody] CardDto cardDto)
        {
            try
            {
                if (cardDto == null)
                {
                    return BadRequest("The Card data cannot be null.");
                }

                var createdCard = await _cardService.AddCardAsync(cardDto);

                if (createdCard == null)
                {
                    return StatusCode(500, "Errore nel creare la carta.");
                }

                return CreatedAtAction(nameof(GetCard), new { id = createdCard.CardId }, createdCard);
            }
            catch (Exception ex)
            {
                // Log dell'errore (opzionale)
                Console.WriteLine($"Errore nel creare le carte: {ex.Message}");
                return StatusCode(500, "Errore nel creare le carte.");
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCard(int id, [FromBody] CardUpdateDto cardUpdateDto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var success = await _cardService.UpdateCardAsync(id, cardUpdateDto);

                if (!success)
                {
                    return NotFound(new { message = $"Card with ID {id} not found." });
                }

                return NoContent();
            }
            catch (Exception ex)
            {
                // Log dell'errore (opzionale)
                Console.WriteLine($"Errore nel modificare le carte: {ex.Message}");
                return StatusCode(500, "Errore nel modificare le carte.");
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCard(int id)
        {
            try
            {
                var success = await _cardService.DeleteCardAsync(id);

                if (!success)
                {
                    return NotFound(new { message = $"Card with ID {id} not found." });
                }

                return NoContent();
            }
            catch (Exception ex)
            {
                // Log dell'errore (opzionale)
                Console.WriteLine($"Errore nel eliminare la carta: {ex.Message}");

                return StatusCode(500, new { message = "Errore nel eliminare la carta." });
            }
        }
    }
}
