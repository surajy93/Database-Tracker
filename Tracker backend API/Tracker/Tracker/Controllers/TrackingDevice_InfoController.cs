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
    public class TrackingDevice_InfoController : ControllerBase
    {
        private readonly TrackingDevice_InfoContext _context;

        public TrackingDevice_InfoController(TrackingDevice_InfoContext context)
        {
            _context = context;
        }

        // GET: api/TrackingDevice_Info
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TrackingDevice_Info>>> GetTrackingDevice_Info()
        {
            return await _context.TrackingDevice_Info.ToListAsync();
        }

        // GET: api/TrackingDevice_Info/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TrackingDevice_Info>> GetTrackingDevice_Info(int id)
        {
            var trackingDevice_Info = await _context.TrackingDevice_Info.FindAsync(id);

            if (trackingDevice_Info == null)
            {
                return NotFound();
            }

            return trackingDevice_Info;
        }

        // PUT: api/TrackingDevice_Info/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTrackingDevice_Info(int id, TrackingDevice_Info trackingDevice_Info)
        {
            if (id != trackingDevice_Info.TrackingDevice_InfoId)
            {
                return BadRequest();
            }

            _context.Entry(trackingDevice_Info).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TrackingDevice_InfoExists(id))
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

        // POST: api/TrackingDevice_Info
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TrackingDevice_Info>> PostTrackingDevice_Info(TrackingDevice_Info trackingDevice_Info)
        {
            _context.TrackingDevice_Info.Add(trackingDevice_Info);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetTrackingDevice_Info), new { id = trackingDevice_Info.TrackingDevice_InfoId }, trackingDevice_Info);
        }

        // DELETE: api/TrackingDevice_Info/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TrackingDevice_Info>> DeleteTrackingDevice_Info(int id)
        {
            var trackingDevice_Info = await _context.TrackingDevice_Info.FindAsync(id);
            if (trackingDevice_Info == null)
            {
                return NotFound();
            }

            _context.TrackingDevice_Info.Remove(trackingDevice_Info);
            await _context.SaveChangesAsync();

            return trackingDevice_Info;
        }

        private bool TrackingDevice_InfoExists(int id)
        {
            return _context.TrackingDevice_Info.Any(e => e.TrackingDevice_InfoId == id);
        }
    }
}
