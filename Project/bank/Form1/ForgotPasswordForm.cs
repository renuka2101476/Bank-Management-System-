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
    public partial class ForgotPasswordForm : Form
    {
        public ForgotPasswordForm()
        {
            InitializeComponent();
        }
        OleDbConnection Con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= D:\Bank Management System\Database\AccounttDB.accdb");
        string acc = LoginForm.AccountNumber;
        private void btnChange_Click(object sender, EventArgs e)
        {
            if (txtNewPass.Text == "" || txtConfirmPass.Text == "")
            {
                MessageBox.Show("Enter Password And Confirm The New Password", " Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtConfirmPass.Text != txtNewPass.Text)
            {
                MessageBox.Show("New Password And Confirm Password are Different", " Password Different", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try

                {
                    Con.Open();
                    String query = "update CreateAccountTB set ACPass=" + txtNewPass.Text + " where ACNum=" + acc + " ";
                    OleDbCommand cmd = new OleDbCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Password Successfully Updated...");
                    Con.Close();

                    this.Close();
                    LoginForm lf = new LoginForm();
                    lf.Show();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
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
