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
    public partial class UserControl4 : UserControl
    {
        private static UserControl4 _instance;

        public static UserControl4 instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControl4();
                return _instance;
            }
        }
        public UserControl4()
        {
            InitializeComponent();
        }


        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            //connect with database
            var conn = new MySqlConnection();
            conn.ConnectionString = @"server =localhost; database=cg_trader; Uid=root; Pwd=";
            conn.Open();
            if (conn.State == ConnectionState.Open)
            {
                MessageBox.Show("Connected Successful");

            }
            //insert into from database table
            string INSERT = "insert into cheque_entrys(bank_id, party_id, cheque_No, entry_date, date_of_cash, amount) values(" + CDO.SelectedValue + "," + CMB.SelectedValue + ",'" + txtchequeno.Text  + "','" + txtentrydate.Text + "','" + txtdateofcash.Text  + "','"+txtamount.Text+"')";
            MySqlCommand command = new MySqlCommand();
            command.Connection = conn;
            command.CommandText = INSERT;
            command.CommandType = CommandType.Text;
            command.ExecuteNonQuery();
        }

        private void cheque_id()
        {
            var conn = new MySqlConnection();
            conn.ConnectionString = @"server =localhost; database=cg_trader; Uid=root; Pwd=";
            conn.Open();

            MySqlCommand cheque_id = new MySqlCommand();
            cheque_id.Connection = conn;
            cheque_id.CommandText = "select * from party_entrys";
            cheque_id.CommandType = CommandType.Text;

            MySqlDataAdapter adapter = new MySqlDataAdapter(cheque_id);
            DataTable dt = new DataTable();
            adapter.Fill(dt);


            CMB.DataSource = dt;
            CMB.DisplayMember = "party_name";
            CMB.ValueMember = "party_id";

        }

        private void UserControl4_Load(object sender, EventArgs e)
        {
            cheque_id();
            bank_id();
            View_Party();
        }

        private void CMB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void bank_id()
        {
            //connection to database
            var conn = new MySqlConnection();
            conn.ConnectionString = @"server =localhost; database=cg_trader; Uid=root; Pwd=";
            conn.Open();

            MySqlCommand bank_id = new MySqlCommand();
            bank_id.Connection = conn;
            bank_id.CommandText = "select * from bank_entrys";
            bank_id.CommandType = CommandType.Text;

            MySqlDataAdapter adapter = new MySqlDataAdapter(bank_id);
            DataTable dt1 = new DataTable();
            adapter.Fill(dt1);

            CDO.DataSource = dt1;
            CDO.DisplayMember = "bank_name";
            CDO.ValueMember = "bank_id";

        }

        private void CDO_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {

        }
        private void View_Party()
        {
            //connection to database
            var conn = new MySqlConnection();
            conn.ConnectionString = @"server =localhost; database=cg_trader; Uid=root; Pwd=";
            conn.Open();

            MySqlCommand User_Id = new MySqlCommand();
            User_Id.Connection = conn;
            User_Id.CommandText = "select * from user_id";
            User_Id.CommandType = CommandType.Text;

            MySqlDataAdapter adapter = new MySqlDataAdapter(User_Id);
            DataTable dt2 = new DataTable();
            adapter.Fill(dt2);

            CMB1.DataSource = dt2;
            CMB1.DisplayMember = "user_id";
            CMB1.ValueMember = "user_id";
        }

        private void CMB1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void metroPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void Cashed()
        {

        }        
    }
}
