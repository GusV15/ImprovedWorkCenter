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
    public class PlanController : Controller
    {
        private readonly ImprovedWorkCenterContext _context;

        public PlanController(ImprovedWorkCenterContext context)
        {
            _context = context;
        }

        // GET: Plan
        public async Task<IActionResult> Index()
        {
            return View(await _context.Planes.ToListAsync());
        }

        // GET: Plan/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var plan = await _context.Planes
                .FirstOrDefaultAsync(m => m.PlanId == id);
            if (plan == null)
            {
                return NotFound();
            }

            return View(plan);
        }

        // GET: Plan/Create
        public IActionResult Create()
        {
            bool existenSocios = _context.Socios.Count() > 0;

            if (!existenSocios)
            {
                ModelState.AddModelError(String.Empty, "No existen socios para asignar un Plan, cargue uno y vuelva a intentar");
                return View();
            }

            var sociosAElegir = from s in _context.Socios
                                select s;

            ViewBag.SociosActividad = new SelectList(sociosAElegir.ToList(), "SocioId", "Nombre", "Apellido");

            return View();
        }

        // POST: Plan/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PlanId,SocioId,NombreSocio,Precio,TipoPlan")] Plan plan)
        {
            var sociosAElegir = from s in _context.Socios
                                select s;

            ViewBag.SociosActividad = new SelectList(sociosAElegir.ToList(), "SocioId", "Nombre", "Apellido");

            if (ModelState.IsValid)
            {
                var socio = await _context.Socios.FindAsync(plan.SocioId);

                bool existeTipo = _context.Planes.Any(s => s.SocioId == plan.SocioId);

                if (existeTipo)
                {
                    ModelState.AddModelError(String.Empty, "El Socio " + socio.Nombre + " " + socio.Apellido + " ya cuenta con un plan.");

                    return View(plan);
                }

                bool esDeudor = socio.EsDeudor;

                if (esDeudor)
                {
                    ModelState.AddModelError(String.Empty, "No se puede agregar Actividad, el Socio: " + socio.Nombre + " " + socio.Apellido + " es Deudor.");
                    return View(plan);
                }
                plan.NombreSocio = socio.Nombre.ToString() + " " + socio.Apellido.ToString();

                _context.Add(plan);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(plan);
        }

        // GET: Plan/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var plan = await _context.Planes.FindAsync(id);
            if (plan == null)
            {
                return NotFound();
            }

            var sociosAElegir = from s in _context.Socios
                                select s;

            ViewBag.SociosActividad = new SelectList(sociosAElegir.ToList(), "SocioId", "Nombre", "Apellido");

            return View(plan);
        }

        // POST: Plan/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PlanId,SocioId,NombreSocio,Precio,TipoPlan")] Plan plan)
        {
            if (id != plan.PlanId)
            {
                return NotFound();
            }

            var sociosAElegir = from s in _context.Socios
                                select s;

            ViewBag.SociosActividad = new SelectList(sociosAElegir.ToList(), "SocioId", "Nombre", "Apellido");

            if (ModelState.IsValid)
            {
                try
                {
                    var socio = await _context.Socios.FindAsync(plan.SocioId);
                    // Valida si se realizó algúna modificación, caso contrario muestra Mensaje de Error
                    bool seRealizoAccion = _context.Planes.Any(s => s.TipoPlan == plan.TipoPlan && s.SocioId == plan.SocioId);
                    if (seRealizoAccion)
                    {
                        ModelState.AddModelError(String.Empty, "No se realizaron modificaciones o el Socio " + socio.Nombre + " " + socio.Apellido + " ya cuenta con un plan.");

                        return View(plan);
                    }
                    
                    plan.NombreSocio = socio.Nombre.ToString() + " " + socio.Apellido.ToString();
                    _context.Update(plan);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PlanExists(plan.PlanId))
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
            return View(plan);
        }

        // GET: Plan/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var plan = await _context.Planes
                .FirstOrDefaultAsync(m => m.PlanId == id);
            if (plan == null)
            {
                return NotFound();
            }

            return View(plan);
        }

        // POST: Plan/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var plan = await _context.Planes.FindAsync(id);
            _context.Planes.Remove(plan);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PlanExists(int id)
        {
            return _context.Planes.Any(e => e.PlanId == id);
        }
    }
}
