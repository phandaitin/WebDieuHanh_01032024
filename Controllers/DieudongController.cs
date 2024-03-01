using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Areas.Admin.Data;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class DieudongController : Controller
    {
        private readonly webdieuhanhContext _context;

        public DieudongController(webdieuhanhContext context)
        {
            _context = context;
        }

        // GET: Dieudong
        public async Task<IActionResult> Index(int pageTeoti , string _NgayTh_Tu = "01/01/1990", string _NgayTh_Den = "01/01/1990", string _Trangthaiduyet ="-1")
        {
            var items =   _context.TDieudongs.OrderByDescending(x => x.DieudongId) ;            
            if (_Trangthaiduyet != "-1" )
            {
               items = items.Where( x => x.NgayTh >= DateTime.Parse(_NgayTh_Tu) && x.NgayTh <= DateTime.Parse(_NgayTh_Den) && x.Trangthaiduyet == _Trangthaiduyet).OrderByDescending(x=>x.DieudongId) ;           
            }         
            //==================PAGINAION======================================            
            const int pageSize = 10;
            if (pageTeoti < 1)
                pageTeoti = 1;
            int totalItems = await items.CountAsync();
            var pager = new PagerVM(totalItems, pageTeoti, pageSize);
            var data = await items.Skip((pageTeoti - 1) * pageSize).Take(pageSize).ToListAsync();
            ViewBag.Pager = pager;
            ViewBag.Index = (pageTeoti - 1) * pageSize;
            return View(data);
        }


        public async Task<IActionResult> GetAll(int pageTeoti, string _Trangthaiduyet = "-1")
        {
            ViewBag.Trangthaiduyet = "Đã duyệt";

        var items = _context.TDieudongs.OrderByDescending(x => x.DieudongId);
            if (_Trangthaiduyet != "-1" )
            {
                items = items.Where(x => x.Trangthaiduyet == _Trangthaiduyet).OrderByDescending(x => x.DieudongId);
            }
            //==================PAGINAION======================================            
            const int pageSize = 10;
            if (pageTeoti < 1)
                pageTeoti = 1;
            int totalItems = await items.CountAsync();
            var pager = new PagerVM(totalItems, pageTeoti, pageSize);
            var data = await items.Skip((pageTeoti - 1) * pageSize).Take(pageSize).ToListAsync();
            ViewBag.Pager = pager;
            ViewBag.Index = (pageTeoti - 1) * pageSize;
            return View(data);
        }



        // GET: Dieudong/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tDieudong = await _context.TDieudongs
                .FirstOrDefaultAsync(m => m.DieudongId == id);
            if (tDieudong == null)
            {
                return NotFound();
            }

            return View(tDieudong);
        }

        // GET: Dieudong/Create
        public IActionResult Create1()
        {
            return View();
        }

        // POST: Dieudong/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create1([Bind("DieudongId,MaDv,TenDv,NgayDk,NgayTh,Tenloaixe,Tenloaicongtrinh,Noidung,NgayDuyet,Soxe,Hoten,Trangthaiduyet,Ghichu")] TDieudong tDieudong)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tDieudong);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tDieudong);
        }

        // GET: Dieudong/Edit/5
        public async Task<IActionResult> Edit1(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tDieudong = await _context.TDieudongs.FindAsync(id);
            if (tDieudong == null)
            {
                return NotFound();
            }
            return View(tDieudong);
        }

        // POST: Dieudong/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit1(int id, [Bind("DieudongId,MaDv,TenDv,NgayDk,NgayTh,Tenloaixe,Tenloaicongtrinh,Noidung,NgayDuyet,Soxe,Hoten,Trangthaiduyet,Ghichu")] TDieudong tDieudong)
        {
            if (id != tDieudong.DieudongId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tDieudong);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TDieudongExists(tDieudong.DieudongId))
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
            return View(tDieudong);
        }

        // GET: Dieudong/Delete/5
        public async Task<IActionResult> Delete1(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tDieudong = await _context.TDieudongs
                .FirstOrDefaultAsync(m => m.DieudongId == id);
            if (tDieudong == null)
            {
                return NotFound();
            }

            return View(tDieudong);
        }

        // POST: Dieudong/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed1(int id)
        {
            var tDieudong = await _context.TDieudongs.FindAsync(id);
            _context.TDieudongs.Remove(tDieudong);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TDieudongExists(int id)
        {
            return _context.TDieudongs.Any(e => e.DieudongId == id);
        }
    }
}
