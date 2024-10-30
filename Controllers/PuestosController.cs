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
    public class PuestosController : ControllerBase
    {
        private readonly Conexiones _context;

        public PuestosController(Conexiones context)
        {
            _context = context;
        }

        // GET: api/Puestos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Puestos>>> GetPuestos()
        {
            return await _context.Puestos.ToListAsync();
        }

        // GET: api/Puestos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Puestos>> GetPuestos(short id)
        {
            var puestos = await _context.Puestos.FindAsync(id);

            if (puestos == null)
            {
                return NotFound();
            }

            return puestos;
        }

        // PUT: api/Puestos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPuestos(short id, Puestos puestos)
        {
            if (id != puestos.Id_Puesto)
            {
                return BadRequest();
            }

            _context.Entry(puestos).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PuestosExists(id))
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

        // POST: api/Puestos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Puestos>> PostPuestos(Puestos puestos)
        {
            _context.Puestos.Add(puestos);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPuestos", new { id = puestos.Id_Puesto }, puestos);
        }

        // DELETE: api/Puestos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePuestos(short id)
        {
            var puestos = await _context.Puestos.FindAsync(id);
            if (puestos == null)
            {
                return NotFound();
            }

            _context.Puestos.Remove(puestos);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PuestosExists(short id)
        {
            return _context.Puestos.Any(e => e.Id_Puesto == id);
        }
    }
}
