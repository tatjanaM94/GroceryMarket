using Domain.GroceryMarket.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.GroceryMarket.Models
{
    public class Buyer : AuditableBaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public ICollection<VegetableBuyer> VegetableBuyers { get; set; }
        public ICollection<FruitBayer> FruitBayers { get; set; }
    }
}
