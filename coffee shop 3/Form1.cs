using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coffee_shop_3
{
    
    public partial class Form1 : Form
    {
        Cart myCart=new Cart();

        List<Item> food = new List<Item>();
        List<Item> colddrinks = new List<Item>();
        List<Item> hotdrinks = new List<Item>();
        public Form1()
        {
            InitializeComponent();
            loadProducts();
            loadcoldDrinks();
            loadHotDrinks();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            if (DineIn_checkBox1.Checked == true)
            {
                Dine_in x = new Dine_in(DateTime.Now, 0.14, myCart, myCart.getPrice());

                Form4 f = new Form4(x);
                f.Show();
                Hide();
            }
            else if(TakeAway_checkBox2.Checked==true)
            {
                Take_away x = new Take_away(DateTime.Now, 0.14, myCart, myCart.getPrice());

                Form4 f = new Form4(x);
                f.Show();
            }
           /* else if (Delivery_checkBox3.Checked == true)
            {
                Delivery x = new Delivery(DateTime.Now, 0.14, myCart, myCart.getPrice());
                Form4 f = new Form4(x);
                f.Show();
            }*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Food_comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void loadProducts() 
        {

            string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\test\coffee shop 3\coffee shop 3\Database1.mdf;Integrated Security=True";
            SqlConnection connection= new SqlConnection(con);
            connection .Open();
            SqlCommand sc=new SqlCommand("select name,price from items",connection);
            SqlDataReader reader = sc.ExecuteReader();
            while(reader.Read())
            {
                Item x = new Item();
                x.Name = reader.GetValue(0).ToString();
                x.Price = double.Parse(reader.GetValue(1).ToString());
                food.Add(x);
            }
            foreach(Item i in food)
            {
                Food_comboBox1.Items.Add(i.Name+" "+i.Price);
            }
        }
        public void loadcoldDrinks()
        {

            string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\test\coffee shop 3\coffee shop 3\Database1.mdf;Integrated Security=True";
            SqlConnection connection = new SqlConnection(con);
            connection.Open();
            SqlCommand sc = new SqlCommand("select name,price from ColdDrinks", connection);
            SqlDataReader reader = sc.ExecuteReader();
            while (reader.Read())
            {
                Item x = new Item();
                x.Name = reader.GetValue(0).ToString();
                x.Price = double.Parse(reader.GetValue(1).ToString());
                colddrinks.Add(x);
            }
            foreach (Item i in colddrinks)
            {
                comboBox2.Items.Add(i.Name + " " + i.Price);
            }
        }
        public void loadHotDrinks()
        {
            //Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = "D:\test\coffee shop 3\coffee shop 3\Database1.mdf"; Integrated Security = True
            string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\test\coffee shop 3\coffee shop 3\Database1.mdf;Integrated Security=True";
            SqlConnection connection = new SqlConnection(con);
            connection.Open();
            SqlCommand sc = new SqlCommand("select Name,Price from HotDrinks", connection);
            SqlDataReader reader = sc.ExecuteReader();
            
            while (reader.Read())
            {
                Item x = new Item();
                x.Name = reader.GetValue(0).ToString();
                x.Price = double.Parse(reader.GetValue(1).ToString());
                hotdrinks.Add(x);
            }
            foreach (Item i in hotdrinks)
            {
                comboBox3.Items.Add(i.Name + " " + i.Price);
            }
        }

        private void buttonFood_Click(object sender, EventArgs e)
        {
            if(Food_comboBox1.SelectedIndex==-1)
            {
                MessageBox.Show("Please select item");
                return;
            }
            if (numericUpDownFood.Value==0)
            {
                MessageBox.Show("Please enter qty");
                return;
            }
            int index = Food_comboBox1.SelectedIndex;
            Item selectedItem = food[index];
            Cart_item c = new Cart_item();
            c.foodItem = selectedItem;
            c.Quantity = int.Parse(numericUpDownFood.Value.ToString());
            myCart.ADD_Item(c);
            updateCart();
        }
        public void updateCart()
        {
            richTextBox1.Clear();
        foreach(Cart_item x in myCart.items)
            {
                richTextBox1.AppendText(x.foodItem.Name + " " + x.foodItem.Price + " " + x.Quantity+"\n");
            }
            label6.Text = myCart.getPrice().ToString();
        }

        private void buttonCold_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Please select item");
                return;
            }
            if (numericUpDownCold.Value == 0)
            {
                MessageBox.Show("Please enter qty");
                return;
            }
            int index = comboBox2.SelectedIndex;
            Item selectedItem = colddrinks[index];
            Cart_item c = new Cart_item();
            c.foodItem = selectedItem;
            c.Quantity = int.Parse(numericUpDownCold.Value.ToString());
            myCart.ADD_Item(c);
            updateCart();
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.ShowDialog();
        }

        private void Delivery_checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (Delivery_checkBox3.Checked == true)
                button3.Enabled = true;
            else
                button3.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }

        private void buttonHot_Click_1(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select Item");
                return;
            }
            if (numericUpDownHot.Value == 0)
            {
                MessageBox.Show("Please enter qty");
                return;
            }

            int index = comboBox3.SelectedIndex;
            Item selectedItem = hotdrinks[index];
            Cart_item c = new Cart_item();
            c.foodItem = selectedItem;
            c.Quantity = int.Parse(numericUpDownHot.Value.ToString());
            myCart.ADD_Item(c);
            updateCart();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
