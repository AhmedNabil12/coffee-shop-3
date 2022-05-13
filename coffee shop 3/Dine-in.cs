using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coffee_shop_3
{
    class Dine_in:Cheque
    {
        private double service=0.12;
        
        public Dine_in()
        {

        }
        public Dine_in(DateTime Date, double tax, Cart orderCart,double total):base(Date,tax,orderCart,total)
        {
           
        }

        public override double calculate_cheque()
        {

            total= orderCart.getPrice()+ (orderCart.getPrice()* tax) + (orderCart.getPrice() * service);
            return total;
        }
        public double Service 
        { 
            get 
            { 
                return service;
            
            } 
        }

    }
}
