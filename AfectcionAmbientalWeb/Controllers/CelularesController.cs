using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AfectcionAmbientalWeb.Data;
using AfectcionAmbientalWeb.Models;
using Microsoft.AspNetCore.Authorization;


namespace AfectcionAmbientalWeb.Controllers
{
    [Authorize(Roles = "administrador")]
    public class CelularesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CelularesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Celulares
        public async Task<IActionResult> Index()
        {
            return View(await _context.Celulars.ToListAsync());
        }

        // GET: Celulares/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var celular = await _context.Celulars
                .FirstOrDefaultAsync(m => m.CelularId == id);
            if (celular == null)
            {
                return NotFound();
            }

            return View(celular);
        }
        [Authorize]
        // GET: Celulares/Create
        public IActionResult Create()
        {
            return View();
        }
        [Authorize]
        // POST: Celulares/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Marca,Modelo")] Celular celular)
        {
            if (ModelState.IsValid)
            {
                _context.Add(celular);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(celular);
        }
        [Authorize]
        // GET: Celulares/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var celular = await _context.Celulars.FindAsync(id);
            if (celular == null)
            {
                return NotFound();
            }
            return View(celular);
        }
       //[Authorize]
        // POST: Celulares/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Marca,Modelo")] Celular celular)
        {
            if (id != celular.CelularId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(celular);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CelularExists(celular.CelularId))
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
            return View(celular);
        }
        [Authorize]
        // GET: Celulares/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var celular = await _context.Celulars
                .FirstOrDefaultAsync(m => m.CelularId == id);
            if (celular == null)
            {
                return NotFound();
            }

            return View(celular);
        }
        [Authorize]
        // POST: Celulares/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var celular = await _context.Celulars.FindAsync(id);
            _context.Celulars.Remove(celular);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CelularExists(int id)
        {
            return _context.Celulars.Any(e => e.CelularId == id);
        }
    }
}
