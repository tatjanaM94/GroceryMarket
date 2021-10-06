using Domain.GroceryMarket.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.GroceryMarket.Models
{
    public class Fruit : AuditableBaseEntity
    {
        public string Name { get; set; }
        public string CountryOfOrigin { get; set; }
        public int InStock { get; set; }
        public ICollection<FruitBayer>FruitBayers { get; set; }
    }
}
