using Microsoft.AspNetCore.Mvc;
using MagicCardsAPI.Data;
using Microsoft.EntityFrameworkCore;
using MagicDatabase.DTOs;
using AutoMapper;


namespace MagicDatabase.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CardsController : ControllerBase
    {
        private readonly CardService _cardService;
        private readonly IMapper _mapper;
        
        public CardsController(CardService cardService, IMapper mapper)
        {
            _cardService = cardService;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCardById(int id)
        {
            var card = await _cardService.GetCardByIdAsync(id);
            if (card == null)
            {
                return NotFound();
            }

            return Ok(card);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCard([FromBody] CardsDTO cardDto)
        {
            if (cardDto == null)
            {
                return BadRequest("The Card data cannot be null.");
            }

            // Usa AutoMapper per convertire il DTO in un'entità
            var newCard = _mapper.Map<Card>(cardDto);

            // Salva la nuova entità nel database
            await _cardService.AddCardAsync(newCard);

            // Restituisci un risultato con il nuovo oggetto creato
            return CreatedAtAction(nameof(GetCardById), new { id = newCard.CardId }, newCard);
        }

        //[HttpPut("{id}")]
        //public async Task<IActionResult> UpdateCard(int id, [FromBody] CardsDTO cardDto)
        //{
        //    if (id != cardDto.CardId)
        //    {
        //        return BadRequest("The Card ID in the URL does not match the ID in the request body.");
        //    }

        //    // Recupera la carta esistente dal database
        //    var existingCard = await _cardService.GetCardByIdAsync(id);
        //    if (existingCard == null)
        //    {
        //        return NotFound($"Card with ID {id} not found.");
        //    }

        //    // Mappa i dati del DTO sull'entità esistente
        //    _mapper.Map(cardDto, existingCard);

        //    // Aggiorna la carta usando il servizio
        //    await _cardService.UpdateCardAsync(existingCard);

        //    return NoContent();
        //}


        //[HttpPut("{id}")]
        //public async Task<IActionResult> UpdateCard(int id, [FromBody] CardsDTO card)
        //{
        //    if (id != card.CardId)
        //    {
        //        return BadRequest();
        //    }

        //    await _cardService.UpdateCardAsync(card);
        //    return NoContent();
        //}

        //    [HttpGet]
        //    public async Task<IActionResult> GetAllCards()
        //    {
        //        var cards = await _cardService.GetAllCardsAsync();
        //        return Ok(cards);
        //    }

        //    [HttpGet("{id}")]
        //    public async Task<IActionResult> GetCardById(int id)
        //    {
        //        var card = await _cardService.GetCardByIdAsync(id);
        //        if (card == null)
        //        {
        //            return NotFound();
        //        }
        //        return Ok(card);
        //    }

        //    [HttpPost]
        //    public async Task<IActionResult> AddCard([FromBody] Card card)
        //    {
        //        await _cardService.AddCardAsync(card);
        //        return CreatedAtAction(nameof(GetCardById), new { id = card.CardId }, card);
        //    }



        //    [HttpDelete("{id}")]
        //    public async Task<IActionResult> DeleteCard(int id)
        //    {
        //        await _cardService.DeleteCardAsync(id);
        //        return NoContent();
        //    }
        //}
        //MODIFICATO DA GIT HUB  
        //[ApiController]
        //[Route("api/[controller]")]
        //public class CardsController : ControllerBase
        //{
        //    private readonly MagicCardsContext _context;

        //    public CardsController(MagicCardsContext context)
        //    {
        //        _context = context;
        //    }

        //    [HttpGet]
        //    public async Task<ActionResult<IEnumerable<Card>>> GetCards()
        //    {
        //        return await _context.Cards.ToListAsync();
        //    }

        //    [HttpGet("{id}")]
        //    public async Task<ActionResult<Card>> GetCard(int id)
        //    {
        //        var card = await _context.Cards.FindAsync(id);

        //        if (card == null)
        //        {
        //            return NotFound();
        //        }

        //        return card;
        //    }

        //    [HttpPost]
        //    public async Task<ActionResult<Card>> PostCard(Card card)
        //    {
        //        _context.Cards.Add(card);
        //        await _context.SaveChangesAsync();

        //        return CreatedAtAction(nameof(GetCard), new { id = card.CardId }, card);
        //    }

        //    [HttpPut("{id}")]
        //    public async Task<IActionResult> PutCard(int id, Card card)
        //    {
        //        if (id != card.CardId)
        //        {
        //            return BadRequest();
        //        }

        //        _context.Entry(card).State = EntityState.Modified;

        //        try
        //        {
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!_context.Cards.Any(e => e.CardId == id))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }

        //        return NoContent();
        //    }

        //    [HttpDelete("{id}")]
        //    public async Task<IActionResult> DeleteCard(int id)
        //    {
        //        var card = await _context.Cards.FindAsync(id);
        //        if (card == null)
        //        {
        //            return NotFound();
        //        }

        //        _context.Cards.Remove(card);
        //        await _context.SaveChangesAsync();

        //        return NoContent();
        //    }
        //}

        //[ApiController]
        //[Route("api/[controller]")]
        //public class CardsController : ControllerBase
        //{
        //    private readonly MagicCardsContext _context;

        //    public CardsController(MagicCardsContext context) => _context = context;

        //    [HttpGet] // Ottieni tutte le carte
        //    public async Task<ActionResult<IEnumerable<Card>>> GetCards() => await _context.Cards.ToListAsync();

        //    [HttpGet("{id}")] // Ottieni una carta specifica
        //    public async Task<ActionResult<Card>> GetCard(int id)
        //    {
        //        var card = await _context.Cards.FindAsync(id);
        //        return card == null ? NotFound() : card;
        //    }

        //    [HttpPost] // Aggiungi una nuova carta
        //    public async Task<ActionResult<Card>> PostCard(Card card)
        //    {
        //        _context.Cards.Add(card);
        //        await _context.SaveChangesAsync();
        //        return CreatedAtAction(nameof(GetCard), new { id = card.CardId }, card);
        //    }

        //    [HttpDelete("{id}")] // Elimina una carta
        //    public async Task<IActionResult> DeleteCard(int id)
        //    {
        //        var card = await _context.Cards.FindAsync(id);
        //        if (card == null) return NotFound();
        //        _context.Cards.Remove(card);
        //        await _context.SaveChangesAsync();
        //        return NoContent();
        //    }
        //}
    }
}
