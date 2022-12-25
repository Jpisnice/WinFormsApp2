using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Chitraksh
{
    public partial class Checkout : Form
    {
        public Checkout()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //on click should open Home.cs and close this form
            Home home = new Home();
            home.Show();
            this.Hide();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //display summation of quantity column from cart_table
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\chitr\source\repos\WinFormsApp2\WinFormsApp2\Chitraksh.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT SUM(Quantity) FROM cart_table", con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox1.Text = dr[0].ToString();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //display summation of total_price column from cart_table
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\chitr\source\repos\WinFormsApp2\WinFormsApp2\Chitraksh.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT SUM(Total_Price) FROM cart_table", con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox2.Text = dr[0].ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //onclick opens browser and redirects to amazon.in
            System.Diagnostics.Process.Start("https://www.amazon.in/");
            

        }
    }
}
