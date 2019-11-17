using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Tims.WebApp.Data;
using Tims.WebApp.Models;

namespace Tims.WebApp.Controllers
{
    [Authorize]
    public class ReceptionTypesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ReceptionTypesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ReceptionTypes
        public async Task<IActionResult> Index()
        {
            return View(await _context.ReceptionTypes.ToListAsync());
        }

        // GET: ReceptionTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var receptionType = await _context.ReceptionTypes
                .FirstOrDefaultAsync(m => m.ReceptionTypeId == id);
            if (receptionType == null)
            {
                return NotFound();
            }

            return View(receptionType);
        }

        // GET: ReceptionTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ReceptionTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ReceptionTypeId,ReceptionTypeName")] ReceptionType receptionType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(receptionType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(receptionType);
        }

        // GET: ReceptionTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var receptionType = await _context.ReceptionTypes.FindAsync(id);
            if (receptionType == null)
            {
                return NotFound();
            }
            return View(receptionType);
        }

        // POST: ReceptionTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ReceptionTypeId,ReceptionTypeName")] ReceptionType receptionType)
        {
            if (id != receptionType.ReceptionTypeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(receptionType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReceptionTypeExists(receptionType.ReceptionTypeId))
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
            return View(receptionType);
        }

        // GET: ReceptionTypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var receptionType = await _context.ReceptionTypes
                .FirstOrDefaultAsync(m => m.ReceptionTypeId == id);
            if (receptionType == null)
            {
                return NotFound();
            }

            return View(receptionType);
        }

        // POST: ReceptionTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var receptionType = await _context.ReceptionTypes.FindAsync(id);
            _context.ReceptionTypes.Remove(receptionType);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReceptionTypeExists(int id)
        {
            return _context.ReceptionTypes.Any(e => e.ReceptionTypeId == id);
        }
    }
}
