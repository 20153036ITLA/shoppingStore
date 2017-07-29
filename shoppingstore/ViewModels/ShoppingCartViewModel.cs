using shoppingstore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace shoppingstore.ViewModels
{
    public class ShoppingCartViewModel
    {
        
        public List<Cart> CartItems { get; set; }

        [Key]
        public decimal CartTotal { get; set; }


    }
}