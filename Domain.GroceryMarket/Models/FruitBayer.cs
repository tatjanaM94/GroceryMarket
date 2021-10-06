using Domain.GroceryMarket.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.GroceryMarket.Models
{
    public class FruitBayer : AuditableBaseEntity
    {
        public Guid FruitId { get; set; }
        public Fruit Fruit{ get; set; }
        public Guid BuyerId { get; set; }
        public Buyer Buyer { get; set; }
    }
}
