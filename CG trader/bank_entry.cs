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
    public partial class Home : Form
    {
        bool a;
        bool b;
        string cg_trader;
        int c;
        private void check()
        {



        }
        public Home()
        {
            InitializeComponent();
            metroPanel5.Width = 0;
            metroPanel5.Height = 0;
            metroPanel6.Width = 0;
            metroPanel6.Height = 0;
            timer1.Start();
            a = true;
            b = true;
        }

        private void bank_entry_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Form1 = new Login();
            Form1.FormClosed += (s, args) => this.Close();
            Form1.Show();
        }

        private void aDDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Form2 = new Form2();
            Form2.FormClosed += (s, args) => this.Close();
            Form2.Show();
        }

        private void aDDToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Form3 = new Form3();
            Form3.FormClosed += (s, args) => this.Close();
            Form3.Show();
        }

        private void cHEQUEToolStripMenuItem1_Click(object sender, EventArgs e)
        {     }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Form1 = new Login();
            Form1.FormClosed += (s, args) => this.Close();
            Form1.Show();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {

            //Open New Panel          
           
            if(a)
            {
                metroPanel5.Width = 100;
                metroPanel5.Height = 324;
                a = false;
            }
            else
            {
                metroPanel5.Width = 0;
                metroPanel5.Height = 0;
                a = true;
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            metroPanel4.Controls.Clear();
            metroPanel4.Controls.Add(UserControl1.instance);
            UserControl1.instance.Dock = DockStyle.Fill;
            UserControl1.instance.BringToFront();
        }

        private void metroPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            metroPanel4.Controls.Clear();
            metroPanel4.Controls.Add(Paryentry.instance);
            Paryentry.instance.Dock = DockStyle.Fill;
            Paryentry.instance.BringToFront();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Text = DateTime.Now.DayOfWeek.ToString();
            DateTime datetime = DateTime.Now;
            this.Text = DateTime.Now.ToString("dd-MM-yyy hh:mm:ss tt");
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            metroPanel4.Controls.Clear();
            metroPanel4.Controls.Add(UserControl3.instance);
            UserControl3.instance.Dock = DockStyle.Fill;
            UserControl3.instance.BringToFront();
        }

        private void metroButton7_Click(object sender, EventArgs e)
        {
            metroPanel4.Controls.Clear();
            metroPanel4.Controls.Add(UserControl4.instance);
            UserControl4.instance.Dock = DockStyle.Fill;
            UserControl4.instance.BringToFront();
        }

        private void metroButton8_Click(object sender, EventArgs e)
        {
            metroPanel4.Controls.Clear();
            metroPanel4.Controls.Add(UserControl5.instance);
            UserControl5.instance.Dock = DockStyle.Fill;
            UserControl5.instance.BringToFront();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            //open Update panel
            if (b)
            {
                metroPanel6.Width = 100;
                metroPanel6.Height = 300;
                b = false;
            }
            else
            {
                metroPanel6.Width = 0;
                metroPanel6.Height = 0;
                b = true;
            }
        }

        private void metroPanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            View_Report();


        }
        private void View_Report()
        {
                this.Hide();
                var FirmReport = new FirmReport();
                FirmReport.FormClosed +=(s,args) => this.Close();
                FirmReport.Show();
        }

        private void metroButton9_Click(object sender, EventArgs e)
        {
            upadte_delete_party();
        }
        private void upadte_delete_party()
        {
            metroPanel4.Controls.Clear();
            metroPanel4.Controls.Add(Update_Party.instance);
            Update_Party.instance.Dock = DockStyle.Fill;
            Update_Party.instance.BringToFront();
        }

        private void metroButton10_Click(object sender, EventArgs e)
        {
            Update_Delete_Bank();
        }
        private void Update_Delete_Bank()
        {
            metroPanel4.Controls.Clear();
            metroPanel4.Controls.Add(Update_Bank.instance);
            Update_Bank.instance.Dock = DockStyle.Fill;
            Update_Bank.instance.BringToFront();
        }

        private void metroButton11_Click(object sender, EventArgs e)
        {

            Update_Delete_Cheque();
        }
       private void Update_Delete_Cheque()
        {
            metroPanel4.Controls.Clear();
            metroPanel4.Controls.Add(Update_Cheque.instance);
            Update_Cheque.instance.Dock = DockStyle.Fill;
            Update_Cheque.instance.BringToFront();
        }

        private void metroButton13_Click(object sender, EventArgs e)
        {
            
            search();
        }
        private void search()
        {
            cg_trader = "SELECT cheque_entrys.entry_date,"
                    + "cheque_entrys.cheque_no,"
                    + "bank_entrys.bank_name,"
                    + "cheque_entrys.Amount,"
                    + "cheque_entrys.date_of_cash,"
                    + "cheque_entrys.ifcashed,"
                    + "FROM cheque_entrys"
                    + "INNER JOIN party_entrys ON"
                    + "cheque_entrys.party_name = party_entrys.party_id"
                    + "INNER JOIN bank_etrys ON"
                    + "cheque_entrys.bank_id = bank_entrys.bank_id"
                    + "WHERE bank_name = '" + metroButton13.Text + "';";

            check();

            if (c == 0)
            {
                cg_trader = "SELECT cheque_entrys.entry_date,"
                    + "cheque_entrys.cheque_no,"
                    + "bank_entrys.bank_name,"
                    + "cheque_entrys.Amount,"
                    + "cheque_entrys.date_of_cash,"
                    + "cheque_entrys.ifcashed,"
                    + "FROM cheque_entrys"
                    + "INNER JOIN party_entrys ON"
                    + "cheque_entrys.party_name = party_entrys.party_id"
                    + "INNER JOIN bank_etrys ON"
                    + "cheque_entrys.bank_id = bank_entrys.bank_id"
                    + "WHERE bank_name = '" + metroButton13.Text + "';";
                check();

                if (c == 0)
                {
                    cg_trader = "SELECT cheque_entrys.entry_date,"
                       + "cheque_entrys.cheque_no,"
                       + "bank_entrys.bank_name,"
                       + "cheque_entrys.Amount,"
                       + "cheque_entrys.date_of_cash,"
                       + "cheque_entrys.ifcashed,"
                       + "FROM cheque_entrys"
                       + "INNER JOIN party_entrys ON"
                       + "cheque_entrys.party_name = party_entrys.party_id"
                       + "INNER JOIN bank_etrys ON"
                       + "cheque_entrys.bank_id = bank_entrys.bank_id"
                       + "WHERE bank_name = '" + metroButton13.Text + "';";

                    check();
                    if(c==0)
                    {
                        MessageBox.Show("no records found");
                        //metroButton13.clear();
                        //View_dataGridView5();
                    }

                }
                {

                }

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
