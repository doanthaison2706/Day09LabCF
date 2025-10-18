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
    public class DtsLoaiSanPhamsController : Controller
    {
        private readonly DtsCFContext _context;

        public DtsLoaiSanPhamsController(DtsCFContext context)
        {
            _context = context;
        }

        // GET: DtsLoaiSanPhams
        public async Task<IActionResult> Index()
        {
            return View(await _context.LoaiSanPhams.ToListAsync());
        }

        // GET: DtsLoaiSanPhams/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dtsLoaiSanPham = await _context.LoaiSanPhams
                .FirstOrDefaultAsync(m => m.DTSId == id);
            if (dtsLoaiSanPham == null)
            {
                return NotFound();
            }

            return View(dtsLoaiSanPham);
        }

        // GET: DtsLoaiSanPhams/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DtsLoaiSanPhams/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DTSId,DTSMaLoai,DTSTenLoai,DTSTrangThai")] DtsLoaiSanPham dtsLoaiSanPham)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dtsLoaiSanPham);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dtsLoaiSanPham);
        }

        // GET: DtsLoaiSanPhams/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dtsLoaiSanPham = await _context.LoaiSanPhams.FindAsync(id);
            if (dtsLoaiSanPham == null)
            {
                return NotFound();
            }
            return View(dtsLoaiSanPham);
        }

        // POST: DtsLoaiSanPhams/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DTSId,DTSMaLoai,DTSTenLoai,DTSTrangThai")] DtsLoaiSanPham dtsLoaiSanPham)
        {
            if (id != dtsLoaiSanPham.DTSId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dtsLoaiSanPham);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DtsLoaiSanPhamExists(dtsLoaiSanPham.DTSId))
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
            return View(dtsLoaiSanPham);
        }

        // GET: DtsLoaiSanPhams/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dtsLoaiSanPham = await _context.LoaiSanPhams
                .FirstOrDefaultAsync(m => m.DTSId == id);
            if (dtsLoaiSanPham == null)
            {
                return NotFound();
            }

            return View(dtsLoaiSanPham);
        }

        // POST: DtsLoaiSanPhams/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dtsLoaiSanPham = await _context.LoaiSanPhams.FindAsync(id);
            if (dtsLoaiSanPham != null)
            {
                _context.LoaiSanPhams.Remove(dtsLoaiSanPham);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DtsLoaiSanPhamExists(int id)
        {
            return _context.LoaiSanPhams.Any(e => e.DTSId == id);
        }
    }
}
