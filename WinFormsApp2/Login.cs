using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chitraksh;

namespace WinFormsApp2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Check username and password if coorect,if fields are empty or if incorrect details show message
            if (textBox1.Text == "chitraksh" && textBox2.Text == "123")
            {
                MessageBox.Show("Login Successful");
                Home home = new Home();
                home.Show();
                this.Hide();
            }
            else if(textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                MessageBox.Show("Welcome Admin");
                Admin admin = new Admin();
                admin.Show();
                this.Hide();
            }
            else if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please enter username and password");
            }
            else
            {
                MessageBox.Show("Incorrect username or password");
            }


        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}