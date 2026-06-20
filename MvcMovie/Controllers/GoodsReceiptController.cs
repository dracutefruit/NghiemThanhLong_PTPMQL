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
    public class GoodsReceiptController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GoodsReceiptController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: GoodsReceipt
        public async Task<IActionResult> Index()
        {
            return View(await _context.GoodsReceipts.Include(o => o.Supplier).ToListAsync());
        }

        // GET: GoodsReceipt/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var goodsReceipt = await _context.GoodsReceipts
                .Include(o => o.Supplier)
                .Include(o => o.GoodsReceiptDetails)
                    .ThenInclude(o => o.Device)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (goodsReceipt == null)
            {
                return NotFound();
            }

            return View(goodsReceipt);
        }

        // GET: GoodsReceipt/Create
        public async Task<IActionResult> Create()
        {
            ViewBag.SupplierId = new SelectList(_context.Suppliers, "Id", "SupplierName");
            ViewBag.Devices = _context.Devices.ToList();
            return View();
        }

        // POST: GoodsReceipt/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(GoodsReceipt goodsReceipt)
        {
            if (ModelState.IsValid)
            {
                goodsReceipt.ReceiptDate = DateTime.Now;

                foreach (var item in goodsReceipt.GoodsReceiptDetails)
                {
                    var hehe = await _context.Devices.FindAsync(item.DeviceId);
                    item.Price = hehe.Price;
                }

                _context.Add(goodsReceipt);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewBag.Suppliers = new SelectList(_context.Suppliers, "Id", "SupplierName", goodsReceipt.SupplierId);
            ViewBag.Devices = _context.Devices.ToList();
            return View(goodsReceipt);
        }

        // GET: GoodsReceipt/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var goodsReceipt = await _context.GoodsReceipts.FindAsync(id);
            if (goodsReceipt == null)
            {
                return NotFound();
            }
            return View(goodsReceipt);
        }

        // POST: GoodsReceipt/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ReceiptCode,ReceiptDate")] GoodsReceipt goodsReceipt)
        {
            if (id != goodsReceipt.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(goodsReceipt);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GoodsReceiptExists(goodsReceipt.Id))
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
            return View(goodsReceipt);
        }

        // GET: GoodsReceipt/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var goodsReceipt = await _context.GoodsReceipts
                .FirstOrDefaultAsync(m => m.Id == id);
            if (goodsReceipt == null)
            {
                return NotFound();
            }

            return View(goodsReceipt);
        }

        // POST: GoodsReceipt/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var goodsReceipt = await _context.GoodsReceipts.FindAsync(id);
            if (goodsReceipt != null)
            {
                _context.GoodsReceipts.Remove(goodsReceipt);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GoodsReceiptExists(int id)
        {
            return _context.GoodsReceipts.Any(e => e.Id == id);
        }
    }
}
