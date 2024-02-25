using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Areas.Admin.Data;

namespace WebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TenloaixeController : Controller
    {
        private readonly webdieuhanhContext _context;

        public TenloaixeController(webdieuhanhContext context)
        {
            _context = context;
        }

        // GET: Admin/Tenloaixe
        public async Task<IActionResult> Index()
        {
            return View(await _context.TLoaixes.ToListAsync());
        }

        // GET: Admin/Tenloaixe/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tTenloaixe = await _context.TLoaixes
                .FirstOrDefaultAsync(m => m.LoaixeId == id);
            if (tTenloaixe == null)
            {
                return NotFound();
            }

            return View(tTenloaixe);
        }

        // GET: Admin/Tenloaixe/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Tenloaixe/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LoaixeId,Tenloaixe,Ghichu")] TLoaixe tLoaixe)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tLoaixe);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tLoaixe);
        }

        // GET: Admin/Tenloaixe/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tTenloaixe = await _context.TLoaixes.FindAsync(id);
            if (tTenloaixe == null)
            {
                return NotFound();
            }
            return View(tTenloaixe);
        }

        // POST: Admin/Tenloaixe/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("LoaixeId,Tenloaixe,Ghichu")] TLoaixe tTenloaixe)
        {
            if (id != tTenloaixe.LoaixeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tTenloaixe);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TLoaixeExists(tTenloaixe.LoaixeId))
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
            return View(tTenloaixe);
        }

        // GET: Admin/Tenloaixe/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tTenloaixe = await _context.TLoaixes
                .FirstOrDefaultAsync(m => m.LoaixeId == id);
            if (tTenloaixe == null)
            {
                return NotFound();
            }

            return View(tTenloaixe);
        }

        // POST: Admin/Tenloaixe/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tTenloaixe = await _context.TLoaixes.FindAsync(id);
            _context.TLoaixes.Remove(tTenloaixe);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TLoaixeExists(int id)
        {
            return _context.TLoaixes.Any(e => e.LoaixeId == id);
        }
    }
}
