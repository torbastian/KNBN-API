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
    public class Group_MemberController : ControllerBase
    {
        private readonly KanbanContext _context;

        public Group_MemberController(KanbanContext context)
        {
            _context = context;
        }

        // GET: api/Group_Member
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Group_Member>>> GetGroup_Members()
        {
            return await _context.Group_Members.ToListAsync();
        }

        // GET: api/Group_Member/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Group_Member>> GetGroup_Member(int id)
        {
            var group_Member = await _context.Group_Members.FindAsync(id);

            if (group_Member == null)
            {
                return NotFound();
            }

            return group_Member;
        }

        // PUT: api/Group_Member/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGroup_Member(int id, Group_Member group_Member)
        {
            if (id != group_Member.Group_MemberId)
            {
                return BadRequest();
            }

            _context.Entry(group_Member).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Group_MemberExists(id))
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

        // POST: api/Group_Member
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Group_Member>> PostGroup_Member(Group_Member group_Member)
        {
            _context.Group_Members.Add(group_Member);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGroup_Member", new { id = group_Member.Group_MemberId }, group_Member);
        }

        // DELETE: api/Group_Member/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGroup_Member(int id)
        {
            var group_Member = await _context.Group_Members.FindAsync(id);
            if (group_Member == null)
            {
                return NotFound();
            }

            _context.Group_Members.Remove(group_Member);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Group_MemberExists(int id)
        {
            return _context.Group_Members.Any(e => e.Group_MemberId == id);
        }
    }
}
