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
    public class Board_MembersController : ControllerBase
    {
        private readonly KanbanContext _context;

        public Board_MembersController(KanbanContext context)
        {
            _context = context;
        }

        // GET: api/Board_Members
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Board_Members>>> GetBoard_Members()
        {
            return await _context.Board_Members.ToListAsync();
        }

        // GET: api/Board_Members/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Board_Members>> GetBoard_Members(int id)
        {
            var board_Members = await _context.Board_Members.FindAsync(id);

            if (board_Members == null)
            {
                return NotFound();
            }

            return board_Members;
        }

        // PUT: api/Board_Members/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBoard_Members(int id, Board_Members board_Members)
        {
            if (id != board_Members.Board_MembersId)
            {
                return BadRequest();
            }

            _context.Entry(board_Members).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Board_MembersExists(id))
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

        // POST: api/Board_Members
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Board_Members>> PostBoard_Members(Board_Members board_Members)
        {
            _context.Board_Members.Add(board_Members);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBoard_Members", new { id = board_Members.Board_MembersId }, board_Members);
        }

        // DELETE: api/Board_Members/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBoard_Members(int id)
        {
            var board_Members = await _context.Board_Members.FindAsync(id);
            if (board_Members == null)
            {
                return NotFound();
            }

            _context.Board_Members.Remove(board_Members);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Board_MembersExists(int id)
        {
            return _context.Board_Members.Any(e => e.Board_MembersId == id);
        }
    }
}
