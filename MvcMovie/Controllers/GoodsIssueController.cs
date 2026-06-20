using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Data;
using NuGet.Protocol;

namespace MvcMovie.Controllers
{
    public class GoodsIssueController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GoodsIssueController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: GoodsIssue
        public async Task<IActionResult> Index()
        {
            return View(await _context.GoodsIssues.Include(o => o.Supplier).ToListAsync());
        }

        // GET: GoodsIssue/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var goodsIssue = await _context.GoodsIssues
                .Include(o => o.Supplier)
                .Include(o => o.GoodsIssueDetails)
                    .ThenInclude(o => o.Device)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (goodsIssue == null)
            {
                return NotFound();
            }

            return View(goodsIssue);
        }

        // GET: GoodsIssue/Create
        public async Task<IActionResult> Create()
        {
            ViewBag.SupplierId = new SelectList(_context.Suppliers, "Id", "SupplierName");
            ViewBag.Devices = _context.Devices.ToList();
            return View();
        }

        // POST: GoodsIssue/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(GoodsIssue goodsIssue)
        {
            if (ModelState.IsValid)
            {
                goodsIssue.IssueDate = DateTime.Now;

                foreach (var item in goodsIssue.GoodsIssueDetails)
                {
                    var hehe = await _context.Devices.FindAsync(item.DeviceId);
                    item.Price = hehe.Price;
                }

                _context.Add(goodsIssue);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewBag.Suppliers = new SelectList(_context.Suppliers, "Id", "SupplierName", goodsIssue.SupplierId);
            ViewBag.Devices = _context.Devices.ToList();
            return View(goodsIssue);
        }

        // GET: GoodsIssue/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var goodsIssue = await _context.GoodsIssues.FindAsync(id);
            if (goodsIssue == null)
            {
                return NotFound();
            }
            return View(goodsIssue);
        }

        // POST: GoodsIssue/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IssueCode,IssueDate")] GoodsIssue goodsIssue)
        {
            if (id != goodsIssue.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(goodsIssue);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GoodsIssueExists(goodsIssue.Id))
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
            return View(goodsIssue);
        }

        // GET: GoodsIssue/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var goodsIssue = await _context.GoodsIssues
                .FirstOrDefaultAsync(m => m.Id == id);
            if (goodsIssue == null)
            {
                return NotFound();
            }

            return View(goodsIssue);
        }

        // POST: GoodsIssue/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var goodsIssue = await _context.GoodsIssues.FindAsync(id);
            if (goodsIssue != null)
            {
                _context.GoodsIssues.Remove(goodsIssue);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GoodsIssueExists(int id)
        {
            return _context.GoodsIssues.Any(e => e.Id == id);
        }
    }
}
