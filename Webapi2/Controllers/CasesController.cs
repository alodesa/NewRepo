using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Webapi2.Entitites;

namespace Webapi2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CasesController : ControllerBase
    {
        private readonly DataContext _context;

        public CasesController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Cases
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Case>>> GetCases()
        {
            return await _context.Cases
                .Include(c => c.Customers)
                .Include(c => c.CaseWorkers)
                .Include(c => c.CaseStatus)
                .ToListAsync();
        }

        // GET: api/Cases/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Case>> GetCase(int id)
        {
            var @case = await _context.Cases.FindAsync(id);

            if (@case == null)
            {
                return NotFound();
            }

            return @case;
        }

        // PUT: api/Cases/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCase(int id, Case @case)
        {
            if (id != @case.Id)
            {
                return BadRequest();
            }

            _context.Entry(@case).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CaseExists(id))
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

        // POST: api/Cases
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Case>> PostCase(Case @case)
        {
            _context.Cases.Add(@case);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCase", new { id = @case.Id }, @case);
        }

        // DELETE: api/Cases/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Case>> DeleteCase(int id)
        {
            var @case = await _context.Cases.FindAsync(id);
            if (@case == null)
            {
                return NotFound();
            }

            _context.Cases.Remove(@case);
            await _context.SaveChangesAsync();

            return @case;
        }

        private bool CaseExists(int id)
        {
            return _context.Cases.Any(e => e.Id == id);
        }

        [HttpDelete("all")]

        public async Task<ActionResult> DeleteAllCases()
        {
            foreach (var c in _context.Cases)
            {
                _context.Cases.Remove(c);
            }
            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}
