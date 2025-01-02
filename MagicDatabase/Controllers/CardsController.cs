using Microsoft.AspNetCore.Mvc;
using MagicCardsAPI.Data;
using Microsoft.EntityFrameworkCore;

namespace MagicDatabase.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CardsController : ControllerBase
    {
        private readonly CardService _cardService;

        public CardsController(CardService cardService)
        {
            _cardService = cardService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCards()
        {
            var cards = await _cardService.GetAllCardsAsync();
            return Ok(cards);
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
        public async Task<IActionResult> AddCard([FromBody] Card card)
        {
            await _cardService.AddCardAsync(card);
            return CreatedAtAction(nameof(GetCardById), new { id = card.CardId }, card);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCard(int id, [FromBody] Card card)
        {
            if (id != card.CardId)
            {
                return BadRequest();
            }

            await _cardService.UpdateCardAsync(card);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCard(int id)
        {
            await _cardService.DeleteCardAsync(id);
            return NoContent();
        }
    }
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
