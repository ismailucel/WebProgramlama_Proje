using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using G201210352.Data;
using G201210352.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Localization;
using System.IO;

namespace G201210352.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class SongsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _hostEnviroment;
        private readonly IStringLocalizer<SongsController> _localizer;

        public SongsController(ApplicationDbContext context, IWebHostEnvironment hostEnvironment, IStringLocalizer<SongsController> localizer)
        {
            _context = context;
            _hostEnviroment = hostEnvironment;
            _localizer = localizer;
        }

        // GET: Admin/Songs
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Song.Include(s => s.Artist).Include(s => s.Category);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Admin/Songs/Details/5
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

        // GET: Admin/Songs/Create
        [HttpGet]
        public IActionResult Create()
        {
            ViewData["ArtistId"] = new SelectList(_context.Artist.Where(a => a.Active == true), "Id", "Name");
            ViewData["CategoryId"] = new SelectList(_context.Category.Where(a => a.Active == true), "Id", "Name");
            return View();
        }

        // POST: Admin/Songs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Song song)
        {
            if (ModelState.IsValid)
            {
                if (song.MainPhotoFile == null || song.SecondPhotoFile == null || song.ThirdPhotoFile == null)
                {
                    ViewData["ArtistId"] = new SelectList(_context.Artist, "Id", "Name", song.ArtistId);
                    ViewData["CategoryId"] = new SelectList(_context.Category, "Id", "Name", song.CategoryId);
                    //ViewData["LanguageId"] = new SelectList(_context.Languages, "Id", "Name", song.LanguageId);
                    ViewData["ErrorMessage"] = _localizer["ErrorMessage1"];
                    return View();
                }

                string[] imgext = new string[3];

                imgext[0] = Path.GetExtension(song.MainPhotoFile.FileName);
                imgext[1] = Path.GetExtension(song.SecondPhotoFile.FileName);
                imgext[2] = Path.GetExtension(song.ThirdPhotoFile.FileName);

                if ((imgext[0] == ".jpg" || imgext[0] == ".png") && (imgext[1] == ".jpg" || imgext[1] == ".png") && (imgext[2] == ".jpg" || imgext[2] == ".png"))
                {
                    for (int i = 0; i < 3; i++)
                    {
                        string path_name = Guid.NewGuid().ToString() + imgext[i];
                        string saveimg = Path.Combine(_hostEnviroment.WebRootPath, "images", path_name);

                        switch (i)
                        {
                            case 0:
                                song.FirstPhoto = path_name;
                                using (var uploadimg = new FileStream(saveimg, FileMode.Create))
                                {
                                    await song.MainPhotoFile.CopyToAsync(uploadimg);
                                }
                                break;
                            case 1:
                                song.SecondPhoto = path_name;
                                using (var uploadimg = new FileStream(saveimg, FileMode.Create))
                                {
                                    await song.SecondPhotoFile.CopyToAsync(uploadimg);
                                }
                                break;
                            case 2:
                                song.ThirdPhoto = path_name;
                                using (var uploadimg = new FileStream(saveimg, FileMode.Create))
                                {
                                    await song.ThirdPhotoFile.CopyToAsync(uploadimg);
                                }
                                break;
                            default:
                                break;
                        }
                    }
                }


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

        // GET: Admin/Songs/Edit/5
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

        // POST: Admin/Songs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Song song)
        {
            if (id != song.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                string[] imgext = new string[3];

                imgext[0] = song.MainPhotoFile == null ? String.Empty : Path.GetExtension(song.MainPhotoFile.FileName);
                imgext[1] = song.SecondPhotoFile == null ? String.Empty : Path.GetExtension(song.SecondPhotoFile.FileName);
                imgext[2] = song.ThirdPhotoFile == null ? String.Empty : Path.GetExtension(song.ThirdPhotoFile.FileName);

                if ((imgext[0] == ".jpg" || imgext[0] == ".png" || imgext[0] == String.Empty) && (imgext[1] == ".jpg" || imgext[1] == ".png" || imgext[1] == String.Empty) && (imgext[2] == ".jpg" || imgext[2] == ".png" || imgext[2] == String.Empty))
                {
                    for (int i = 0; i < 3; i++)
                    {
                        if (imgext[i] != String.Empty)
                        {
                            string path_name = Guid.NewGuid().ToString() + imgext[i];
                            string saveimg = Path.Combine(_hostEnviroment.WebRootPath, "images", path_name);

                            switch (i)
                            {
                                case 0:
                                    song.FirstPhoto = path_name;
                                    using (var uploadimg = new FileStream(saveimg, FileMode.Create))
                                    {
                                        await song.MainPhotoFile.CopyToAsync(uploadimg);
                                    }
                                    break;
                                case 1:
                                    song.SecondPhoto = path_name;
                                    using (var uploadimg = new FileStream(saveimg, FileMode.Create))
                                    {
                                        await song.SecondPhotoFile.CopyToAsync(uploadimg);
                                    }
                                    break;
                                case 2:
                                    song.ThirdPhoto = path_name;
                                    using (var uploadimg = new FileStream(saveimg, FileMode.Create))
                                    {
                                        await song.ThirdPhotoFile.CopyToAsync(uploadimg);
                                    }
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                }
                else
                {
                    ViewData["ArtistId"] = new SelectList(_context.Artist.Where(a => a.Active == true), "Id", "Name", song.ArtistId);
                    ViewData["CategoryId"] = new SelectList(_context.Category.Where(a => a.Active == true), "Id", "Name", song.CategoryId);
                    //ViewData["LanguageId"] = new SelectList(_context.Languages.Where(a => a.Active == true), "Id", "Name", song.LanguageId);
                    ViewData["ErrorMessage"] = _localizer["ErrorMessage2"];
                    return View();
                }

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
            //ViewData["LanguageId"] = new SelectList(_context.Languages, "Id", "Name", book.LanguageId);
            return View(song);
        }

        // GET: Admin/Songs/Delete/5
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

        // POST: Admin/Songs/Delete/5
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
