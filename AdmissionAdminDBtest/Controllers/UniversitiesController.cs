﻿using System;
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
    public class UniversitiesController : ControllerBase
    {
        private readonly AdmissionsDBContext _context;

        public UniversitiesController(AdmissionsDBContext context)
        {
            _context = context;
        }

        // GET: api/Universities
        [HttpGet]
        public async Task<ActionResult<IEnumerable<University>>> GetUniversities()
        {
            return await _context.Universities.ToListAsync();
        }

        // GET: api/Universities/5
        [HttpGet("{id}")]
        public async Task<ActionResult<University>> GetUniversity(int id)
        {
            var university = await _context.Universities.FindAsync(id);

            if (university == null)
            {
                return NotFound();
            }

            return university;
        }
        // GET: api/Universities/5
        [HttpGet("GetUniversityDetails/{id}")]
        public async Task<ActionResult<University>> GetUniversityDetails(int id)
        {
            var university = _context.Universities
                                        .Include(uni => uni.UniMajors)
                                        .ThenInclude(major => major.Major)
                                        .Include(address => address.UniAddresses)
                                         .ThenInclude(district => district.District)
                                         .Include(admission => admission.UniAdmissions)
                                         .ThenInclude(admissions => admissions.Admission)
                                         .Include(img => img.UniImages)
                                        .Where(uni => uni.Id == id)
                                        
                                        .FirstOrDefault();

            if (university == null)
            {
                return NotFound();
            }

            return university;
        }

        // PUT: api/Universities/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUniversity(int id, University university)
        {
            if (id != university.Id)
            {
                return BadRequest();
            }

            _context.Entry(university).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UniversityExists(id))
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

        // POST: api/Universities
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<University>> PostUniversity(University university)
        {
            _context.Universities.Add(university);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUniversity", new { id = university.Id }, university);
        }

        // DELETE: api/Universities/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<University>> DeleteUniversity(int id)
        {
            var university = await _context.Universities.FindAsync(id);
            if (university == null)
            {
                return NotFound();
            }

            _context.Universities.Remove(university);
            await _context.SaveChangesAsync();

            return university;
        }

        private bool UniversityExists(int id)
        {
            return _context.Universities.Any(e => e.Id == id);
        }
    }
}
