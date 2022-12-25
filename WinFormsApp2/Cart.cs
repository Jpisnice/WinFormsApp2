using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace Chitraksh
{
    public partial class Cart : Form
    {
        public Cart()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //when clicked close this form and open Home.cs
            Home home = new Home();
            home.Show();
            this.Hide();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //on click modifies the quantity on Item having Product ID mentioned in textbox with value mentioned in numericupdown
            //and then updates the total price
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\Chitraksh.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            //updates total_price in cart_table by multiplying quantity with price
           
            SqlCommand cmd = new SqlCommand("UPDATE cart_table SET Quantity = @Quantity WHERE Product_ID = @Product_ID", con);
            cmd.Parameters.AddWithValue("@Quantity", numericUpDown1.Value);
            cmd.Parameters.AddWithValue("@Product_ID", textBox1.Text);
            cmd.ExecuteNonQuery();
            SqlCommand cmd2 = new SqlCommand("UPDATE cart_table SET total_price = quantity * price WHERE product_id = '" + textBox1.Text + "'", con);
            cmd2.ExecuteNonQuery();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //displays cart_table
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\Chitraksh.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM cart_table", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //delets value mentioned in numericupdown from item having product id mentioned in textbox from cart_table and updates total price
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\Chitraksh.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM cart_table WHERE Product_ID = @Product_ID", con);
            cmd.Parameters.AddWithValue("@Product_ID", textBox1.Text);
            cmd.ExecuteNonQuery();
            SqlCommand cmd2 = new SqlCommand("UPDATE cart_table SET total_price = quantity * price WHERE product_id = '" + textBox1.Text + "'", con);
            cmd2.ExecuteNonQuery();
            
        }
    }
}
