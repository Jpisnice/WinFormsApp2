using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp2;
using System.Data.SqlClient;

namespace Chitraksh
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            //
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //when clicked should open Login.cs and close this form
            Login login = new Login();
            login.Show();
            this.Hide();


        }

        private void Add2Inven_Click(object sender, EventArgs e)
        {
            //Enters Textbox1 as Item_name,Numericupdown as Quantity and Textbox2 as Price into the database trough sql query using mssql
            //check if fields are empty or not
            if (textBox1.Text == "" || numericUpDown1.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Please enter all the details");
            }
            else
            {
                Random ran = new Random(); 
                int randomno = ran.Next(11111,99999);
                //connection string
                string conString = "Data Source=DESKTOP-2QJQJ9N;Initial Catalog=Chitraksh;Integrated Security=True";
                //sql query
                string query = "INSERT INTO Inventory(Item_name,Quantity,Price,Prod_ID) VALUES('" + textBox1.Text + "','" + numericUpDown1.Text + "','" + textBox3.Text + "'," + randomno + ")";
                //connection
                SqlConnection con = new SqlConnection(conString);
                //command
                SqlCommand cmd = new SqlCommand(query, con);
                //open connection
                con.Open();
                //execute query
                cmd.ExecuteNonQuery();
                //close connection
                con.Close();
                MessageBox.Show("Item added to inventory");

                //clear fields
                textBox1.Text = "";
                numericUpDown1.Text = "";
                textBox3.Text = "";
                
            }
        }
    }
}
        
