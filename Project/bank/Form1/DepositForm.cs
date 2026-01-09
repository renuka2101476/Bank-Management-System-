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
    public partial class DepositForm : Form
    {
        public DepositForm()
        {
            InitializeComponent();
        }

        OleDbConnection Con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= D:\Bank Management System\Database\AccounttDB.accdb");

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int oldbalance;
        int newbalance;

        private void getbalance()
        {
            Con.Open();
            /* OleDbDataAdapter da = new OleDbDataAdapter("Select ACBal from CreateAccountTB where ACNum='"+lbnbal.Text+"' ",Con);
             DataTable dt = new DataTable();
             da.Fill(dt);
             lbnbal.Text = dt.Rows[0][0].ToString();*/
            string Query = @"select  ACBal from CreateAccountTB where   ACNum= " + lbnacno.Text + "";
            OleDbCommand cmd = new OleDbCommand(Query, Con);
            DataTable dt = new DataTable();
            OleDbDataAdapter oda = new OleDbDataAdapter(cmd);
            oda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                oldbalance = Convert.ToInt32(dr["ACBal"].ToString());
                //lbnbal.Text = "Rs." + dr["ACBal"].ToString();

            }
            Con.Close();

        }

        private void addTransaction()
        {

            try
            {
                Con.Open();
                OleDbCommand cmd = new OleDbCommand("insert into TransactionTB1 (Ttype,TDate,TAmt) values (@type,@date,@amt) ", Con);
                //cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@type", "Deposit");
                cmd.Parameters.AddWithValue("@date", DateTime.Now.Date);
                cmd.Parameters.AddWithValue("@amt", txtDepAmt.Text);
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
            if (txtDepAmt.Text == "" || Convert.ToInt32(txtDepAmt.Text) <= 0)
            {
                MessageBox.Show("Enter the Amount To Deposit...");

            }
            else
            {
                addTransaction();

                newbalance = oldbalance + Convert.ToInt32(txtDepAmt.Text);

                try
                {

                    Con.Open();
                    String query = "update CreateAccountTB set ACBal=" + newbalance + " where ACNum=" + lbnacno.Text + " ";
                    OleDbCommand cmd = new OleDbCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully Deposite..");

                    Con.Close();

                    this.Close();
                    MDIForm mf = new MDIForm();
                    mf.Show();


                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            MDIForm mf = new MDIForm();
            mf.Show();
        }

        private void DepositForm_Load(object sender, EventArgs e)
        {
            lbnacno.Text = MDIForm.AccountNumber;
            getbalance();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbnacno_Click(object sender, EventArgs e)
        {
        }

        private void txtDepAmt_TextChanged(object sender, EventArgs e)
        {
        }

        private void lbnAmtDep_Click(object sender, EventArgs e)
        {
        }
    }
}
