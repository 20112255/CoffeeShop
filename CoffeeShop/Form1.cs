using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Order_Click(object sender, EventArgs e)
        { 

            String customerName = textBox1.Text;
            int coffeeSelected = Convert.ToInt32(numCoffee.Value);
            int donutsSelected = Convert.ToInt32(numDonut.Value);

            orderOBJ o = new orderOBJ(customerName,coffeeSelected,donutsSelected);
        }
    }
}
