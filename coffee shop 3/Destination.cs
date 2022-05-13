using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coffee_shop_3
{
    class Destination
    {
        private string name;
        private int phone;
        private string address;
        private string city;
 
        public Destination()
        {

        }
        public Destination(string name,int phone ,string address, string city)
        {
            this.name = name;
            this.phone = phone;
            this.address = address;
            this.city = city;
    
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Namei
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public int telephone
        {
            get
            {
                return phone;
            }
            set
            {
                phone = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }

        public string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }
    }
}
