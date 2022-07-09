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
    public class ActividadController : Controller
    {
        private readonly ImprovedWorkCenterContext _context;

        public ActividadController(ImprovedWorkCenterContext context)
        {
            _context = context;
        }

        // GET: Actividad
        public async Task<IActionResult> Index()
        {
            return View(await _context.Actividades.ToListAsync());
        }

        // GET: Actividad/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var actividad = await _context.Actividades
                .FirstOrDefaultAsync(m => m.ActividadId == id);
            if (actividad == null)
            {
                return NotFound();
            }

            return View(actividad);
        }

        // GET: Actividad/Create
        public IActionResult Create()
        {

            bool existenSocios = _context.Socios.Count() > 0;
            if (!existenSocios)
            {
                ModelState.AddModelError(String.Empty, "No existen socios para asignar una Actividad, cargue uno y vuelva a intentar");
                return View();
            }

            var sociosAElegir = from s in _context.Socios
                                select s;

            ViewBag.SociosActividad = new SelectList(sociosAElegir.ToList(), "SocioId", "Nombre", "Apellido");

            return View();
        }

        // POST: Actividad/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ActividadId,SocioId,NombreSocio,Tipo,HorarioInicio,HorarioFinal")] Actividad actividad)
        {

            bool existeActividad = _context.Actividades.Any(a => a.Tipo == actividad.Tipo && a.HorarioInicio == actividad.HorarioInicio && a.HorarioFinal == actividad.HorarioFinal);

            bool existenSocios = _context.Socios.Count() > 0;

            if (existeActividad)
            {
                ModelState.AddModelError(String.Empty, "Ya tiene la actividad " + actividad.Tipo + " en ese horario.");
                return View(actividad);
            }

            if (!existenSocios)
            {
                ModelState.AddModelError(String.Empty, "No existen socios para asignar una Actividad, cargue uno y vuelva a intentar");
                return View(actividad);
            }

            var sociosAElegir = from s in _context.Socios
                                select s;

            ViewBag.SociosActividad = new SelectList(sociosAElegir.ToList(), "SocioId", "Nombre", "Apellido");

            if (ModelState.IsValid)
            {

                var socio = await _context.Socios.FindAsync(actividad.SocioId);

                bool esDeudor = socio.EsDeudor;
                
                if (esDeudor)
                {
                    ModelState.AddModelError(String.Empty, "No se puede agregar Actividad, el Socio: " + socio.Nombre + " " + socio.Apellido + " es Deudor.");
                    return View(actividad);
                }
                actividad.NombreSocio = socio.Nombre.ToString() + " " + socio.Apellido.ToString();
                _context.Add(actividad);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(actividad);
        }

        // GET: Actividad/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var actividad = await _context.Actividades.FindAsync(id);
            if (actividad == null)
            {
                return NotFound();
            }

            var sociosAElegir = from s in _context.Socios
                                select s;

            ViewBag.SociosActividad = new SelectList(sociosAElegir.ToList(), "SocioId", "Nombre", "Apellido");

            return View(actividad);
        }

        // POST: Actividad/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ActividadId,SocioId,NombreSocio,Tipo,HorarioInicio,HorarioFinal")] Actividad actividad)
        {
            if (id != actividad.ActividadId)
            {
                return NotFound();
            }
            // Valida si se realizó algúna modificación, caso contrario muestra Mensaje de Error
            bool seRealizoModificacion = _context.Actividades.Any(a => a.Tipo == actividad.Tipo && a.HorarioInicio == actividad.HorarioInicio && a.HorarioFinal == actividad.HorarioFinal && a.NombreSocio == actividad.NombreSocio);
            if (seRealizoModificacion)
            {
                ModelState.AddModelError(String.Empty, "No se ha modificado ningún dato o la Actividad ingresada ya existe.");

                return View(actividad);
            }

            var sociosAElegir = from s in _context.Socios
                                select s;

            ViewBag.SociosActividad = new SelectList(sociosAElegir.ToList(), "SocioId", "Nombre", "Apellido");

            if (ModelState.IsValid)
            {
                try
                {
                    var socioAEditar = await _context.Socios.FindAsync(actividad.SocioId);

                    if (socioAEditar.EsDeudor)
                    {
                        ModelState.AddModelError(String.Empty, "No se puede agregar Actividad, el Socio: " + socioAEditar.Nombre + " " + socioAEditar.Apellido + " es Deudor.");
                        return View(actividad);
                    }
                    var socio = await _context.Socios.FindAsync(actividad.SocioId);
                    actividad.NombreSocio = socio.Nombre.ToString() + " " + socio.Apellido.ToString();
                    _context.Update(actividad);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ActividadExists(actividad.ActividadId))
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
            return View(actividad);
        }

        // GET: Actividad/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var actividad = await _context.Actividades
                .FirstOrDefaultAsync(m => m.ActividadId == id);
            if (actividad == null)
            {
                return NotFound();
            }

            return View(actividad);
        }

        // POST: Actividad/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var actividad = await _context.Actividades.FindAsync(id);
            _context.Actividades.Remove(actividad);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ActividadExists(int id)
        {
            return _context.Actividades.Any(e => e.ActividadId == id);
        }
    }
}
