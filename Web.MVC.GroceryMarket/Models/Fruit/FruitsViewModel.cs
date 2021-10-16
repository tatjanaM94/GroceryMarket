using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.MVC.GroceryMarket.Models
{
    public class FruitsViewModel
    {
        public string Name { get; set; }

        [Display(Name = "Country of Origin")]
        public string CountryOfOrigin { get; set; }

        [Display(Name = " In Stock")]
        public int InStock { get; set; }
    }
}
