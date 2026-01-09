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
    public partial class WithdrawAmt : Form
    {
        public WithdrawAmt()
        {
            InitializeComponent();
        }

        OleDbConnection Con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= D:\Bank Management System\Database\AccounttDB.accdb");
        int bal;

        int newbalance;

        private void addTransaction()
        {

            try
            {
                Con.Open();
                OleDbCommand cmd = new OleDbCommand("insert into TransactionTB1 (Ttype,TDate,TAmt) values (@type,@date,@amt) ", Con);
                cmd.Parameters.AddWithValue("@type", "Withdraw");
                cmd.Parameters.AddWithValue("@date", DateTime.Now.Date);
                cmd.Parameters.AddWithValue("@amt", txtwdAmt.Text);
                cmd.ExecuteNonQuery();

                Con.Close();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                Con.Close();
            }
        }

        private void btnDeposite_Click(object sender, EventArgs e)
        {
            if (txtwdAmt.Text == "")
            {
                MessageBox.Show("Missing Information....");
            }
            else if (Convert.ToInt32(txtwdAmt.Text) <= 0)
            {
                MessageBox.Show("Enter a Valid Amount....");
            }
            else if (Convert.ToInt32(txtwdAmt.Text) > bal)
            {
                MessageBox.Show("Balance is Zero ....");
            }
            else
            {
                addTransaction();
                try
                {
                    newbalance = bal - Convert.ToInt32(txtwdAmt.Text);


                    Con.Open();
                    String query = "update CreateAccountTB set ACBal=" + newbalance + " where ACNum=" + lbnWithAcno.Text + " ";
                    OleDbCommand cmd = new OleDbCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully Withdraw...");
                    Con.Close();

                    this.Close();
                    MDIForm mf = new MDIForm();
                    mf.Show();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void getbalance()
        {
            Con.Open();
            string Query = @"select  ACBal from CreateAccountTB where   ACNum= " + lbnWithAcno.Text + "";
            OleDbCommand cmd = new OleDbCommand(Query, Con);
            DataTable dt = new DataTable();
            OleDbDataAdapter oda = new OleDbDataAdapter(cmd);
            oda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                //oldbalance = Convert.ToInt32(dr["ACBal"].ToString());
                // lbnavailablebal.Text = "Rs." + dr["ACBal"].ToString();
                bal = Convert.ToInt32(dr["ACBal"].ToString());
            }
            Con.Close();

        }
        private void WithdrawAmt_Load(object sender, EventArgs e)
        {
            lbnWithAcno.Text = MDIForm.AccountNumber;
            getbalance();
        }

        private void lbnavailablebal_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            MDIForm mf = new MDIForm();
            mf.Show();

        }
    }
}
