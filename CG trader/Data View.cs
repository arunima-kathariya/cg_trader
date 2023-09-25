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
    public partial class UserControl1 : UserControl
    {
        private static UserControl1 _instance;

        public static UserControl1 instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControl1();
                return _instance;
            }
        }
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            //calling
            view_party();
            view_bank();
            view_cheque();
            View_Id();

        }
        private void view_party()
        {
            // for view data of party entrys table
            var connect= new MySqlConnection();
            connect.ConnectionString="server=localhost; database=cg_trader; uid=root; pwd=";
            connect.Open();

           

            MySqlCommand view = new MySqlCommand();
            view.Connection = connect;
            view.CommandText = "select * from party_entrys";
            view.CommandType = CommandType.Text;

            MySqlDataAdapter ad = new MySqlDataAdapter(view);
            DataTable dt = new DataTable();
            ad.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void view_bank()
        {
            // view data for bank entry table
            var connect = new MySqlConnection();
            connect.ConnectionString = "server=localhost; database=cg_trader; uid=root; pwd=";
            connect.Open();


            //selected table 
            MySqlCommand view = new MySqlCommand();
            view.Connection = connect;
            view.CommandText = "select * from bank_entrys";
            view.CommandType = CommandType.Text;

            
            MySqlDataAdapter ad = new MySqlDataAdapter(view);
            DataTable dt1 = new DataTable();
            ad.Fill(dt1);

            dataGridView2.DataSource = dt1;

        }
        private void view_cheque()
        {
            //view for cheque entrys table
            var connect = new MySqlConnection();
            connect.ConnectionString = "server=localhost; database=cg_trader; uid=root; pwd=";
            connect.Open();

            // inner join
            string join = "select cheque_entrys.entry_date, " +
                "cheque_entrys.cheque_No, " + 
                "bank_entrys.bank_name, " + 
                "party_entrys.party_name, " + 
                "cheque_entrys.date_of_cash, " + 
                "cheque_entrys.Amount, " + 
                "cheque_entrys.ifcashed " +
                "from cheque_entrys " + 
                "inner join bank_entrys " + 
                "on cheque_entrys.bank_id = bank_entrys.bank_id " + 
                "inner join party_entrys " + 
                "on cheque_entrys.party_id = party_entrys.party_id;";

            MySqlCommand view3 = new MySqlCommand();
            view3.Connection = connect;
            view3.CommandText = join;
            view3.CommandType = CommandType.Text;
            view3.ExecuteNonQuery();

            MySqlDataAdapter ad5 = new MySqlDataAdapter(view3);
            DataTable dt5 = new DataTable();
            ad5.Fill(dt5);

            dataGridView3.DataSource = dt5;

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void View_Id()
        {
            //view data for user id table
            var connect = new MySqlConnection();
            connect.ConnectionString = "server=localhost; database=cg_trader; uid=root; pwd=";
            connect.Open();



            MySqlCommand view4 = new MySqlCommand();
            view4.Connection = connect;
            view4.CommandText = "select * from user_id";
            view4.CommandType = CommandType.Text;
            view4.ExecuteNonQuery();

            MySqlDataAdapter ad6 = new MySqlDataAdapter(view4);
            DataTable dt4 = new DataTable();
            ad6.Fill(dt4);

            dataGridView4.DataSource = dt4;
        }

        private void dataGridView3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var connect = new MySqlConnection();
            connect.ConnectionString = "server=localhost; database=cg_trader; uid=root; pwd=";
            connect.Open();

            if (dataGridView3.CurrentRow.Cells[6].Value.ToString() == "uncashed")
            {
                MySqlCommand status = new MySqlCommand();
                status.Connection = connect;
                status.CommandText = "UPDATE cheque_entrys SET ifcashed ='cashed' where cheque_No =" + dataGridView3.CurrentRow.Cells[1].Value.ToString();
                status.CommandType = CommandType.Text;
                status.ExecuteNonQuery();

                MessageBox.Show("This cheque has been updated to cashed");

                view_cheque();
            }
            else
            {
                MySqlCommand status = new MySqlCommand();
                status.Connection = connect;
                status.CommandText = "UPDATE cheque_entrys SET ifcashed ='uncashed' where cheque_No =" + dataGridView3.CurrentRow.Cells[1].Value.ToString();
                status.CommandType = CommandType.Text;
                status.ExecuteNonQuery();

                MessageBox.Show("This cheque has been updated to uncashed");

                view_cheque();
            }
        }
        
    }
}
