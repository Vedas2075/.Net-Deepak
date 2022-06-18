using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HellpApi.Data;
using HellpApi.Models;

namespace HellpApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CollegesController : ControllerBase
    {
        private readonly HellpApiContext _context;

        public CollegesController(HellpApiContext context)
        {
            _context = context;
        }

        // GET: api/Colleges
        [HttpGet]
        public async Task<ActionResult<IEnumerable<College>>> GetCollege()
        {
          if (_context.College == null)
          {
              return NotFound();
          }
            return await _context.College.ToListAsync();
        }

        // GET: api/Colleges/5
        [HttpGet("{id}")]
        public async Task<ActionResult<College>> GetCollege(int id)
        {
          if (_context.College == null)
          {
              return NotFound();
          }
            var college = await _context.College.FindAsync(id);

            if (college == null)
            {
                return NotFound();
            }

            return college;
        }

        // PUT: api/Colleges/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCollege(int id, College college)
        {
            if (id != college.Id)
            {
                return BadRequest();
            }

            _context.Entry(college).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CollegeExists(id))
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

        // POST: api/Colleges
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<College>> PostCollege(College college)
        {
          if (_context.College == null)
          {
              return Problem("Entity set 'HellpApiContext.College'  is null.");
          }
            _context.College.Add(college);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCollege", new { id = college.Id }, college);
        }

        // DELETE: api/Colleges/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCollege(int id)
        {
            if (_context.College == null)
            {
                return NotFound();
            }
            var college = await _context.College.FindAsync(id);
            if (college == null)
            {
                return NotFound();
            }

            _context.College.Remove(college);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CollegeExists(int id)
        {
            return (_context.College?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
