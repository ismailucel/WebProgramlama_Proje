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
using System.Security.Claims;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Localization;

namespace G201210352.Areas.Customer.Controllers
{
    [Area("Customer")]
    [Authorize]
    public class BasketsController : Controller
    {
        private readonly ApplicationDbContext _context;
        //private readonly UserManager<ApplicationUser> _userManager;
        private readonly IStringLocalizer<BasketsController> _localizer;
        public BasketsController(ApplicationDbContext context,/* UserManager<ApplicationUser> userManager, */IStringLocalizer<BasketsController> localizer)
        {
            _context = context;
            //_userManager = userManager;
            _localizer = localizer;
        }

        // GET: Customer/Baskets
        public async Task<IActionResult> Index()
        {
            Basket basket = _context.Basket
                .Where(x => x.CustomerId == User.FindFirstValue(ClaimTypes.NameIdentifier) && x.Active == true)
                .FirstOrDefault();

            if (basket == null)
            {
                Basket newBasket = new Basket
                {
                    Status = "New",
                    Active = true,
                    //ApplicationUser = await _userManager.GetUserAsync(User)
                };

                _context.Add(newBasket);
                _context.SaveChanges();
            }
            else
            {
                List<BasketItem> basketItems = await _context.BasketItem
                        .Include(x => x.Basket)
                        .Where(x => x.Basket.CustomerId == User.FindFirstValue(ClaimTypes.NameIdentifier) && x.Basket.Active == true && x.Active == true)
                        .Include(x => x.Song).ToListAsync();

                if (basketItems.Count != 0)
                {
                    ViewData["ToplamFiyat"] = basketItems.Sum(x => x.Song.Price);
                    ViewData["BasketID"] = basketItems[0].BasketId;
                    return View(basketItems);
                }
            }

            return View();
        }

        [HttpGet]
        public async Task<IActionResult> RemoveFromBasket(int? songId)
        {
            if (songId == null)
            {
                return NotFound();
            }

            Basket basket = _context.Basket
                .Where(x => x.CustomerId == User.FindFirstValue(ClaimTypes.NameIdentifier) && x.Active == true)
                .FirstOrDefault();

            if (basket != null)
            {
                BasketItem basketItem = _context.BasketItem
                    .Where(x => x.BasketId == basket.Id && x.Active == true && x.SongId == songId).FirstOrDefault();

                if (basketItem != null)
                {
                    basketItem.Active = false;
                    _context.Update(basketItem);
                    await _context.SaveChangesAsync();
                }
            }
            else
            {
                return NotFound();
            }

            return RedirectToAction(nameof(Index));
        }


        [HttpPost]
        public async Task<IActionResult> BuySongs(int? basketId)
        {
            Basket basket = await _context.Basket
                .Where(x => x.Id == basketId)
                .FirstOrDefaultAsync();

            if (basket != null)
            {
                List<BasketItem> basketItem = await _context.BasketItem
                    .Include(x => x.Song)
                    .Where(x => x.BasketId == basketId && x.Active == true)
                    .ToListAsync();

                for (int i = 0; i < basketItem.Count; i++)
                {
                    Song _song = basketItem[i].Song;

                    if (_song.Stock == 0)
                    {
                        for (int j = 0; j < i; j++)
                        {
                            Song tmpSong = basketItem[i].Song;
                            tmpSong.Stock++;
                            _context.Update(tmpSong);
                        }

                        TempData["SiparisMesaj"] = _localizer["SiparisMesaj1"]
                            + _song.SongName;
                        return RedirectToAction("Index", "Baskets" ,new { area = "Customer" });
                    }

                    _song.Stock = _song.Stock - 1;
                    _context.Update(_song);
                }

                basket.Active = false;
                basket.Status = "KARGO";
                _context.Update(basket);
                await _context.SaveChangesAsync();
            }

            TempData["SiparisMesaj"] = _localizer.GetString("SiparisMesaj2") + basketId;
            return RedirectToAction("Index", "Baskets", new { area = "Customer" });
        }


    }
}
