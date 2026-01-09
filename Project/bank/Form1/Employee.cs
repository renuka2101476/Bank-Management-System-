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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }
        OleDbConnection Con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= D:\Bank Management System\Database\AccounttDB.accdb");

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtEName.Text == "" || txtEPhone.Text == "" || txtDesignation.Text == "" || txtSalary.Text == "" || addresstxt.Text == "")
            {
                MessageBox.Show("Missing Information..");
            }
            else if (txtEPhone.Text.Length != 10)
            {
                MessageBox.Show("Phone number should be 10 digits long.");
            }
            else
            {
                try
                {
                    Con.Open();
                    OleDbCommand cmd = new OleDbCommand("insert into EmployeeTB([EmpName], [PhoneNo], [Designation], [Salary], [Address]) values(@ename,@pno,@desig,@sal,@add)", Con);
                    cmd.Parameters.AddWithValue("@ename", txtEName.Text);
                    cmd.Parameters.AddWithValue("@pno", txtEPhone.Text);
                    cmd.Parameters.AddWithValue("@desig", txtDesignation.Text);
                    cmd.Parameters.AddWithValue("@sal", txtSalary.Text);
                    cmd.Parameters.AddWithValue("@add", addresstxt.Text);
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            /* try
             {
                 Con.Open();
                 OleDbCommand cmd = new OleDbCommand("update EmployeeTB set PhoneNo = @phono, Designation = @desig, Salary = @sal, Address = @add where EmpName = @ename", Con);
                 cmd.Parameters.AddWithValue("@ename", txtEName.Text);
                 cmd.Parameters.AddWithValue("@phono", txtEPhone.Text);
                 cmd.Parameters.AddWithValue("@desig", txtDesignation.Text);
                 cmd.Parameters.AddWithValue("@sal", txtSalary.Text);
                 cmd.Parameters.AddWithValue("@add", addresstxt.Text);
                 cmd.ExecuteNonQuery();

                 MessageBox.Show("Record Updated.....");

             }
             catch (Exception)
             {
                 MessageBox.Show("Record Not Updated....");
                 Con.Close();
             }*/
        }

        private void btnSearach_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                OleDbCommand cmd = new OleDbCommand("select EmpName, PhoneNo, Salary, Address from EmployeeTB where Designation = @ename ", Con);
                cmd.Parameters.AddWithValue("@ename", txtDesignation.Text);

                OleDbDataReader dreader = cmd.ExecuteReader();
                if (dreader.Read())
                {
                    txtEName.Text = dreader[0].ToString();
                    txtEPhone.Text = dreader[1].ToString();
                  //  txtDesignation.Text = dreader[1].ToString();
                    txtSalary.Text = dreader[2].ToString();
                    addresstxt.Text = dreader[3].ToString();
                }



            }
            catch (Exception)
            {
                MessageBox.Show("NO Record....");
                Con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtEName.Text = "";
            txtEPhone.Text = "";
            txtDesignation.Text = "";
            txtSalary.Text = "";
            addresstxt.Text = "";
            txtDesignation.Focus();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
            MDIForm mf = new MDIForm();
            mf.Show();
        }
    }

}
