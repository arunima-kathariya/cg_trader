using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CG_trader
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "p" && txtpassword.Text == "p")
            {
                this.Hide();
                var Home = new Home();
                Home.FormClosed += (s, args) => this.Close();
                Home.Show();
            }
            else
            {
                MessageBox.Show("Wrong'username'or'password '. ");

            }
        }
            private void login()
            {
               
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
