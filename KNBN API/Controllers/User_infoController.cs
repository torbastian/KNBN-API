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
    public class User_infoController : ControllerBase
    {
        private readonly KanbanContext _context;

        public User_infoController(KanbanContext context)
        {
            _context = context;
        }

        // GET: api/User_info
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User_info>>> GetUser_info()
        {
            return await _context.User_info.ToListAsync();
        }

        // GET: api/User_info/5
        [HttpGet("{id}")]
        public async Task<ActionResult<User_info>> GetUser_info(string id)
        {
            var user_info = await _context.User_info.FindAsync(id);

            if (user_info == null)
            {
                return NotFound();
            }

            return user_info;
        }

        // PUT: api/User_info/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUser_info(string id, User_info user_info)
        {
            if (id != user_info.Email)
            {
                return BadRequest();
            }

            _context.Entry(user_info).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!User_infoExists(id))
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

        // POST: api/User_info
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<User_info>> PostUser_info(User_info user_info)
        {
            _context.User_info.Add(user_info);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (User_infoExists(user_info.Email))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetUser_info", new { id = user_info.Email }, user_info);
        }

        // DELETE: api/User_info/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser_info(string id)
        {
            var user_info = await _context.User_info.FindAsync(id);
            if (user_info == null)
            {
                return NotFound();
            }

            _context.User_info.Remove(user_info);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool User_infoExists(string id)
        {
            return _context.User_info.Any(e => e.Email == id);
        }
    }
}
