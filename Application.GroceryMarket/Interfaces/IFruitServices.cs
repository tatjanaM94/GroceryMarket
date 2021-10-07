using Domain.GroceryMarket.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.GroceryMarket.Interfaces
{
    public interface IFruitServices
    {
        IEnumerable<Fruit> GetFruits();
        Fruit GetFruitById(Guid id);

        void InsertFruit(Fruit fruit);

        // edit ffruit

        void EditFruit(Fruit fruit);

        // delete car
        void Delete(Guid id);
    }
}
