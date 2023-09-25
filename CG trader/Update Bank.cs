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
    public partial class Update_Bank : UserControl
    {
        string bank_id;

        private static  Update_Bank _instance;

        public static Update_Bank instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Update_Bank();
                return _instance;
            }
        }
        public Update_Bank()
        {
            InitializeComponent();
        }

        private void Update_Bank_Load(object sender, EventArgs e)
        {
            loadBanks();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {

            Bank_Update();
        }
        private void Bank_Update()
        {
            var conn = new MySqlConnection();
            conn.ConnectionString = @"Server =localhost; Database =cg_trader; Uid =root; Pwd =";
            conn.Open();
           
            MySqlCommand command = new MySqlCommand();
            command.Connection = conn;
            command.CommandText = "UPDATE bank_entrys SET bank_name = '" + txtbankname.Text + "',bank_address =' " + txtbankaddress.Text + "' WHERE bank_id = " + bank_id;
            command.CommandType = CommandType.Text;
            command.ExecuteNonQuery();


            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable ad7 = new DataTable();
            adapter.Fill(ad7);


           

            MessageBox.Show("Update successfully");
        }

        private void loadBanks()
        {
          

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

            cmbBanks.DataSource = dt1;
            cmbBanks.DisplayMember = "bank_name";
            cmbBanks.ValueMember = "bank_id";

            
        }

        private void cmbBanks_SelectedIndexChanged(object sender, EventArgs e)
        {
            bank_id = cmbBanks.SelectedValue.ToString();
          
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            DeleteBank();
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void DeleteBank()
        {
            var conn = new MySqlConnection();
            conn.ConnectionString = @"Server =localhost; Database =cg_trader; Uid =root; Pwd =";
            conn.Open();

            MessageBox.Show(cmbBanks.SelectedValue.ToString());

            String SQLDelete = "Delete from bank_entrys where bank_id = " + cmbBanks.SelectedValue;
            

            MySqlCommand bank_id = new MySqlCommand();
            bank_id.Connection = conn;
            bank_id.CommandText = SQLDelete;
            bank_id.CommandType = CommandType.Text;
            bank_id.ExecuteNonQuery();

           

            MessageBox.Show("Delete sucessful");
        }
       
    }
}
