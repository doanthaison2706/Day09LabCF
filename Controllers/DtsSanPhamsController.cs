using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ĐTSDay9Lesson.Models;

namespace ĐTSDay9Lesson.Controllers
{
    public class DtsSanPhamsController : Controller
    {
        private readonly DtsCFContext _context;

        public DtsSanPhamsController(DtsCFContext context)
        {
            _context = context;
        }

        // GET: DtsSanPhams
        public async Task<IActionResult> Index()
        {
            return View(await _context.SanPhams.ToListAsync());
        }

        // GET: DtsSanPhams/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dtsSanPham = await _context.SanPhams
                .FirstOrDefaultAsync(m => m.DTSId == id);
            if (dtsSanPham == null)
            {
                return NotFound();
            }

            return View(dtsSanPham);
        }

        // GET: DtsSanPhams/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DtsSanPhams/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DTSId,DTSMaSanPham,DTSTenSanPham,DTSHinhAnh,DTSSoLuong,DTSDonGia,DTSLoaiSanPhamId")] DtsSanPham dtsSanPham)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dtsSanPham);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dtsSanPham);
        }

        // GET: DtsSanPhams/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dtsSanPham = await _context.SanPhams.FindAsync(id);
            if (dtsSanPham == null)
            {
                return NotFound();
            }
            return View(dtsSanPham);
        }

        // POST: DtsSanPhams/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DTSId,DTSMaSanPham,DTSTenSanPham,DTSHinhAnh,DTSSoLuong,DTSDonGia,DTSLoaiSanPhamId")] DtsSanPham dtsSanPham)
        {
            if (id != dtsSanPham.DTSId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dtsSanPham);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DtsSanPhamExists(dtsSanPham.DTSId))
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
            return View(dtsSanPham);
        }

        // GET: DtsSanPhams/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dtsSanPham = await _context.SanPhams
                .FirstOrDefaultAsync(m => m.DTSId == id);
            if (dtsSanPham == null)
            {
                return NotFound();
            }

            return View(dtsSanPham);
        }

        // POST: DtsSanPhams/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dtsSanPham = await _context.SanPhams.FindAsync(id);
            if (dtsSanPham != null)
            {
                _context.SanPhams.Remove(dtsSanPham);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DtsSanPhamExists(int id)
        {
            return _context.SanPhams.Any(e => e.DTSId == id);
        }
    }
}
