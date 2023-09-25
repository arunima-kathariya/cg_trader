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
    public partial class UserControl3 : UserControl
    {
        private static UserControl3 _instance;

        public static UserControl3 instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControl3();
                return _instance;
            }
        }
        public UserControl3()
        {
            InitializeComponent();
        }

        private void UserControl3_Load(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            //next form login
            this.Hide();
            var Home = new Home();
            Home.FormClosed += (s, args) => 
            Home.Show();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            //database connection
            var conn = new MySqlConnection();
            conn.ConnectionString = @"server =localhost; Database=cg_trader; Uid=root; Pwd=";
            conn.Open();
            if(conn.State ==ConnectionState.Open)
            {
                MessageBox.Show("Connected Successful");
            }
            string INSERT = "insert into bank_entrys(bank_id,bank_name,bank_address) values('" 
                + txtbankid.Text + "','" 
                + txtname.Text + "','" 
                + txtaddress.Text + "')";
            MySqlCommand command = new MySqlCommand();
            command.Connection = conn;
            command.CommandText = INSERT;
            command.CommandType = CommandType.Text;
            command.ExecuteNonQuery();

        }
    }
}
