using G201210352.Data;
using G201210352.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Localization;
//using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace G201210352.Controllers
{

    public class HomeController : Controller
    {

        private readonly ApplicationDbContext _context;
        private readonly IStringLocalizer<HomeController> _localizer;



        public HomeController(ApplicationDbContext context/*, UserManager<ApplicationUser> userManager*/, IStringLocalizer<HomeController> localizer)
        {
            _context = context;
            _localizer = localizer;
        }

        public async Task<IActionResult> Index()
        {
            List<Song> _songs = await _context.Song.OrderByDescending(x => x.CreateDate).Take(10).ToListAsync();
            return View(_songs);
        }

        public async Task<IActionResult> SongDetails(int searchId)
        {
            List<Song> sarkilar = await _context.Song.OrderBy(u => Guid.NewGuid()).Where(u => u.Id != searchId).Take(4).ToListAsync();

            Song _song = _context.Song.Where(x => x.Id == searchId).FirstOrDefault();
            sarkilar.Add(_song);
            if (_song == null)
                return RedirectToAction("ErrorPage", "Home", new { statusCode = 901 });
            else
                return View(sarkilar);
        }

        public async Task<IActionResult> SearchSongs(string searchItem)
        {
            List<Song> kitaplar = await _context.Song.Where(x => x.SongName.ToLower().Contains(searchItem.ToLower())).ToListAsync();
            return View(kitaplar);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> AddSongToBasket(int songId)
        {
            var basket = await _context.Basket
                .Where(x => x.CustomerId == User.FindFirstValue(ClaimTypes.NameIdentifier) && x.Active == true)
                .FirstOrDefaultAsync();

            Song currentSong = await _context.Song
                .Where(x => x.Id == songId && x.Active == true)
                .FirstOrDefaultAsync();

            if (currentSong == null) return NotFound();

            if (basket != null)
            {
                BasketItem newBasketItem = new BasketItem
                {
                    BasketId = basket.Id,
                    Song = currentSong,
                    Active = true
                };

                _context.Add(newBasketItem);
                await _context.SaveChangesAsync();
            }
            else
            {
                Basket newBasket = new Basket
                {
                    Status = "YENI",
                    Active = true,
                    CustomerId = User.FindFirstValue(ClaimTypes.NameIdentifier)
                };

                _context.Add(newBasket);
                _context.SaveChanges();

                BasketItem newBasketItem = new BasketItem
                {
                    BasketId = newBasket.Id,
                    Song = currentSong,
                    Active = true
                };

                _context.Add(newBasketItem);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction("Index", "Baskets", new { area = "Customer" });
        }

        public async Task<IActionResult> MyOrder()
        {
            List<Basket> baskets = await _context.Basket
                .Where(x => x.CustomerId == User.FindFirstValue(ClaimTypes.NameIdentifier) && x.Active == false)
                .ToListAsync();

            return View(baskets);
        }

        [Authorize]
        public async Task<IActionResult> CancelOrder(int? orderId)
        {
            if (orderId == null)
            {
                return NotFound();
            }

            Basket basket = await _context.Basket
                .Where(x => x.Id == orderId)
                .FirstOrDefaultAsync();

            if (basket == null)
            {
                //TempData["HataMesaj"] = _localizer["ErrorMessage3"];
            }
            else
            {
                basket.Status = "Cancelled";
                basket.Active = false;
                _context.Update(basket);
                await _context.SaveChangesAsync();
            }

            List<Basket> basketList = await _context.Basket
                .Where(x => x.CustomerId == User.FindFirstValue(ClaimTypes.NameIdentifier) && x.Active == false)
                .ToListAsync();

            return View("MyOrder", basketList);
        }

        [Authorize]
        public async Task<IActionResult> OrderDetails(int? orderId)
        {
            if (orderId == null)
            {
                return NotFound();
            }

            List<BasketItem> basketItems = await _context.BasketItem
                .Where(b => b.BasketId == orderId && b.Active == true)
                .Include(b => b.Song)
                .Include(b => b.Song.Category)
                .Include(b => b.Song.Artist)
                .ToListAsync();

            return View(basketItems);
        }

    }
}
