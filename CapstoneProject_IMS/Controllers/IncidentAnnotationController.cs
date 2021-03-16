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
    public class IncidentAnnotationController : Controller
    {
        private readonly StatusBoardContext _context;

        public IncidentAnnotationController(StatusBoardContext context)
        {
            _context = context;
        }

        // GET: IncidentAnnotation
        public async Task<IActionResult> Index()
        {
            var statusBoardContext = _context.IncidentAnnotation.Include(i => i.Incident);
            return View(await statusBoardContext.ToListAsync());
        }

        // GET: IncidentAnnotation/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var incidentAnnotation = await _context.IncidentAnnotation
                .Include(i => i.Incident)
                .FirstOrDefaultAsync(m => m.AnnotationId == id);
            if (incidentAnnotation == null)
            {
                return NotFound();
            }

            return View(incidentAnnotation);
        }

        // GET: IncidentAnnotation/Create
        public IActionResult Create()
        {
            ViewData["IncidentId"] = new SelectList(_context.Incident, "IncidentId", "ExternalTicket");
            return View();
        }

        // POST: IncidentAnnotation/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AnnotationId,CreatedOn,AnnotationContent,AnnotationVisible,IncidentId")] IncidentAnnotation incidentAnnotation)
        {
            if (ModelState.IsValid)
            {
                _context.Add(incidentAnnotation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IncidentId"] = new SelectList(_context.Incident, "IncidentId", "ExternalTicket", incidentAnnotation.IncidentId);
            return View(incidentAnnotation);
        }

        // GET: IncidentAnnotation/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var incidentAnnotation = await _context.IncidentAnnotation.FindAsync(id);
            if (incidentAnnotation == null)
            {
                return NotFound();
            }
            ViewData["IncidentId"] = new SelectList(_context.Incident, "IncidentId", "ExternalTicket", incidentAnnotation.IncidentId);
            return View(incidentAnnotation);
        }

        // POST: IncidentAnnotation/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AnnotationId,CreatedOn,AnnotationContent,AnnotationVisible,IncidentId")] IncidentAnnotation incidentAnnotation)
        {
            if (id != incidentAnnotation.AnnotationId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(incidentAnnotation);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!IncidentAnnotationExists(incidentAnnotation.AnnotationId))
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
            ViewData["IncidentId"] = new SelectList(_context.Incident, "IncidentId", "ExternalTicket", incidentAnnotation.IncidentId);
            return View(incidentAnnotation);
        }

        // GET: IncidentAnnotation/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var incidentAnnotation = await _context.IncidentAnnotation
                .Include(i => i.Incident)
                .FirstOrDefaultAsync(m => m.AnnotationId == id);
            if (incidentAnnotation == null)
            {
                return NotFound();
            }

            return View(incidentAnnotation);
        }

        // POST: IncidentAnnotation/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var incidentAnnotation = await _context.IncidentAnnotation.FindAsync(id);
            _context.IncidentAnnotation.Remove(incidentAnnotation);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool IncidentAnnotationExists(int id)
        {
            return _context.IncidentAnnotation.Any(e => e.AnnotationId == id);
        }
    }
}
