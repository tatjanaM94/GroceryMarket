using Domain.GroceryMarket.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.GroceryMarket.Models
{
    public class VegetableBuyer : AuditableBaseEntity
    {
        public Guid VegetableId { get; set; }
        public Vegetable Vegetable { get; set; }
        public Guid BuyerId { get; set; }
        public Buyer Buyer { get; set; }

    }
}
