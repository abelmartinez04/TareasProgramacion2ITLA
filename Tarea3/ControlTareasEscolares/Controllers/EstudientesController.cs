using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ControlTareasEscolares.Data;
using ControlTareasEscolares.Models.Entities;

namespace ControlTareasEscolares.Controllers
{
    public class EstudientesController : Controller
    {
        private readonly ControlTareasEscolaresContext _context;

        public EstudientesController(ControlTareasEscolaresContext context)
        {
            _context = context;
        }

        // GET: Estudientes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Estudiantes.ToListAsync());
        }

        // GET: Estudientes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estudiente = await _context.Estudiantes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (estudiente == null)
            {
                return NotFound();
            }

            return View(estudiente);
        }

        // GET: Estudientes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Estudientes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,Correo,FechaRegistro")] Estudiente estudiente)
        {
            if (ModelState.IsValid)
            {
                _context.Add(estudiente);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(estudiente);
        }

        // GET: Estudientes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estudiente = await _context.Estudiantes.FindAsync(id);
            if (estudiente == null)
            {
                return NotFound();
            }
            return View(estudiente);
        }

        // POST: Estudientes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,Correo,FechaRegistro")] Estudiente estudiente)
        {
            if (id != estudiente.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(estudiente);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EstudienteExists(estudiente.Id))
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
            return View(estudiente);
        }

        // GET: Estudientes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estudiente = await _context.Estudiantes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (estudiente == null)
            {
                return NotFound();
            }

            return View(estudiente);
        }

        // POST: Estudientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var estudiente = await _context.Estudiantes.FindAsync(id);
            if (estudiente != null)
            {
                _context.Estudiantes.Remove(estudiente);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EstudienteExists(int id)
        {
            return _context.Estudiantes.Any(e => e.Id == id);
        }
    }
}
