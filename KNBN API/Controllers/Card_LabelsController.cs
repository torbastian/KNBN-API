using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using KNBN_API.Models;

namespace KNBN_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Card_LabelsController : ControllerBase
    {
        private readonly KanbanContext _context;

        public Card_LabelsController(KanbanContext context)
        {
            _context = context;
        }

        // GET: api/Card_Labels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Card_Labels>>> GetCard_Labels()
        {
            return await _context.Card_Labels.ToListAsync();
        }

        // GET: api/Card_Labels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Card_Labels>> GetCard_Labels(int id)
        {
            var card_Labels = await _context.Card_Labels.FindAsync(id);

            if (card_Labels == null)
            {
                return NotFound();
            }

            return card_Labels;
        }

        // PUT: api/Card_Labels/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCard_Labels(int id, Card_Labels card_Labels)
        {
            if (id != card_Labels.Card_LabelsId)
            {
                return BadRequest();
            }

            _context.Entry(card_Labels).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Card_LabelsExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Card_Labels
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Card_Labels>> PostCard_Labels(Card_Labels card_Labels)
        {
            _context.Card_Labels.Add(card_Labels);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCard_Labels", new { id = card_Labels.Card_LabelsId }, card_Labels);
        }

        // DELETE: api/Card_Labels/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCard_Labels(int id)
        {
            var card_Labels = await _context.Card_Labels.FindAsync(id);
            if (card_Labels == null)
            {
                return NotFound();
            }

            _context.Card_Labels.Remove(card_Labels);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Card_LabelsExists(int id)
        {
            return _context.Card_Labels.Any(e => e.Card_LabelsId == id);
        }
    }
}
