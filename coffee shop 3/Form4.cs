using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coffee_shop_3
{
     partial class Form4 : Form
    {
        public Form4(Cheque c)
        {
            InitializeComponent();

            richTextBox1.Clear();
            foreach (Cart_item x in c.OrderCart.items)
            {
                richTextBox1.AppendText(x.foodItem.Name + " " + x.foodItem.Price + " " + x.Quantity + "\n");
            }
            label6.Text = c.OrderCart.getPrice().ToString();
            label2.Text = c.Tax * c.OrderCart.getPrice() + "";
            if (c is Dine_in)
            {
                Dine_in d = (Dine_in)c;
                label4.Text = d.Service*c.OrderCart.getPrice()+"";

            }
            else if(c is Delivery)
            {
                Delivery d = (Delivery)c;
                label8.Text = d.DeliveryPr.ToString();
            }
            else if (c is Take_away)
            {
                
            }
            label9.Text = c.calculate_cheque().ToString();

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
