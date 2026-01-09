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
    public partial class PassBookForm : Form
    {
        public PassBookForm()
        {
            InitializeComponent();
        }

        OleDbConnection Con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= D:\Bank Management System\Database\AccounttDB.accdb");

        private void PassBookForm_Load(object sender, EventArgs e)
        {
            accno.Text = LoginForm.AccountNumber;
        }

        private void btnBcak_Click(object sender, EventArgs e)
        {

        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (AccHNametxt.Text == "" || AccTypecomboBox.Text == "" || MoNotxt.Text == "" || PanNotxt.Text == "" || addresstxt.Text == "")
            {
                MessageBox.Show("Missing Information....");
            }
            else if (MoNotxt.Text.Length != 10)
            {
                MessageBox.Show("Phone number should be 10 digits long.");
            }
            else if (PanNotxt.Text.Length != 12)
            {
                MessageBox.Show("AdharCard Number should be 12 digits long.");
            }
            else
            {
                try
                {
                    Con.Open();
                    OleDbCommand cmd = new OleDbCommand("insert into BookTB ([Hname], [Type], [AccType], [Phoneno], [Adharcardno], [Address]) values(@name,@btp,@AccType,@PhoneNo,@adno,@Address)", Con);
                    cmd.Parameters.AddWithValue("@name", AccHNametxt.Text);
                    cmd.Parameters.AddWithValue("@btp", "Pass Book");
                    cmd.Parameters.AddWithValue("@AccType", AccTypecomboBox.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@PhoneNo", MoNotxt.Text);
                    cmd.Parameters.AddWithValue("@adno", PanNotxt.Text);
                    cmd.Parameters.AddWithValue("@Address", addresstxt.Text);
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBcak_Click_1(object sender, EventArgs e)
        {
            this.Close();
            MDIForm mf = new MDIForm();
            mf.Show();
        }
    }
}
