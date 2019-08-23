using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bangazon.Models.ProductViewModels
{
    public class ProductCountViewModel
    {
        public int ProductCount { get; set; }
        public string UserId { get; set; }
        public string Summary
        {
            get { return $"You have {ProductCount} products"; }
        }
    }
}
