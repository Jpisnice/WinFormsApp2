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
    public partial class BrowsePage : Form
    {
        public BrowsePage()
        {
            InitializeComponent();
        }

        private void BrowsePage_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //when clicked inserts entry having ProductID mentioned in the textbox and makes simialar entry in cart_table
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\Chitraksh.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into cart_table values('" + textBox1.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Added to cart");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //when clicked close this form and open Home.cs
            Home home = new Home();
            home.Show();
            this.Hide();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Insert entry having ProductID mentioned in the textbox and copy Item_name,Amount value in cart_table
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\Chitraksh.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into cart_table select Item_name,Amount from stock_table where Prod_ID='" + textBox2.Text + "'", con);
            //update Quantity in cart table as 1
            SqlCommand cmd2 = new SqlCommand("update cart_table set Quantity=1", con);
            SqlCommand cmd1 = new SqlCommand("update stock_table set Quantity=Quantity-1 where Prod_ID='" + textBox2.Text + "'", con);
            cmd.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            cmd1.ExecuteNonQuery();
            con.Close();
        }
    }
}
