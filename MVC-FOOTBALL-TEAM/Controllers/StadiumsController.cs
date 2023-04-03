using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVC_FOOTBALL_TEAM.Data;
using MVC_FOOTBALL_TEAM.Models;

namespace MVC_FOOTBALL_TEAM.Controllers
{
    public class StadiumsController : Controller
    {
        private readonly MVC_FOOTBALL_TEAMContext _context;

        public StadiumsController(MVC_FOOTBALL_TEAMContext context)
        {
            _context = context;
        }

        // GET: Stadiums
        public async Task<IActionResult> Index()
        {
              return _context.Stadium != null ? 
                          View(await _context.Stadium.ToListAsync()) :
                          Problem("Entity set 'MVC_FOOTBALL_TEAMContext.Stadium'  is null.");
        }

        // GET: Stadiums/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Stadium == null)
            {
                return NotFound();
            }

            var stadium = await _context.Stadium
                .FirstOrDefaultAsync(m => m.Id == id);
            if (stadium == null)
            {
                return NotFound();
            }

            return View(stadium);
        }

        // GET: Stadiums/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Stadiums/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,FoundationDate,Location,Team,MaxAttendance")] Stadium stadium)
        {
            if (ModelState.IsValid)
            {
                _context.Add(stadium);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(stadium);
        }

        // GET: Stadiums/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Stadium == null)
            {
                return NotFound();
            }

            var stadium = await _context.Stadium.FindAsync(id);
            if (stadium == null)
            {
                return NotFound();
            }
            return View(stadium);
        }

        // POST: Stadiums/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,FoundationDate,Location,Team,MaxAttendance")] Stadium stadium)
        {
            if (id != stadium.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(stadium);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StadiumExists(stadium.Id))
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
            return View(stadium);
        }

        // GET: Stadiums/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Stadium == null)
            {
                return NotFound();
            }

            var stadium = await _context.Stadium
                .FirstOrDefaultAsync(m => m.Id == id);
            if (stadium == null)
            {
                return NotFound();
            }

            return View(stadium);
        }

        // POST: Stadiums/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Stadium == null)
            {
                return Problem("Entity set 'MVC_FOOTBALL_TEAMContext.Stadium'  is null.");
            }
            var stadium = await _context.Stadium.FindAsync(id);
            if (stadium != null)
            {
                _context.Stadium.Remove(stadium);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StadiumExists(int id)
        {
          return (_context.Stadium?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
