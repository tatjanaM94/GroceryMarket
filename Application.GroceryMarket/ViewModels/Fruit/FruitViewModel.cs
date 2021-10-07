using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Application.GroceryMarket.ViewModels.Fruit
{
    public class FruitViewModel
    {
        public string Name { get; set; }

        [Display(Name ="Country of Origin")]
        public string CountryOfOrigin { get; set; }

        [Display(Name = " In Stock")]
        public int InStock { get; set; }
        
    }
}
