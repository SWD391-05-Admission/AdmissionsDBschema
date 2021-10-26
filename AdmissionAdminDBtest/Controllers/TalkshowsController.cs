using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AdmissionAdminDBtest.Models;

namespace AdmissionAdminDBtest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TalkshowsController : ControllerBase
    {
        private readonly AdmissionsDBContext _context;

        public TalkshowsController(AdmissionsDBContext context)
        {
            _context = context;
        }

        // GET: api/Talkshows
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Talkshow>>> GetTalkshows()
        {
            return await _context.Talkshows.ToListAsync();
        }

        // GET: api/Talkshows/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Talkshow>> GetTalkshow(int id)
        {
            var talkshow = await _context.Talkshows.FindAsync(id);

            if (talkshow == null)
            {
                return NotFound();
            }

            return talkshow;
        }
        // GET: api/Talkshows/5
        [HttpGet("GetTalkshowDetails/{id}")]
        public async Task<ActionResult<Talkshow>> GetTalkshowDetails(int id)
        {
            var talkshow = _context.Talkshows
                                            .Include(talkshow => talkshow.Counselor)
                                            .Include(talkshow => talkshow.Major)
                                            .Include(talkshow => talkshow.University)
                                            .Where(talkshow => talkshow.Id == id)
                                            .FirstOrDefault();

            if (talkshow == null)
            {
                return NotFound();
            }

            return talkshow;
        }

        // PUT: api/Talkshows/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTalkshow(int id, Talkshow talkshow)
        {
            if (id != talkshow.Id)
            {
                return BadRequest();
            }

            _context.Entry(talkshow).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TalkshowExists(id))
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

        // POST: api/Talkshows
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Talkshow>> PostTalkshow(Talkshow talkshow)
        {
            _context.Talkshows.Add(talkshow);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTalkshow", new { id = talkshow.Id }, talkshow);
        }

        // DELETE: api/Talkshows/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Talkshow>> DeleteTalkshow(int id)
        {
            var talkshow = await _context.Talkshows.FindAsync(id);
            if (talkshow == null)
            {
                return NotFound();
            }

            _context.Talkshows.Remove(talkshow);
            await _context.SaveChangesAsync();

            return talkshow;
        }

        private bool TalkshowExists(int id)
        {
            return _context.Talkshows.Any(e => e.Id == id);
        }
    }
}
