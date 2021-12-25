using G201210352.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace G201210352.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        
        public DbSet<Discount> Discount { get; set; }

        public DbSet<Category> Category { get; set; }

        public DbSet<Basket> Basket { get; set; }

        public DbSet<BasketItem> BasketItem { get; set; }



        public DbSet<Song> Song { get; set; }

        public DbSet<Artist> Artist { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
