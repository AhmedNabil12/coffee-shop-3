using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coffee_shop_3
{
    class Delivery:Cheque
    {
        private Destination client;
        private double deliveryPrice=15;
        public Delivery() { }
        public Delivery(Destination client ,DateTime Date, double tax, Cart orderCart, double total) 
            : base(Date, tax, orderCart,total)
        {
            this.client = client;
        }
        public double DeliveryPr
        {
            get
            {
                return deliveryPrice;
            }
        }
        public override double calculate_cheque()
        {

            total = orderCart.getPrice() + (orderCart.getPrice() * tax) + deliveryPrice;
            return total;
        }

    }
}
