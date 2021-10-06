using Domain.GroceryMarket.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Data.GroceryMarket.Context
{
    public class LibraryDbContext : DbContext
    {
        public LibraryDbContext(DbContextOptions<LibraryDbContext> options) : base (options)
        {

        }

        public DbSet<Vegetable> Vegetables  { get; set; }
        public DbSet<Fruit> Fruits { get; set; }
        public DbSet<Buyer> Buyers { get; set; }
        public DbSet<FruitBayer> FruitBayers { get; set; }
        public DbSet<VegetableBuyer> VegetableBuyers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FruitBayer>().HasOne(br => br.Buyer)
                .WithMany(br => br.FruitBayers).HasForeignKey(br => br.BuyerId);
            modelBuilder.Entity<FruitBayer>().HasOne(br => br.Fruit)
                .WithMany(br => br.FruitBayers).HasForeignKey(br=>br.FruitId);

        }
    }
}
