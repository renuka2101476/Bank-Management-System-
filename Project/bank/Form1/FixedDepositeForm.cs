using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class FixedDepositeForm : Form
    {
        public FixedDepositeForm()
        {
            InitializeComponent();
        }

        OleDbConnection Con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= D:\Bank Management System\Database\AccounttDB.accdb");
        int bal;
        int newbalance;
        private void FixedDepositeForm_Load(object sender, EventArgs e)
        {
            lbn.Text = MDIForm.AccountNumber;
            getbal();
        }


        /* private void addTran()
         {
             try
             {
                 Con.Open();
                 OleDbCommand cmd = new OleDbCommand("insert into FixedDeposite(Name,Amount,Date,RateofIntrest) values(@nm,@am,@dt,@rt) ", Con);
                 cmd.Parameters.AddWithValue("@nm", txtName.Text);
                 cmd.Parameters.AddWithValue("@am", txtAmt.Text);
                 cmd.Parameters.AddWithValue("@dt", DateTime.Now.Date);
              //   cmd.Parameters.AddWithValue("@dr", txtDuration.Text  );
                 cmd.Parameters.AddWithValue("@rt", lbnrate.Text);
                 cmd.ExecuteNonQuery();
                 Con.Close();

             }
             catch (Exception Ex)
             {
                 MessageBox.Show(Ex.Message);
                 Con.Close();
             }
         }*/

        private void addTran()
        {
            try
            {
                Con.Open();
                OleDbCommand cmd = new OleDbCommand("INSERT INTO FixedDeposite ([AccNo], [Name], [Amount], [Date],[Duration],[RateofIntrest]) VALUES (@no, @nm, @am, @dt, @da,@rt)", Con);
                cmd.Parameters.AddWithValue("@no", lbn.Text);
                cmd.Parameters.AddWithValue("@nm", txtName.Text);
                cmd.Parameters.AddWithValue("@am", txtAmt.Text);
                cmd.Parameters.AddWithValue("@dt", DateTime.Now.Date);
                cmd.Parameters.AddWithValue("@da", txtDuration.Text);
                cmd.Parameters.AddWithValue("@rt", lbnrate.Text);
                cmd.ExecuteNonQuery();
                Con.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                Con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtAmt.Text == "")
            {
                MessageBox.Show("Missing Information....");
            }
            else if (Convert.ToInt32(txtAmt.Text) <= 0)
            {
                MessageBox.Show("Enter a Valid Amount....");
            }
            else if (Convert.ToInt32(txtAmt.Text) > bal)
            {
                MessageBox.Show("Balance can not be negative....");
            }
            else
            {
                addTran();
                try
                {
                    newbalance = bal - Convert.ToInt32(txtAmt.Text);
                    Con.Open();
                    String query = "update CreateAccountTB set ACBal=" + newbalance + " where ACNum=" + lbn.Text + " ";
                    OleDbCommand cmd = new OleDbCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully Apply for Fixed Deposite...");
                    Con.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void getbal()
        {
            Con.Open();
            string Query = @"select  ACBal from CreateAccountTB where   ACNum= " + lbn.Text + "";
            OleDbCommand cmd = new OleDbCommand(Query, Con);
            DataTable dt = new DataTable();
            OleDbDataAdapter oda = new OleDbDataAdapter(cmd);
            oda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                bal = Convert.ToInt32(dr["ACBal"].ToString());
            }
            Con.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            MDIForm mf = new MDIForm();
            mf.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}
