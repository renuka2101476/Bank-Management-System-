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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        public static String AccountNumber;
        OleDbConnection Con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= D:\Bank Management System\Database\AccounttDB.accdb");
        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
            Registeration_Form rf = new Registeration_Form();
            rf.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtAccNo.Text == "" && txtPassword.Text == "")
            {
                MessageBox.Show("PLease enter username or Password ", " Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtAccNo.Text != "" && txtPassword.Text != "")
            {

                Con.Open();
                string query = "select  * from CreateAccountTB where ACNum = @aco and ACPass =@pass";
                OleDbCommand cmd = new OleDbCommand(query, Con);
                cmd.Parameters.AddWithValue("@aco", txtAccNo.Text);
                cmd.Parameters.AddWithValue("@pass", txtPassword.Text);
                OleDbDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows == true)
                {

                    MessageBox.Show("Login success", "sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AccountNumber = txtAccNo.Text;
                    this.Close();
                    MDIForm mf = new MDIForm();
                    mf.Show();
                    Con.Close();
                }
                else
                {
                    MessageBox.Show("Invalid Usernmae or Password", "login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Con.Close();
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtAccNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }
    }
}
