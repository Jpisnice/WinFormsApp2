using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chitraksh
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //on click should open BrowsePage.cs and close this form
            BrowsePage browsePage = new BrowsePage();
            browsePage.Show();
            this.Hide();

        }

        private void Home_Load(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //on click close this form and open Cart.cs form
            Cart cart = new Cart();
            cart.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //on click open Checkout.cs and clodde this form
            Checkout checkout = new Checkout();
            checkout.Show();
            this.Hide();
            
        }
    }
}
