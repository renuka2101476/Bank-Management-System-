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
    public partial class ChhechBookForm : Form
    {
        public ChhechBookForm()
        {
            InitializeComponent();
        }

        OleDbConnection Con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= D:\Bank Management System\Database\AccounttDB.accdb");

        private void btnBcak_Click(object sender, EventArgs e)
        {
            this.Close();
            MDIForm mf = new MDIForm();
            mf.Show();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (HNametxt.Text == "" || AccTypecomboBox.Text == "" || Monotxt.Text == "" || adharnotxt.Text == "" || addresstxt.Text == "")
            {
                MessageBox.Show("Missing Information....");
            }
            else if (Monotxt.Text.Length != 10)
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
                    OleDbCommand cmd = new OleDbCommand("insert into BookTB ([Hname], [Type], [AccType], [Phoneno], [Adharcardno], [Address]) values(@name,@btp,@AccType,@PhoneNo,@adno,@Address)", Con);

                    cmd.Parameters.AddWithValue("@name", HNametxt.Text);
                    cmd.Parameters.AddWithValue("@btp", "Pass Book");
                    cmd.Parameters.AddWithValue("@AccType", AccTypecomboBox.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@PhoneNo", Monotxt.Text);
                    cmd.Parameters.AddWithValue("@adno", adharnotxt.Text);
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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void ChhechBookForm_Load(object sender, EventArgs e)
        {
            acclabal.Text = LoginForm.AccountNumber;
        }
    }
}
