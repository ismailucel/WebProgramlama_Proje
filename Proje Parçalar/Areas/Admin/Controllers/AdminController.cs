using G201210352.Data;
using G201210352.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace G201210352.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class AdminController:Controller
    {
        private readonly ApplicationDbContext _context;

        public AdminController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> OrderList()
        {
            List<Basket> basket = await _context.Basket
                .Where(b => b.Active == false && b.Status == "Cargo")
                .Include(b => b.ApplicationUser)
                .ToListAsync();

            return View(basket);
        }

        public async Task<IActionResult> BasketDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            List<BasketItem> basketItems = await _context.BasketItem
                .Where(b => b.BasketId == id)
                .Include(b => b.Song)
                .Include(b => b.Song.Category)
                .Include(b => b.Song.Artist)
                .ToListAsync();

            return View(basketItems);
        }

        public async Task<IActionResult> ChangeSituation(int id)
        {
            Basket basket = _context.Basket.Where(x => x.Id == id).FirstOrDefault();

            if (basket != null)
            {
                basket.Status = "Completed";
                _context.Update(basket);
                await _context.SaveChangesAsync();
            }
            else
            {
                return NotFound();
            }

            return RedirectToAction(nameof(OrderList));
        }
    }
}
