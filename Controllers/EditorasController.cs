using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WMVCLivros.Models;

namespace WMVCLivros.Controllers
{
    public class EditorasController : Controller
    {
        private readonly Contexto _context;

        public EditorasController(Contexto context)
        {
            _context = context;
        }

        // GET: Editoras
        public async Task<IActionResult> Index()
        {
              return _context.Editoras != null ? 
                          View(await _context.Editoras.ToListAsync()) :
                          Problem("Entity set 'Contexto.Editoras'  is null.");
        }

        // GET: Editoras/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Editoras == null)
            {
                return NotFound();
            }

            var editoras = await _context.Editoras
                .FirstOrDefaultAsync(m => m.Id == id);
            if (editoras == null)
            {
                return NotFound();
            }

            return View(editoras);
        }

        // GET: Editoras/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Editoras/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Localizacao,Fundacao")] Editoras editoras)
        {
            if (ModelState.IsValid)
            {
                _context.Add(editoras);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(editoras);
        }

        // GET: Editoras/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Editoras == null)
            {
                return NotFound();
            }

            var editoras = await _context.Editoras.FindAsync(id);
            if (editoras == null)
            {
                return NotFound();
            }
            return View(editoras);
        }

        // POST: Editoras/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Localizacao,Fundacao")] Editoras editoras)
        {
            if (id != editoras.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(editoras);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EditorasExists(editoras.Id))
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
            return View(editoras);
        }

        // GET: Editoras/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Editoras == null)
            {
                return NotFound();
            }

            var editoras = await _context.Editoras
                .FirstOrDefaultAsync(m => m.Id == id);
            if (editoras == null)
            {
                return NotFound();
            }

            return View(editoras);
        }

        // POST: Editoras/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Editoras == null)
            {
                return Problem("Entity set 'Contexto.Editoras'  is null.");
            }
            var editoras = await _context.Editoras.FindAsync(id);
            if (editoras != null)
            {
                _context.Editoras.Remove(editoras);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EditorasExists(int id)
        {
          return (_context.Editoras?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
