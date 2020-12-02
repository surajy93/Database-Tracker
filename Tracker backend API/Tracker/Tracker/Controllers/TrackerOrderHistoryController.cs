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
    public class TrackerOrderHistoryController : ControllerBase
    {
        private readonly TrackerOrderHistoryContext _context;

        public TrackerOrderHistoryController(TrackerOrderHistoryContext context)
        {
            _context = context;
        }

        // GET: api/TrackerOrderHistory
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TrackerOrderHistory>>> GetTrackerOrderHistory()
        {
            return await _context.TrackerOrderHistory.ToListAsync();
        }

        // GET: api/TrackerOrderHistory/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TrackerOrderHistory>> GetTrackerOrderHistory(int id)
        {
            var trackerOrderHistory = await _context.TrackerOrderHistory.FindAsync(id);

            if (trackerOrderHistory == null)
            {
                return NotFound();
            }

            return trackerOrderHistory;
        }

        // PUT: api/TrackerOrderHistory/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTrackerOrderHistory(int id, TrackerOrderHistory trackerOrderHistory)
        {
            if (id != trackerOrderHistory.TrackerOrderHistoryId)
            {
                return BadRequest();
            }

            _context.Entry(trackerOrderHistory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TrackerOrderHistoryExists(id))
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

        // POST: api/TrackerOrderHistory
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TrackerOrderHistory>> PostTrackerOrderHistory(TrackerOrderHistory trackerOrderHistory)
        {
            _context.TrackerOrderHistory.Add(trackerOrderHistory);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetTrackerOrderHistory), new { id = trackerOrderHistory.TrackerOrderHistoryId }, trackerOrderHistory);
        }

        // DELETE: api/TrackerOrderHistory/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TrackerOrderHistory>> DeleteTrackerOrderHistory(int id)
        {
            var trackerOrderHistory = await _context.TrackerOrderHistory.FindAsync(id);
            if (trackerOrderHistory == null)
            {
                return NotFound();
            }

            _context.TrackerOrderHistory.Remove(trackerOrderHistory);
            await _context.SaveChangesAsync();

            return trackerOrderHistory;
        }

        private bool TrackerOrderHistoryExists(int id)
        {
            return _context.TrackerOrderHistory.Any(e => e.TrackerOrderHistoryId == id);
        }
    }
}
