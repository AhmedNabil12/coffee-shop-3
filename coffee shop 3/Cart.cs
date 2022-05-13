using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coffee_shop_3
{
    class Cart
    {

        public List<Cart_item> items = new List<Cart_item >();
       

        public Cart() { }
        
        public void ADD_Item(Cart_item X)
        {
            items.Add(X);
        }
        public double getPrice()
        {
            double sum = 0;
            foreach( Cart_item x in items)
            {
                sum += x.Quantity * x.foodItem.Price;
               
            }
            return sum;
        }
        
    }
}
