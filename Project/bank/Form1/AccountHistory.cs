using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class AccountHistory : Form
    {
        public AccountHistory()
        {
            InitializeComponent();
        }
        OleDbConnection Con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= D:\Bank Management System\Database\AccounttDB.accdb");
        string acc = " lbnano.Text";
        private void populate()
        {

            Con.Open();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM TransactionTB1", Con);

            da.Fill(dt);
            dataGridView1.DataSource = dt;
            Con.Close();


        }

        private void transferhistory()
        {

            Con.Open();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM TransferAmtHistory", Con);

            da.Fill(dt);
            dataGridView2.DataSource = dt;
            Con.Close();


        }

        private void AccountHistory_Load(object sender, EventArgs e)
        {


            populate();
            transferhistory();
        }

        private void lbnano_Click(object sender, EventArgs e)
        {

        }

        private void lbnAcc_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            MDIForm mf = new MDIForm();
            mf.Show();
        }
    }
}
