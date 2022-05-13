using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coffee_shop_3
{
    public  class Item
    {
         private string name;
         private double price;

        public Item() { }
        public Item(string name, double price)
        {
            this.name = name;
            this.price = price;
        }
        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        } 
        public double Price
        {
            set
            {
                price = value;
            }
            get
            {
                return price;
            }
        }
       
        
    }
}
