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
    public partial class TransferAmount : Form
    {
        public TransferAmount()
        {
            InitializeComponent();
        }
        OleDbConnection Con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= D:\Bank Management System\Database\AccounttDB.accdb");

        // int newbalance1;
        //int newbalance2;
        //int bal;

        private void addTrans()
        {

            try
            {
                Con.Open();
                OleDbCommand cmd = new OleDbCommand("insert into TransferAmtHistory ([FromAcc], [ToAcc],[type], [Date], [Amount]) values (@fno,@tno,@tp,@dt,@am) ", Con);
                cmd.Parameters.AddWithValue("@fno", txtFromAno.Text);
                cmd.Parameters.AddWithValue("@tno", txtToAno.Text);
                cmd.Parameters.AddWithValue(" @tp", "Transfer Amount");
                cmd.Parameters.AddWithValue("@dt", DateTime.Now.Date);
                cmd.Parameters.AddWithValue("@am", txtAmtt.Text);
                cmd.ExecuteNonQuery();

                Con.Close();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                // Con.Close();
            }
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {

            addTrans();
            try
            {
                //  newbalance1 = bal - Convert.ToInt32(txtFromAno.Text);
                //  newbalance2 = bal + Convert.ToInt32(txtToAno.Text);

                Con.Open();
                String query = "update CreateAccountTB set ACBal = ACBal - " + txtAmtt.Text + " where ACNum=" + txtFromAno.Text + " ";
                OleDbCommand cmd = new OleDbCommand(query, Con);
                cmd.ExecuteNonQuery();

                String query2 = "update CreateAccountTB set ACBal = ACBal + " + txtAmtt.Text + " where ACNum=" + txtToAno.Text + " ";
                OleDbCommand cmd1 = new OleDbCommand(query2, Con);
                cmd1.ExecuteNonQuery();

                MessageBox.Show("Successfully Transfered Amount...");
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
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            MDIForm mf = new MDIForm();
            mf.Show();
        }

        private void TransferAmount_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
