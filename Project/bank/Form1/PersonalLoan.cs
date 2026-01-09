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
    public partial class PersonalLoan : Form
    {
        public PersonalLoan()
        {
            InitializeComponent();
        }

        OleDbConnection Con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= D:\Bank Management System\Database\AccounttDB.accdb");

        private void PersonalLoan_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            MDIForm mf = new MDIForm();
            mf.Show();
        }

        private void PersonalLoan_Load_1(object sender, EventArgs e)
        {
            labaccno.Text = MDIForm.AccountNumber;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (hnametxt.Text == "" || connotxt.Text == "" || addresstxt.Text == "" || Ldurationtxt.Text == "" || adharnotxt.Text == "")
            {
                MessageBox.Show("Missing Information....");
            }
            else if (connotxt.Text.Length != 10)
            {
                MessageBox.Show("Phone number should be 10 digits long.");
            }
            else if (adharnotxt.Text.Length != 12)
            {
                MessageBox.Show("AdharCard Number should be 12 digits long.");
            }
            else
            {
                try
                {
                    Con.Open();
                    OleDbCommand cmd = new OleDbCommand("insert into LoanTB( [Hname], [Type], [Cno], [Address], [Duration], [Adharcardno])values(@name,@tp,@no,@Adr,@dur,@Ano)", Con);

                    cmd.Parameters.AddWithValue("@name", hnametxt.Text);
                    cmd.Parameters.AddWithValue("@tp", "Personal Loan");
                    cmd.Parameters.AddWithValue("@no", connotxt.Text);
                    cmd.Parameters.AddWithValue("@Adr", addresstxt.Text);
                    cmd.Parameters.AddWithValue("@dur", Ldurationtxt.Text);
                    cmd.Parameters.AddWithValue("@Ano", adharnotxt.Text);
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
            MDIForm mf = new MDIForm();
            mf.Show();
        }
    }
}
