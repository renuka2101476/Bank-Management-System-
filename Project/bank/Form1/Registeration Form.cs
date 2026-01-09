using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Net.NetworkInformation;
using System.Xml.Linq;
using System.Text.RegularExpressions;

namespace Form1
{
    public partial class Registeration_Form : Form
    {
        public Registeration_Form()
        {
            InitializeComponent();
        }

        OleDbConnection Con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= D:\Bank Management System\Database\AccounttDB.accdb");
        private void Registeration_Form_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (txtLname.Text == "" || txtAName.Text == "" || txtPhone.Text == "" || txtAddress.Text == "" || txtGender.Text == "" || txtedu.Text == "" || txtIncome.Text == "" || txtpassword.Text == "")
            {
                MessageBox.Show("Missing Information..");
            }
            else if (txtPhone.Text.Length != 10)
            {
                MessageBox.Show("Phone number should be 10 digits long.");
            }
            else
            {
                try
                {
                    Con.Open();
                    OleDbCommand cmd = new OleDbCommand("insert into CreateAccountTB(ACName,ACLName,ACPhone,ACAddress,ACGender,ACEduc,ACIncome,ACPass,ACBal) values(@Aname,@Alname,@APhone,@Addr,@AGen,@AEdu,@AIncome,@APas,@ABal)", Con);

                    cmd.Parameters.AddWithValue("@Aname", txtAName.Text);
                    cmd.Parameters.AddWithValue("@Alname", txtLname.Text);
                    cmd.Parameters.AddWithValue("@APhone", txtPhone.Text);
                    cmd.Parameters.AddWithValue("@Addr", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@AGen", txtGender.Text);
                    cmd.Parameters.AddWithValue("@AEdu", txtedu.Text);
                    cmd.Parameters.AddWithValue("@AIncome", txtIncome.Text);
                    cmd.Parameters.AddWithValue("@APas", txtpassword.Text);
                    cmd.Parameters.AddWithValue("@ABal", 0);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account Created ..");
                    Con.Close();

                    this.Close();
                    LoginForm lf = new LoginForm();
                    lf.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }




            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void Registeration_Form_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtLname.Text = "";
            txtAName.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
            txtGender.Text = "";
            txtedu.Text = "";
            txtIncome.Text = "";
            txtpassword.Text = "";
            txtLname.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm lf = new LoginForm();
            lf.Show();
        }
    }
}

