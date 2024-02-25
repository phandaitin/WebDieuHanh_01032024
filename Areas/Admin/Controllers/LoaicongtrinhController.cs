using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApp.Areas.Admin.Data;

namespace WebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TenloaicongtrinhController : Controller
    {
        private readonly webdieuhanhContext _context;

        public TenloaicongtrinhController(webdieuhanhContext context)
        {
            _context = context;
        }

        // GET: Admin/Tenloaicongtrinh
        public async Task<IActionResult> Index()
        {
            return View(await _context.TLoaicongtrinhs.ToListAsync());
        }

        // GET: Admin/Tenloaicongtrinh/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tTenloaicongtrinh = await _context.TLoaicongtrinhs
                .FirstOrDefaultAsync(m => m.LoaicongtrinhId == id);
            if (tTenloaicongtrinh == null)
            {
                return NotFound();
            }

            return View(tTenloaicongtrinh);
        }

        // GET: Admin/Tenloaicongtrinh/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Tenloaicongtrinh/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LoaicongtrinhId,Tenloaicongtrinh,Ghichu")] TLoaicongtrinh tLoaicongtrinh)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tLoaicongtrinh);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tLoaicongtrinh);
        }

        // GET: Admin/Tenloaicongtrinh/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tTenloaicongtrinh = await _context.TLoaicongtrinhs.FindAsync(id);
            if (tTenloaicongtrinh == null)
            {
                return NotFound();
            }
            return View(tTenloaicongtrinh);
        }

        // POST: Admin/Tenloaicongtrinh/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("LoaicongtrinhId,Tenloaicongtrinh,Ghichu")] TLoaicongtrinh tLoaicongtrinh)
        {
            if (id != tLoaicongtrinh.LoaicongtrinhId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tLoaicongtrinh);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TLoaicongtrinhExists(tLoaicongtrinh.LoaicongtrinhId))
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
            return View(tLoaicongtrinh);
        }

        // GET: Admin/Tenloaicongtrinh/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tTenloaicongtrinh = await _context.TLoaicongtrinhs
                .FirstOrDefaultAsync(m => m.LoaicongtrinhId == id);
            if (tTenloaicongtrinh == null)
            {
                return NotFound();
            }

            return View(tTenloaicongtrinh);
        }

        // POST: Admin/Tenloaicongtrinh/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tTenloaicongtrinh = await _context.TLoaicongtrinhs.FindAsync(id);
            _context.TLoaicongtrinhs.Remove(tTenloaicongtrinh);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TLoaicongtrinhExists(int id)
        {
            return _context.TLoaicongtrinhs.Any(e => e.LoaicongtrinhId == id);
        }
    }
}
