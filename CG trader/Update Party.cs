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
    public partial class Update_Party : UserControl
    {
        string party_id;
        private static Update_Party _instance;
        

        public static Update_Party instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Update_Party();
                return _instance;
            }
        }

        public Update_Party()
        {
            InitializeComponent();
        }

        private void metroPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            Party_Update();
            LoadPartys();
        }
        private void Party_Update()
        {
            var conn = new MySqlConnection();
            conn.ConnectionString = @"Server =localhost; Database =cg_trader; Uid =root; Pwd =";
            conn.Open();

            MySqlCommand command1 = new MySqlCommand();
            command1.Connection = conn;
            command1.CommandText = "UPDATE party_entrys SET party_name ='" + txtpartyname.Text + "', party_address='" + txtaddress.Text + "', telephone='" + txttelephone.Text + "', user_id="+ txtuserid.Text+ "WHERE party_id=" + party_id;
            command1.CommandType = CommandType.Text;
            command1.ExecuteNonQuery();


            MySqlDataAdapter adapter1 = new MySqlDataAdapter(command1);
            DataTable ad8 = new DataTable();
            adapter1.Fill(ad8);




            MessageBox.Show("Update successfully");
        }
        private void LoadPartys()
        {
            var conn = new MySqlConnection();
            conn.ConnectionString = @"server =localhost; database=cg_trader; Uid=root; Pwd=";
            conn.Open();

            MySqlCommand bank_id = new MySqlCommand();
            bank_id.Connection = conn;
            bank_id.CommandText = "select * from party_entrys";
            bank_id.CommandType = CommandType.Text;

            MySqlDataAdapter adapter = new MySqlDataAdapter(bank_id);
            DataTable dt2 = new DataTable();
            adapter.Fill(dt2);

            cmb2.DataSource = dt2;
            cmb2.DisplayMember = "party_name";
            cmb2.ValueMember = "party_id";
        }

        private void cmb2_SelectedIndexChanged(object sender, EventArgs e)
        {
            party_id = cmb2.SelectedValue.ToString();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            DeleteParty();
        }
        private void DeleteParty()
        {
            var conn = new MySqlConnection();
            conn.ConnectionString = @"Server =localhost; Database =cg_trader; Uid =root; Pwd =";
            conn.Open();

            MessageBox.Show(cmb2.SelectedValue.ToString());

            String SQLDelete = "Delete from party_entrys where party_id = " + cmb2.SelectedValue;


            MySqlCommand bank_id2 = new MySqlCommand();
            bank_id2.Connection = conn;
            bank_id2.CommandText = SQLDelete;
            bank_id2.CommandType = CommandType.Text;
            bank_id2.ExecuteNonQuery();



            MessageBox.Show("Delete sucessful");
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Update_Party_Load(object sender, EventArgs e)
        {
            LoadPartys();
        }

    }
}
