using Domain.GroceryMarket.Interfaces;
using Domain.GroceryMarket.Models;
using Infrastructure.Data.GroceryMarket.Context;
using Infrastructure.Data.GroceryMarket.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Data.GroceryMarket.Repositories
{
    public class FruitRepository:BaseRepository<Fruit>,IFruitRepository
    {
        public FruitRepository(LibraryDbContext dbContext):base(dbContext)
        {

        }
    }
}
