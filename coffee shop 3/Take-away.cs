using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coffee_shop_3
{
    class Take_away:Cheque
    {
        
        public Take_away() { }
        public Take_away(DateTime Date, double tax, Cart orderCart, double total) : base(Date, tax, orderCart,total)
        {

        }
        public override double calculate_cheque()
        { 
            total = orderCart.getPrice() + (orderCart.getPrice() * tax);
            return total;
        }
    }
}
