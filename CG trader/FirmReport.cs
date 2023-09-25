using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CG_trader
{
    public partial class FirmReport : Form
    {
        public FirmReport()
        {
            InitializeComponent();
        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void metroPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void total_amount()
        {
            var conn = new MySqlConnection();
            conn.ConnectionString = @"server =localhost; database=cg_trader; Uid=root; Pwd=";
            conn.Open();
            if (conn.State == ConnectionState.Open)
            {
                MessageBox.Show("View Amount Now");
            }
            string INSERT = "select sum(Amount) FROM cheque_entrys";
            MySqlCommand command = new MySqlCommand();
            command.Connection = conn;
            command.CommandText = INSERT;
            command.CommandType = CommandType.Text;
            command.ExecuteNonQuery();

            MySqlDataAdapter ad6 = new MySqlDataAdapter(command);
            DataTable dt4 = new DataTable();
            ad6.Fill(dt4);

            txtamount.Text = dt4.Rows[0]["sum(Amount)"].ToString();

        }

        private void txtamount_Click(object sender, EventArgs e)
        {
           
        }

        private void metroPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FirmReport_Load(object sender, EventArgs e)
        {
            total_amount();
        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cancel();
        }
        private void Cancel()
        {
            this.Hide();
            var bank_entry = new Home();
            bank_entry.FormClosed += (s, args) => this.Close();
            bank_entry.Show();
        }

        
    }
}
