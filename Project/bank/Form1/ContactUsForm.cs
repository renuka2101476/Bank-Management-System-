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
    public partial class ContactUsForm : Form
    {
        public ContactUsForm()
        {
            InitializeComponent();
        }

        OleDbConnection Con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= D:\Bank Management System\Database\AccounttDB.accdb");

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            MDIForm mf = new MDIForm();
            mf.Show();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (nametxt.Text == "" || contxt.Text == "" || messtxt.Text == "")   //dateTimePicker1.Text == "" ||
            {
                MessageBox.Show("Missing Information..");
            }
            else if (contxt.Text.Length != 10)
            {
                MessageBox.Show("Phone number should be 10 digits long.");
            }
            else
            {
                try
                {
                    Con.Open();
                    OleDbCommand cmd = new OleDbCommand("insert into ContactUsTB([Name], [PhoneNo], [Date], [Message]) values(@name,@pno,@dt,@mess)", Con);
                    cmd.Parameters.AddWithValue("@name", nametxt.Text);
                    cmd.Parameters.AddWithValue("@pno", contxt.Text);
                    cmd.Parameters.AddWithValue("@dt", DateTime.Now.Date);
                    cmd.Parameters.AddWithValue("@mess", messtxt.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Saved....");
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
