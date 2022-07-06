using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SistemasCP.Data;
using SistemasCP.Models;

namespace SistemasCP.Controllers
{
    public class CriminalCodesController : Controller
    {
        private readonly SistemasCPContext _context;

        public CriminalCodesController(SistemasCPContext context)
        {
            _context = context;
        }

        // GET: CriminalCodes
        public async Task<IActionResult> Index()
        {
              return _context.CriminalCode != null ? 
                          View(await _context.CriminalCode.ToListAsync()) :
                          Problem("Entity set 'SistemasCPContext.CriminalCode'  is null.");
        }

        // GET: CriminalCodes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.CriminalCode == null)
            {
                return NotFound();
            }

            var criminalCode = await _context.CriminalCode
                .FirstOrDefaultAsync(m => m.Id == id);
            if (criminalCode == null)
            {
                return NotFound();
            }

            return View(criminalCode);
        }

        // GET: CriminalCodes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CriminalCodes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,name,description,Penalty,PrisionTime,StatusId,CreateDate,UpdateDate,CreateUserId,UpdateUserId")] CriminalCodes criminalCode)
        {
            if (ModelState.IsValid)
            {
                _context.Add(criminalCode);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(criminalCode);
        }

        // GET: CriminalCodes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.CriminalCode == null)
            {
                return NotFound();
            }

            var criminalCode = await _context.CriminalCode.FindAsync(id);
            if (criminalCode == null)
            {
                return NotFound();
            }
            return View(criminalCode);
        }

        // POST: CriminalCodes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,name,description,Penalty,PrisionTime,StatusId,CreateDate,UpdateDate,CreateUserId,UpdateUserId")] CriminalCodes criminalCode)
        {
            if (id != criminalCode.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(criminalCode);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CriminalCodeExists(criminalCode.Id))
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
            return View(criminalCode);
        }

        // GET: CriminalCodes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.CriminalCode == null)
            {
                return NotFound();
            }

            var criminalCode = await _context.CriminalCode
                .FirstOrDefaultAsync(m => m.Id == id);
            if (criminalCode == null)
            {
                return NotFound();
            }

            return View(criminalCode);
        }

        // POST: CriminalCodes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.CriminalCode == null)
            {
                return Problem("Entity set 'SistemasCPContext.CriminalCode'  is null.");
            }
            var criminalCode = await _context.CriminalCode.FindAsync(id);
            if (criminalCode != null)
            {
                _context.CriminalCode.Remove(criminalCode);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CriminalCodeExists(int id)
        {
          return (_context.CriminalCode?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
