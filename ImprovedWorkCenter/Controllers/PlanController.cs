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
            return View();
        }

        // POST: Plan/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Precio,PlanId,TipoPlan")] Plan plan)
        {
            bool existeTipo = _context.Planes.Any(s => s.TipoPlan == plan.TipoPlan);
            if (existeTipo)
            {
                ModelState.AddModelError(String.Empty, "El Plan ingresado ya existe.");

                return View(plan);
            }
            if (ModelState.IsValid)
            {
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
            return View(plan);
        }

        // POST: Plan/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Precio,PlanId,TipoPlan")] Plan plan)
        {
            if (id != plan.PlanId)
            {
                return NotFound();
            }

            // Valida si se realizó algúna modificación, caso contrario muestra Mensaje de Error
            bool seRealizoAccion = _context.Planes.Any(p => p.Precio == plan.Precio && p.TipoPlan == plan.TipoPlan);
            if (seRealizoAccion)
            {
                ModelState.AddModelError(String.Empty, "No se ha modificado ningún dato o el Plan ingresado ya existe.");

                return View(plan);
            }

            if (ModelState.IsValid)
            {
                try
                {
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
