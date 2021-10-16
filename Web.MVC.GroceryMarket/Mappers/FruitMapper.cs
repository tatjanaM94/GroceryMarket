using AutoMapper;
using Domain.GroceryMarket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.MVC.GroceryMarket.Models;

namespace Web.MVC.GroceryMarket.Mappers
{
    public class FruitMapper:Profile
    {
        public FruitMapper()
        {
            CreateMap<Fruit, FruitsViewModel>().ReverseMap();
        }
    }
}
