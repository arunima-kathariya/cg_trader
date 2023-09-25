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
    public partial class Update_Cheque : UserControl
    {
        string cheque_No;
        private static Update_Cheque _instance;

        public static Update_Cheque instance
        {
            get
            {
                 if (_instance == null)
                    _instance = new Update_Cheque();
                return _instance;
            }
        }
        public Update_Cheque()
        {
            InitializeComponent();
        }

        private void Update_Cheque_Load(object sender, EventArgs e)
        {
            LoadCheque();
            LoadBank();
            LoadParty();
        }
        private void Cheque_Update()
        {
            var conn = new MySqlConnection();
            conn.ConnectionString = @"Server =localhost; Database =cg_trader; Uid =root; Pwd =";
            conn.Open();

            MySqlCommand command = new MySqlCommand();
            command.Connection = conn;
            command.CommandText = "UPDATE cheque_entrys SET cheque_No = '" + txtchequeno.Text + 
                "', entry_date ='" + txtentrydate.Text + 
                "', date_of_cash='" + txtdateofcasah.Text + 
                "', Amount='"+txtamount.Text +
                "' WHERE cheque_id="+ cheque_No;
            command.CommandType = CommandType.Text;
            command.ExecuteNonQuery();

            MySqlDataAdapter adapter2 = new MySqlDataAdapter(command);
            DataTable ad8 = new DataTable();
            adapter2.Fill(ad8);

            MessageBox.Show("Update successfully");
        }
        private void LoadCheque()
        {
            var conn = new MySqlConnection();
            conn.ConnectionString = @"server =localhost; database=cg_trader; Uid=root; Pwd=";
            conn.Open();

            MySqlCommand Cheque_id = new MySqlCommand();
            Cheque_id.Connection = conn;
            Cheque_id.CommandText = "select cheque_id, cheque_No from cheque_entrys";
            Cheque_id.CommandType = CommandType.Text;
            Cheque_id.ExecuteNonQuery();

            MySqlDataAdapter adapte = new MySqlDataAdapter(Cheque_id);
            DataTable dt50 = new DataTable();
            adapte.Fill(dt50);

            CMB3.DataSource = dt50;
            CMB3.DisplayMember = "cheque_No";
            CMB3.ValueMember = "cheque_id";

            txtchequeno.Text = dt50.Rows[0]["cheque_No"].ToString();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Cheque_Update();
        }

        private void CMB3_SelectedIndexChanged(object sender, EventArgs e)
        {
            cheque_No = CMB3.SelectedValue.ToString();
            if (cheque_No != "System.Data.DataRowView")
                displayData();
            
        }

        private void displayData()
        {
            var conn = new MySqlConnection();
            conn.ConnectionString = @"server =localhost; database=cg_trader; Uid=root; Pwd=";
            conn.Open();

            MySqlCommand Cheque_i = new MySqlCommand();
            Cheque_i.Connection = conn;
            Cheque_i.CommandText = "select * from cheque_entrys WHERE cheque_id =" + cheque_No ;
            Cheque_i.CommandType = CommandType.Text;
            Cheque_i.ExecuteNonQuery();

            MySqlDataAdapter adapter = new MySqlDataAdapter(Cheque_i);
            DataTable dt5 = new DataTable();
            adapter.Fill(dt5);

            txtchequeno.Text = dt5.Rows[0]["cheque_No"].ToString();
        }
       

        private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        } 
        private void LoadBank()
        {
            var conn = new MySqlConnection();
            conn.ConnectionString = @"server =localhost; database=cg_trader; Uid=root; Pwd=";
            conn.Open();

            MySqlCommand Cheque_id = new MySqlCommand();
            Cheque_id.Connection = conn;
            Cheque_id.CommandText = "select * from bank_entrys";
            Cheque_id.CommandType = CommandType.Text;
            Cheque_id.ExecuteNonQuery();

            MySqlDataAdapter adapter = new MySqlDataAdapter(Cheque_id);
            DataTable dt5 = new DataTable();
            adapter.Fill(dt5);

            CMB4.DataSource = dt5;
            CMB4.DisplayMember = "bank_No";
            CMB4.ValueMember = "bank_id";
        }

        private void CMB5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void LoadParty()
        {
            var conn = new MySqlConnection();
            conn.ConnectionString = @"server =localhost; database=cg_trader; Uid=root; Pwd=";
            conn.Open();

            MySqlCommand Cheque_id1 = new MySqlCommand();
            Cheque_id1.Connection = conn;
            Cheque_id1.CommandText = "select * from party_entrys";
            Cheque_id1.CommandType = CommandType.Text;
            Cheque_id1.ExecuteNonQuery();

            MySqlDataAdapter adapter = new MySqlDataAdapter(Cheque_id1);
            DataTable dt6 = new DataTable();
            adapter.Fill(dt6);

            CMB5.DataSource = dt6;
            CMB5.DisplayMember = "party_name";
            CMB5.ValueMember = "party_id";
        }

        private void metroComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
    

    
    }
}
