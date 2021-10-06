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
    }
}
