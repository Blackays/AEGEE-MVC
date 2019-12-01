using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AEGEE_MVC.Data;
using AEGEE_MVC.Models;

namespace AEGEE_MVC.Controllers
{
    public class DescriptionsController : Controller
    {
        private readonly AppDBContent _context;

        public DescriptionsController(AppDBContent context)
        {
            _context = context;
        }

        // GET: Descriptions
        public async Task<IActionResult> Index()
        {
            return View(await _context.Descriptions.ToListAsync());
        }

        // GET: Descriptions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var descriptions = await _context.Descriptions
                .FirstOrDefaultAsync(m => m.DescId == id);
            if (descriptions == null)
            {
                return NotFound();
            }

            return View(descriptions);
        }

        // GET: Descriptions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Descriptions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DescId,Description")] Descriptions descriptions)
        {
            if (ModelState.IsValid)
            {
                _context.Add(descriptions);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(descriptions);
        }

        // GET: Descriptions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var descriptions = await _context.Descriptions.FindAsync(id);
            if (descriptions == null)
            {
                return NotFound();
            }
            return View(descriptions);
        }

        // POST: Descriptions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DescId,Description")] Descriptions descriptions)
        {
            if (id != descriptions.DescId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(descriptions);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DescriptionsExists(descriptions.DescId))
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
            return View(descriptions);
        }

        // GET: Descriptions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var descriptions = await _context.Descriptions
                .FirstOrDefaultAsync(m => m.DescId == id);
            if (descriptions == null)
            {
                return NotFound();
            }

            return View(descriptions);
        }

        // POST: Descriptions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var descriptions = await _context.Descriptions.FindAsync(id);
            _context.Descriptions.Remove(descriptions);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DescriptionsExists(int id)
        {
            return _context.Descriptions.Any(e => e.DescId == id);
        }
    }
}
