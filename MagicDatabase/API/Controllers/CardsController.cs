using Microsoft.AspNetCore.Mvc;
using MagicCardsAPI.Data;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using MagicDatabase.Repositories;
using MagicDatabase.API.DTOs;
using MagicDatabase.Models;
using MagicDatabase.Services.Interfaces;


namespace MagicDatabase.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CardsController : ControllerBase
    {
        private readonly ICardService _cardService;
        private readonly IMapper _mapper;

        public CardsController(ICardService cardService, IMapper mapper)
        {
            _cardService = cardService;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CardDetailsDto>> GetCard(int id)
        {
            // Usa il repository per recuperare la carta
            var card = await _cardService.GetCardByIdAsync(id);

            if (card == null)
            {
                return NotFound();
            }

            // Mappa l'entità al DTO
            var cardDetailsDto = _mapper.Map<CardDetailsDto>(card);

            return Ok(cardDetailsDto);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCard([FromBody] CardDto cardDto)
        {
            if (cardDto == null)
            {
                return BadRequest("The Card data cannot be null.");
            }

            // Usa il servizio per aggiungere la carta
            await _cardService.AddCardAsync(cardDto);

            // Restituisci Created con il risultato
            return CreatedAtAction(nameof(GetCard), new { id = cardDto.CardId }, cardDto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCard(int id, [FromBody] CardUpdateDto cardUpdateDto)
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
                Console.WriteLine($"Error while deleting card: {ex.Message}");

                return StatusCode(500, new { message = "An error occurred while deleting the card." });
            }
        }
    }
}
