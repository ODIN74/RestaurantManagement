using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManagement.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<AdditionalUserInformation> AdditionalUserInformation { get; set; }
        public DbSet<Ingredients> Ingredients { get; set; }

        public DbSet<Dishes> Dishes { get; set; }

        public DbSet<DishesInPreparation> DishesInPreparations { get; set; }

        public DbSet<Tables> Tables { get; set; }

        public DbSet<Price> Price { get; set; }

        public DbSet<Order> Orders { get; set; }
    }
}
