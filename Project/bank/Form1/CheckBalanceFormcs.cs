using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class CheckBalanceFormcs : Form
    {
        public CheckBalanceFormcs()
        {
            InitializeComponent();
        }

        OleDbConnection Con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= D:\Bank Management System\Database\AccounttDB.accdb");

        private void getbalance()
        {
            Con.Open();
            /* OleDbDataAdapter da = new OleDbDataAdapter("Select ACBal from CreateAccountTB where ACNum='"+lbnbal.Text+"' ",Con);
             DataTable dt = new DataTable();
             da.Fill(dt);
             lbnbal.Text = dt.Rows[0][0].ToString();*/
            string Query = @"select  ACBal from CreateAccountTB where   ACNum= " + lbnaccno.Text + "";
            OleDbCommand cmd = new OleDbCommand(Query, Con);
            DataTable dt = new DataTable();
            OleDbDataAdapter oda = new OleDbDataAdapter(cmd);
            oda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {

                lbnbal.Text = "Rs." + dr["ACBal"].ToString();

            }
            Con.Close();

        }


        private void CheckBalanceFormcs_Load(object sender, EventArgs e)
        {
            lbnaccno.Text = MDIForm.AccountNumber;
            getbalance();
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

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
