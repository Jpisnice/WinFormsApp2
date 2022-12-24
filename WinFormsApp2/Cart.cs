using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
