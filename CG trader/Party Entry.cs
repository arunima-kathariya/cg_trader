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
    public partial class Paryentry : UserControl
    {
        private static Paryentry _instance;

        public static Paryentry instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Paryentry();
                return _instance;
            }
        }
        public Paryentry()
        {
            InitializeComponent();
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            //connected on database name
            var conn = new MySqlConnection();
            conn.ConnectionString = @"Server =localhost; Database =cg_trader; Uid=root; Pwd=";
            conn.Open();
            if(conn.State==ConnectionState.Open)
            {
                MessageBox.Show("Connected Successful");
            }
            //insert data from party_entrys table
            string INSERT = "insert into party_entrys(party_id,party_name,party_address,telephone,user_id) values('"
                +txtpartyid+"','" 
                + txtpartyname.Text + "','" 
                + txtpartyaddress.Text + "','" 
                + txttelephone.Text + "','" 
                + txtuserid.Text + "')";
            MySqlCommand command = new MySqlCommand();//exectued 
            command.Connection = conn;
            command.CommandText = INSERT;
            command.CommandType = CommandType.Text;
            command.ExecuteNonQuery();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
           
        }

        private void txtpartyid_Click(object sender, EventArgs e)
        {

        }
      
    }
}
