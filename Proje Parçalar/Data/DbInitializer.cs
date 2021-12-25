using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using G201210352.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace G201210352.Data
{
    public class DbInitializer : IDbInitializer
    {

        private readonly ApplicationDbContext _db;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public DbInitializer(ApplicationDbContext db, 
            UserManager<IdentityUser> userManager, 
            RoleManager<IdentityRole> roleManager)
        {
            _db = db;
            _userManager = userManager;
            _roleManager = roleManager;
        }


        public async void Initialize()
        {
            try
            {
                if(_db.Database.GetPendingMigrations().Count()>0)
                {
                    _db.Database.Migrate();
                }
            }
            catch(Exception ex)
            {

            }

            if (_db.Roles.Any(r => r.Name == "Admin")) return;

            _roleManager.CreateAsync(new IdentityRole("Admin")).GetAwaiter().GetResult();
            _roleManager.CreateAsync(new IdentityRole("Customer")).GetAwaiter().GetResult();

            _userManager.CreateAsync(new ApplicationUser
            {
                UserName = "g201210352@sakarya.edu.tr",
                Email = "g201210352@sakarya.edu.tr",
                Name = "İsmail",
                LastName="Üçel",
                EmailConfirmed = true,
                PhoneNumber = "1112223333"
            }, "Admin123*").GetAwaiter().GetResult();


            _userManager.AddToRoleAsync(_db.Users.FirstOrDefaultAsync(u => u.Email == "g201210352@sakarya.edu.tr").GetAwaiter().GetResult(), "Admin").GetAwaiter().GetResult();

        }
    }
}
