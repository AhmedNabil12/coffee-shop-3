using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace coffee_shop_3
{
  class Cart_item
    {
        private Item item;
        private int quantity;
        
        public Cart_item()
        {

        }
        public Cart_item(Item item,  int quantity)
        {
            this.item = item;
            this.quantity = quantity;
        }
        public Item foodItem
        {
            set
            {
                item = value;
            }
            get
            {
                return item;
            }
        }

        public int Quantity
        {
            set
            {
                quantity = value;
            }
            get
            {
                return quantity;
            }
        }
    }
}
