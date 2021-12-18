using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using G201210352.Data;
using G201210352.Models;

namespace G201210352.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SongController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SongController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/Song
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Song.Include(s => s.Artist).Include(s => s.Category);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Admin/Song/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var song = await _context.Song
                .Include(s => s.Artist)
                .Include(s => s.Category)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (song == null)
            {
                return NotFound();
            }

            return View(song);
        }

        // GET: Admin/Song/Create
        public IActionResult Create()
        {
            ViewData["ArtistId"] = new SelectList(_context.Artist.Where(a => a.Active == true), "Id", "Name");
            ViewData["CategoryId"] = new SelectList(_context.Category.Where(a => a.Active == true), "Id", "Name");
            return View();
        }

        // POST: Admin/Song/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,SongName,Price,Quantity,PublishYear,ReleaseDate,Description,Stock,CategoryId,ArtistId,CreateDate,Active")] Song song)
        {
            if (ModelState.IsValid)
            {
                song.CreateDate = DateTime.Now;
                song.Active = true;
                _context.Add(song);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ArtistId"] = new SelectList(_context.Artist, "Id", "Name", song.ArtistId);
            ViewData["CategoryId"] = new SelectList(_context.Category, "Id", "Name", song.CategoryId);
            return View(song);
        }

        // GET: Admin/Song/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var song = await _context.Song.FindAsync(id);
            if (song == null)
            {
                return NotFound();
            }
            ViewData["ArtistId"] = new SelectList(_context.Artist.Where(a => a.Active == true), "Id", "Name", song.ArtistId);
            ViewData["CategoryId"] = new SelectList(_context.Category.Where(a => a.Active == true), "Id", "Name", song.CategoryId);
            return View(song);
        }

        // POST: Admin/Song/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,SongName,Price,Quantity,PublishYear,ReleaseDate,Description,Stock,CategoryId,ArtistId,CreateDate,Active")] Song song)
        {
            if (id != song.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    
                    _context.Update(song);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SongExists(song.Id))
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
            ViewData["ArtistId"] = new SelectList(_context.Artist, "Id", "Name", song.ArtistId);
            ViewData["CategoryId"] = new SelectList(_context.Category, "Id", "Name", song.CategoryId);
            return View(song);
        }

        // GET: Admin/Song/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var song = await _context.Song
                .Include(s => s.Artist)
                .Include(s => s.Category)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (song == null)
            {
                return NotFound();
            }

            return View(song);
        }

        // POST: Admin/Song/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            Song song = _context.Song.Where(x => x.Id == id).FirstOrDefault();

            if (song != null)
            {
                song.Active = !song.Active;
                _context.Update(song);
                await _context.SaveChangesAsync();
            }
            else
            {
                return NotFound();
            }

            return RedirectToAction(nameof(Index));
        }

        private bool SongExists(int id)
        {
            return _context.Song.Any(e => e.Id == id);
        }
    }
}
