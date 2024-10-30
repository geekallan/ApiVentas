using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiVentas.Models;

namespace ApiVentas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenusController : ControllerBase
    {
        private readonly Conexiones _context;

        public MenusController(Conexiones context)
        {
            _context = context;
        }

        // GET: api/Menus
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Menus>>> GetMenus()
        {
            return await _context.Menus.ToListAsync();
        }

        // GET: api/Menus/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Menus>> GetMenus(int id)
        {
            var menus = await _context.Menus.FindAsync(id);

            if (menus == null)
            {
                return NotFound();
            }

            return menus;
        }

        // PUT: api/Menus/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMenus(int id, Menus menus)
        {
            if (id != menus.id_menu)
            {
                return BadRequest();
            }

            _context.Entry(menus).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MenusExists(id))
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

        // POST: api/Menus
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Menus>> PostMenus(Menus menus)
        {
            _context.Menus.Add(menus);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMenus", new { id = menus.id_menu }, menus);
        }

        // DELETE: api/Menus/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMenus(int id)
        {
            var menus = await _context.Menus.FindAsync(id);
            if (menus == null)
            {
                return NotFound();
            }

            _context.Menus.Remove(menus);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MenusExists(int id)
        {
            return _context.Menus.Any(e => e.id_menu == id);
        }
    }
}
