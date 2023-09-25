using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CG_trader
{
    public partial class UserControl5 : UserControl
    {
        private static UserControl5 _instance;

        public static UserControl5 instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControl5();
                return _instance;
            }
        }
        public UserControl5()
        {
            InitializeComponent();
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            View_Insert();
        }
        private void View_Insert()
        {

            var conn = new MySqlConnection();
            conn.ConnectionString = @"server =localhost; database=cg_trader; Uid=root; Pwd=";
            conn.Open();
          
            string Insert = "insert into user_id(staff_name,email,username,password,telephone) values('" 
                + txtname.Text + "','" 
                + txtemail.Text + "','" 
                + txtusername.Text + "','" 
                + txtpassword.Text + "','" 
                + txttelephone.Text + "')";
            MySqlCommand command = new MySqlCommand();
            command.Connection = conn;
            command.CommandText = Insert;
            command.CommandType = CommandType.Text;
            command.ExecuteNonQuery();

            MessageBox.Show("data successful");
        }
    }
}
