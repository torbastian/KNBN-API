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
    public class Permission_MembersController : ControllerBase
    {
        private readonly KanbanContext _context;

        public Permission_MembersController(KanbanContext context)
        {
            _context = context;
        }

        // GET: api/Permission_Members
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Permission_Members>>> GetPermission_Members()
        {
            return await _context.Permission_Members.ToListAsync();
        }

        // GET: api/Permission_Members/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Permission_Members>> GetPermission_Members(int id)
        {
            var permission_Members = await _context.Permission_Members.FindAsync(id);

            if (permission_Members == null)
            {
                return NotFound();
            }

            return permission_Members;
        }

        // PUT: api/Permission_Members/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPermission_Members(int id, Permission_Members permission_Members)
        {
            if (id != permission_Members.Permission_MembersId)
            {
                return BadRequest();
            }

            _context.Entry(permission_Members).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Permission_MembersExists(id))
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

        // POST: api/Permission_Members
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Permission_Members>> PostPermission_Members(Permission_Members permission_Members)
        {
            _context.Permission_Members.Add(permission_Members);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPermission_Members", new { id = permission_Members.Permission_MembersId }, permission_Members);
        }

        // DELETE: api/Permission_Members/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePermission_Members(int id)
        {
            var permission_Members = await _context.Permission_Members.FindAsync(id);
            if (permission_Members == null)
            {
                return NotFound();
            }

            _context.Permission_Members.Remove(permission_Members);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Permission_MembersExists(int id)
        {
            return _context.Permission_Members.Any(e => e.Permission_MembersId == id);
        }
    }
}
