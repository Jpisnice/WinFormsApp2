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
using System.IO;
using System.Data.SqlClient;
using WinFormsApp2;

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

        private void button4_Click(object sender, EventArgs e)
        {
            //displays warning message with continue and cancel buttons
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit?\nAll Entries in cart will be lost", "Exit", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //closes this form,delete all the data from cart_table and open login.cs
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\Chitraksh.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM cart_table", con);
                cmd.ExecuteNonQuery();
                Login login = new Login();
                login.Show();
                this.Hide();
            }
            else if (dialogResult == DialogResult.No)
            {
                //exit dialog 

            }

        }
    }
}
