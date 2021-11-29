using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ImprovedWorkCenter.Context;
using ImprovedWorkCenter.Models;

namespace ImprovedWorkCenter.Controllers
{
    public class SocioController : Controller
    {
        private readonly ImprovedWorkCenterContext _context;

        public SocioController(ImprovedWorkCenterContext context)
        {
            _context = context;
        }

        // GET: Socio
        public async Task<IActionResult> Index()
        {
            return View(await _context.Socios.ToListAsync());
        }

        // GET: Socio/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var socio = await _context.Socios
                .FirstOrDefaultAsync(m => m.SocioId == id);
            if (socio == null)
            {
                return NotFound();
            }

            return View(socio);
        }

        // GET: Socio/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Socio/Create --> Se valida que NO exista socio con mismo email
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SocioId,ClubId,Nombre,Apellido,Edad,Domicilio,Mail,Contrasenia,EsDeudor,FechaInscripcion,MetodoDePago")] Socio socio)
        {
            bool existeUserEmail = _context.Socios.Any(s => s.Mail == socio.Mail);
            if (existeUserEmail)
            {
                ModelState.AddModelError("Mail", "El Email ingresado ya corresponde a un Socio.");

                return View(socio);
            }
            if (ModelState.IsValid)
            {
                _context.Add(socio);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(socio);
        }

        // GET: Socio/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var socio = await _context.Socios.FindAsync(id);
            if (socio == null)
            {
                return NotFound();
            }

            return View(socio);
        }

        // Calificar como Deudor a Socio
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("Socio/CalificarDeudor/{id}")]
        public async Task<IActionResult> CalificarDeudor(int id, [Bind("EsDeudor")] Socio socio)
        {
            if (id != socio.SocioId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(socio);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SocioExists(socio.SocioId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(socio);
        }

        // POST: Socio/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SocioId,ClubId,Nombre,Apellido,Edad,Domicilio,Mail,Contrasenia,EsDeudor,FechaInscripcion,MetodoDePago")] Socio socio)
        {
            if (id != socio.SocioId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(socio);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SocioExists(socio.SocioId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(socio);
        }

        // GET: Socio/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var socio = await _context.Socios
                .FirstOrDefaultAsync(m => m.SocioId == id);
            if (socio == null)
            {
                return NotFound();
            }

            if (socio.EsDeudor)
            {
                ModelState.AddModelError(String.Empty, "Socio no puede eliminarse por ser Deudor.");
                return View(socio);
            }
            return View(socio);
        }

        // POST: Socio/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id, [Bind("SocioId,ClubId,Nombre,Apellido,Edad,Domicilio,Mail,Contrasenia,EsDeudor,FechaInscripcion,MetodoDePago")] Socio socio)
        {
            var socio2 = await _context.Socios.FindAsync(id);
            if (socio2.EsDeudor)
            {
                ModelState.AddModelError("CustomError", "Socio no puede eliminarse por ser Deudor.");
                return View(socio2);
            }
            _context.Socios.Remove(socio2);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SocioExists(int id)
        {
            return _context.Socios.Any(e => e.SocioId == id);
        }

    }
}
