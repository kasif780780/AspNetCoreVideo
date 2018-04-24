using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookCart.Models
{
    public class CartLine
    {
        public Book Book { get; set; }
        public int Quantity { get; set; }
    }
}
