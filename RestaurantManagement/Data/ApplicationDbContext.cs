using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;

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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IngredientsWeights>().HasOne(d => d.Ingredient).WithMany();
            modelBuilder.Entity<IngredientsWeights>().HasOne(d => d.Dish).WithMany();
            modelBuilder.Entity<Order>().HasMany<Dishes>(o => o.Dishes).WithOne();
            modelBuilder.Entity<Order>().HasOne(o => o.Waiter).WithMany();
            modelBuilder.Entity<Order>().HasOne(o => o.Table).WithMany();
            modelBuilder.Entity<Price>().HasOne(d => d.Dish).WithMany();
            modelBuilder.Entity<DishesInPreparation>().HasOne(d => d.Dish).WithMany();
            modelBuilder.Entity<AdditionalUserInformation>().HasOne(c => c.User);
            modelBuilder.Entity<DishesInPreparation>().HasOne(c => c.Cook).WithMany();
            modelBuilder.Entity<IdentityUserLogin<string>>().HasKey(l => l.UserId);
            modelBuilder.Entity<IdentityUserRole<string>>().HasKey(r => r.RoleId);
            modelBuilder.Entity<IdentityUserToken<string>>().HasKey(t => t.UserId);
            modelBuilder.Entity<DishesInCatуgories>().HasOne(d => d.Dish);
            modelBuilder.Entity<DishesInCatуgories>().HasOne(c => c.Category);
        }
    }
}
