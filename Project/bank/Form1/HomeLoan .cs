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
    public partial class HomeLoan : Form
    {
        public HomeLoan()
        {
            InitializeComponent();
        }

        OleDbConnection Con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= D:\Bank Management System\Database\AccounttDB.accdb");
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            MDIForm mf = new MDIForm();
            mf.Show();
        }

        private void HomeLoan_Load(object sender, EventArgs e)
        {
            accn.Text = MDIForm.AccountNumber;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtHname.Text == "" || txtcontno.Text == "" || txtaddress.Text == "" || txtLduration.Text == "" || txtadharno.Text == "")
            {
                MessageBox.Show("Missing Information..");
            }
            else if (txtcontno.Text.Length != 10)
            {
                MessageBox.Show("Phone number should be 10 digits long.");
            }
            else if (txtadharno.Text.Length != 12)
            {
                MessageBox.Show("AdharCard Number should be 12 digits long.");
            }
            else
            {
                try
                {
                    Con.Open();
                    OleDbCommand cmd = new OleDbCommand("insert into LoanTB ([Hname], [Type], [Cno], [Address], [Duration], [Adharcardno]) values(@name,@tp,@no,@Adr,@dur,@Ano)", Con);

                    cmd.Parameters.AddWithValue("@name", txtHname.Text);
                    cmd.Parameters.AddWithValue("@tp", "Home Loan");
                    cmd.Parameters.AddWithValue("@no", txtcontno.Text);
                    cmd.Parameters.AddWithValue("@Adr", txtaddress.Text);
                    cmd.Parameters.AddWithValue("@dur", txtLduration.Text);
                    cmd.Parameters.AddWithValue("@Ano", txtadharno.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Applied Successfully.....");
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
    }
}
