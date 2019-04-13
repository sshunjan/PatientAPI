using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PatientAPI.Model;

namespace PatientAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientDetailsController : ControllerBase
    {
        private readonly PatientDetailsContext _context;

        public PatientDetailsController(PatientDetailsContext context)
        {
            _context = context;
        }

        // GET: api/PatientDetails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PatientDetails>>> GetPatientDetails()
        {
            return await _context.PatientDetails.ToListAsync();
        }

        // GET: api/PatientDetails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PatientDetails>> GetPatientDetails(int id)
        {
            var patientDetails = await _context.PatientDetails.FindAsync(id);

            if (patientDetails == null)
            {
                return NotFound();
            }

            return patientDetails;
        }

        // PUT: api/PatientDetails/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPatientDetails(int id, PatientDetails patientDetails)
        {
            if (id != patientDetails.Id)
            {
                return BadRequest();
            }

            _context.Entry(patientDetails).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PatientDetailsExists(id))
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

        // POST: api/PatientDetails
        [HttpPost]
        public async Task<ActionResult<PatientDetails>> PostPatientDetails(PatientDetails patientDetails)
        {
            _context.PatientDetails.Add(patientDetails);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPatientDetails", new { id = patientDetails.Id }, patientDetails);
        }

        // DELETE: api/PatientDetails/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<PatientDetails>> DeletePatientDetails(int id)
        {
            var patientDetails = await _context.PatientDetails.FindAsync(id);
            if (patientDetails == null)
            {
                return NotFound();
            }

            _context.PatientDetails.Remove(patientDetails);
            await _context.SaveChangesAsync();

            return patientDetails;
        }

        private bool PatientDetailsExists(int id)
        {
            return _context.PatientDetails.Any(e => e.Id == id);
        }
    }
}
