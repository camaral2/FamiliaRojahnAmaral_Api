using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FamiliaRojanAmaralApi.Models;
using FamiliaRojanAmaralApi.Dtos;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;

namespace FamiliaRojahnAmaral_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CatalogoItemsController : ControllerBase
    {
        private readonly CatalogoContext _context;

        public CatalogoItemsController(CatalogoContext context)
        {
            _context = context;
        }

        // GET: api/CatalogoItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CatalogoItem>>> GetCatalogoItems()
        {
            return await _context.CatalogoItems.ToListAsync();
        }

        // GET: api/CatalogoItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CatalogoItem>> GetCatalogoItem(long id)
        {
            var catalogoItem = await _context.CatalogoItems.FindAsync(id);

            if (catalogoItem == null)
            {
                return NotFound();
            }

            return catalogoItem;
        }

        // PUT: api/CatalogoItems/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCatalogoItem(long id, CatalogoItem catalogoItem)
        {
            if (id != catalogoItem.Id)
            {
                return BadRequest();
            }

            _context.Entry(catalogoItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CatalogoItemExists(id))
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

        // POST: api/CatalogoItems
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CatalogoItem>> PostCatalogoItem(CatalogoItem catalogoItem)
        {
            _context.CatalogoItems.Add(catalogoItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetCatalogoItem), new { id = catalogoItem.Id }, catalogoItem);
        }

        // DELETE: api/CatalogoItems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCatalogoItem(long id)
        {
            var catalogoItem = await _context.CatalogoItems.FindAsync(id);
            if (catalogoItem == null)
            {
                return NotFound();
            }

            _context.CatalogoItems.Remove(catalogoItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CatalogoItemExists(long id)
        {
            return _context.CatalogoItems.Any(e => e.Id == id);
        }
    }
}
