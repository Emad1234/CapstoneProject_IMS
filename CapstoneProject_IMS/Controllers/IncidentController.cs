using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CapstoneProject_IMS.Models;
using Microsoft.AspNetCore.Http;

namespace CapstoneProject_IMS.Controllers
{
    public class IncidentController : Controller
    {
        private readonly StatusBoardContext _context;

        public IncidentController(StatusBoardContext context)
        {
            _context = context;
        }

        // GET: Incident
        public async Task<IActionResult> Index()
        {
            var statusBoardContext = _context.Incident
                .Where(i => i.IncidentResolved == false)
                .Include(i => i.Location).Include(i => i.Manager).Include(i => i.Severity).Include(i => i.Team)
                .OrderBy(i => i.SeverityId)
                .ThenByDescending(i => i.IncidentStart);
            return View(await statusBoardContext.ToListAsync());
        }

        // GET: Incident/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var incident = await _context.Incident
                .Include(i => i.Location)
                .Include(i => i.Manager)
                .Include(i => i.Severity)
                .Include(i => i.Team)
                .Include(i => i.IncidentAnnotation)
                .FirstOrDefaultAsync(m => m.IncidentId == id);
            if (incident == null)
            {
                return NotFound();
            }

            return View(incident);
        }

        // GET: Incident/Create
        public IActionResult Create()
        {
            ViewData["LocationId"] = new SelectList(_context.Location, "LocationId", "LocationEmail");
            ViewData["ManagerId"] = new SelectList(_context.IncidentManager, "ManagerId", "ManagerEmail");
            ViewData["SeverityId"] = new SelectList(_context.IncidentSeverity, "SeverityId", "SeverityDescription");
            ViewData["TeamId"] = new SelectList(_context.IncidentTeam, "TeamId", "TeamEmail");
            return View();
        }

        // POST: Incident/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IncidentId,IncidentTitle,IncidentDescription,IncidentStart,IncidentEnd,IncidentResolved,ExternalTicket,ExternalTicketUrl,SeverityId,LocationId,LocationUrl,ManagerId,TeamId")] Incident incident)
        {
            if (ModelState.IsValid)
            {
                _context.Add(incident);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["LocationId"] = new SelectList(_context.Location, "LocationId", "LocationEmail", incident.LocationId);
            ViewData["ManagerId"] = new SelectList(_context.IncidentManager, "ManagerId", "ManagerEmail", incident.ManagerId);
            ViewData["SeverityId"] = new SelectList(_context.IncidentSeverity, "SeverityId", "SeverityDescription", incident.SeverityId);
            ViewData["TeamId"] = new SelectList(_context.IncidentTeam, "TeamId", "TeamEmail", incident.TeamId);
            return View(incident);
        }

        // GET: Incident/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var incident = await _context.Incident.FindAsync(id);
            if (incident == null)
            {
                return NotFound();
            }
            ViewData["LocationId"] = new SelectList(_context.Location, "LocationId", "LocationName", incident.LocationId);
            ViewData["ManagerId"] = new SelectList(_context.IncidentManager, "ManagerId", "ManagerName", incident.ManagerId);
            ViewData["SeverityId"] = new SelectList(_context.IncidentSeverity, "SeverityId", "SeverityName", incident.SeverityId);
            ViewData["TeamId"] = new SelectList(_context.IncidentTeam, "TeamId", "TeamName", incident.TeamId);
            return View(incident);
        }

        // POST: Incident/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IncidentId,IncidentTitle,IncidentDescription,IncidentResolved,ExternalTicket,ExternalTicketUrl,SeverityId,LocationId,LocationUrl,ManagerId,TeamId")] Incident incident)
        {
            if (id != incident.IncidentId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(incident);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!IncidentExists(incident.IncidentId))
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
            ViewData["LocationId"] = new SelectList(_context.Location, "LocationId", "LocationName", incident.LocationId);
            ViewData["ManagerId"] = new SelectList(_context.IncidentManager, "ManagerId", "ManagerName", incident.ManagerId);
            ViewData["SeverityId"] = new SelectList(_context.IncidentSeverity, "SeverityId", "SeverityName", incident.SeverityId);
            ViewData["TeamId"] = new SelectList(_context.IncidentTeam, "TeamId", "TeamName", incident.TeamId);
            return View(incident);
        }

        // GET: Incident/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var incident = await _context.Incident
                .Include(i => i.Location)
                .Include(i => i.Manager)
                .Include(i => i.Severity)
                .Include(i => i.Team)
                .FirstOrDefaultAsync(m => m.IncidentId == id);
            if (incident == null)
            {
                return NotFound();
            }

            return View(incident);
        }

        // POST: Incident/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var incident = await _context.Incident.FindAsync(id);
            _context.Incident.Remove(incident);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool IncidentExists(int id)
        {
            return _context.Incident.Any(e => e.IncidentId == id);
        }
    }
}
