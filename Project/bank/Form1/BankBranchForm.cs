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
    public partial class BankBranchForm : Form
    {
        public BankBranchForm()
        {
            InitializeComponent();
        }

        OleDbConnection Con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= D:\Bank Management System\Database\AccounttDB.accdb");

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
            MDIForm mf = new MDIForm();
            mf.Show();
        }

        private void insertbtn_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                OleDbCommand cmd = new OleDbCommand("insert into BranchTB ( [BranchName], [City], [District], [PinCode]) values (@bnm,@ci,@dis,@pin) ", Con);
              //  cmd.Parameters.AddWithValue("@bid", bidtxt.Text);
                cmd.Parameters.AddWithValue("@bnm", bnametxt.Text);
                cmd.Parameters.AddWithValue("@ci", citytxt.Text);
                cmd.Parameters.AddWithValue("@dis", districttxt.Text);
                cmd.Parameters.AddWithValue("@pin", pincodetxt.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Record Inserted.....");

            }
            catch (Exception)
            {
                MessageBox.Show("Record Not Inserted....");
                Con.Close();
            }

        }

        private void updatebtn_Click(object sender, EventArgs e)
        {

           /* try
            {
                Con.Open();
                OleDbCommand cmd = new OleDbCommand("update BranchTB set City = @ca where BranchName = @bname", Con);
                cmd.Parameters.AddWithValue("@ca", citytxt.Text);
                cmd.Parameters.AddWithValue("@bnm", bnametxt.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Record Updated.....");

            }
            catch (Exception)
            {
                MessageBox.Show("Record Not Updated....");
                Con.Close();
            }*/
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                OleDbCommand cmd = new OleDbCommand("select City, District, PinCode from BranchTB where BranchName = @bname ", Con);
                cmd.Parameters.AddWithValue("@bname", bnametxt.Text);

                OleDbDataReader dreader = cmd.ExecuteReader();
                if (dreader.Read())
                {
                  
                    citytxt.Text = dreader[0].ToString();
                    districttxt.Text = dreader[1].ToString();
                    pincodetxt.Text = dreader[2].ToString();
                }

                MessageBox.Show("Successfully Fetch Record ....");


            }
            catch (Exception)
            {
                MessageBox.Show("NO Record....");
                Con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            bnametxt.Text = "";
            citytxt.Text = "";
            districttxt.Text = "";
            pincodetxt.Text = "";
            bnametxt.Focus();
        }
    }
}
