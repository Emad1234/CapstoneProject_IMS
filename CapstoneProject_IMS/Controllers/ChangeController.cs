using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CapstoneProject_IMS.Models;

namespace CapstoneProject_IMS.Controllers
{
    public class ChangeController : Controller
    {
        private readonly StatusBoardContext _context;

        public ChangeController(StatusBoardContext context)
        {
            _context = context;
        }

        // GET: Change
        public async Task<IActionResult> Index()
        {
            var statusBoardContext = _context.Change
                .Where(i => i.ChangeComplete == false)
                .Include(c => c.Location).Include(c => c.Team)
                .OrderByDescending(i => i.ChangeStart);
            return View(await statusBoardContext.ToListAsync());
        }

        // GET: Change/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var change = await _context.Change
                .Include(c => c.Location)
                .Include(c => c.Team)
                .FirstOrDefaultAsync(m => m.ChangeId == id);
            if (change == null)
            {
                return NotFound();
            }

            return View(change);
        }

        // GET: Change/Create
        public IActionResult Create()
        {
            ViewData["LocationId"] = new SelectList(_context.Location, "LocationId", "LocationEmail");
            ViewData["TeamId"] = new SelectList(_context.IncidentTeam, "TeamId", "TeamEmail");
            return View();
        }

        // POST: Change/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ChangeId,ChangeTitle,ChangeDescription,ChangeStart,ChangeEnd,ChangeComplete,ExternalTicket,ExternalTicketUrl,LocationId,LocationUrl,TeamId")] Change change)
        {
            if (ModelState.IsValid)
            {
                _context.Add(change);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["LocationId"] = new SelectList(_context.Location, "LocationId", "LocationEmail", change.LocationId);
            ViewData["TeamId"] = new SelectList(_context.IncidentTeam, "TeamId", "TeamEmail", change.TeamId);
            return View(change);
        }

        // GET: Change/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var change = await _context.Change.FindAsync(id);
            if (change == null)
            {
                return NotFound();
            }
            ViewData["LocationId"] = new SelectList(_context.Location, "LocationId", "LocationName", change.LocationId);
            ViewData["TeamId"] = new SelectList(_context.IncidentTeam, "TeamId", "TeamName", change.TeamId);
            return View(change);
        }

        // POST: Change/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ChangeId,ChangeTitle,ChangeDescription,ChangeComplete,ExternalTicket,ExternalTicketUrl,LocationId,LocationUrl,TeamId")] Change change)
        {
            if (id != change.ChangeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(change);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ChangeExists(change.ChangeId))
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
            ViewData["LocationId"] = new SelectList(_context.Location, "LocationId", "LocationName", change.LocationId);
            ViewData["TeamId"] = new SelectList(_context.IncidentTeam, "TeamId", "TeamName", change.TeamId);
            return View(change);
        }

        // GET: Change/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var change = await _context.Change
                .Include(c => c.Location)
                .Include(c => c.Team)
                .FirstOrDefaultAsync(m => m.ChangeId == id);
            if (change == null)
            {
                return NotFound();
            }

            return View(change);
        }

        // POST: Change/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var change = await _context.Change.FindAsync(id);
            _context.Change.Remove(change);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ChangeExists(int id)
        {
            return _context.Change.Any(e => e.ChangeId == id);
        }
    }
}
