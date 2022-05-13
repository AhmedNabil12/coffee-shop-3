using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coffee_shop_3
{
    abstract class Cheque
    {
        DateTime Date;
        protected double tax = 0.14;
        protected  Cart orderCart;
        protected double total; 

        public Cheque() { }
        public Cheque(DateTime Date,double tax,Cart orderCart,double total)
        {
            this.Date = Date;
            this.tax = tax;
            this.orderCart = orderCart;
            this.total = total;
        }
        public Cart OrderCart
        {
            get { return orderCart; }
        }
        public double Tax
        {
            get { return tax; }
        }
        public abstract double calculate_cheque();
    }
}
