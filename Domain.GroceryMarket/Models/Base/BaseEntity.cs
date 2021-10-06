using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.GroceryMarket.Models.Base
{
    public abstract class BaseEntity

    {
        public virtual Guid Id { get; set; }
    }
}
