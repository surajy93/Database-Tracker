using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tracker.Data;
using Tracker.Models;

namespace Tracker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Sim_InfoController : ControllerBase
    {
        private readonly Sim_InfoContext _context;

        public Sim_InfoController(Sim_InfoContext context)
        {
            _context = context;
        }

        // GET: api/Sim_Info
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Sim_Info>>> GetSim_Info()
        {
            return await _context.Sim_Info.ToListAsync();
        }

        // GET: api/Sim_Info/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Sim_Info>> GetSim_Info(int id)
        {
            var sim_Info = await _context.Sim_Info.FindAsync(id);

            if (sim_Info == null)
            {
                return NotFound();
            }

            return sim_Info;
        }

        // PUT: api/Sim_Info/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSim_Info(int id, Sim_Info sim_Info)
        {
            if (id != sim_Info.Sim_InfoId)
            {
                return BadRequest();
            }

            _context.Entry(sim_Info).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Sim_InfoExists(id))
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

        // POST: api/Sim_Info
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Sim_Info>> PostSim_Info(Sim_Info sim_Info)
        {
            _context.Sim_Info.Add(sim_Info);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetSim_Info), new { id = sim_Info.Sim_InfoId }, sim_Info);
        }

        // DELETE: api/Sim_Info/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Sim_Info>> DeleteSim_Info(int id)
        {
            var sim_Info = await _context.Sim_Info.FindAsync(id);
            if (sim_Info == null)
            {
                return NotFound();
            }

            _context.Sim_Info.Remove(sim_Info);
            await _context.SaveChangesAsync();

            return sim_Info;
        }

        private bool Sim_InfoExists(int id)
        {
            return _context.Sim_Info.Any(e => e.Sim_InfoId == id);
        }
    }
}
