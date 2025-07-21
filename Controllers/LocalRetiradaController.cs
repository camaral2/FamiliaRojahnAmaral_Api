using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FamiliaRojanAmaralApi.Models;
using Microsoft.AspNetCore.Authorization;

namespace FamiliaRojahnAmaral_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class LocalRetiradaController : ControllerBase
    {
        private readonly LocalRetiradaContext _context;

        public LocalRetiradaController(LocalRetiradaContext context)
        {
            _context = context;
        }

        // GET: api/LocalRetirada
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LocalRetirada>>> GetLocalRetirada()
        {
            return await _context.LocalRetirada.ToListAsync();
        }

        // GET: api/LocalRetirada/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LocalRetirada>> GetLocalRetirada(int id)
        {
            var localRetirada = await _context.LocalRetirada.FindAsync(id);

            if (localRetirada == null)
            {
                return NotFound();
            }

            return localRetirada;
        }

        // PUT: api/LocalRetirada/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLocalRetirada(int id, LocalRetirada localRetirada)
        {
            if (id != localRetirada.Id)
            {
                return BadRequest();
            }

            _context.Entry(localRetirada).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LocalRetiradaExists(id))
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

        // POST: api/LocalRetirada
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<LocalRetirada>> PostLocalRetirada(LocalRetirada localRetirada)
        {
            _context.LocalRetirada.Add(localRetirada);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLocalRetirada", new { id = localRetirada.Id }, localRetirada);
        }

        // DELETE: api/LocalRetirada/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLocalRetirada(int id)
        {
            var localRetirada = await _context.LocalRetirada.FindAsync(id);
            if (localRetirada == null)
            {
                return NotFound();
            }

            _context.LocalRetirada.Remove(localRetirada);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool LocalRetiradaExists(int id)
        {
            return _context.LocalRetirada.Any(e => e.Id == id);
        }
    }
}
