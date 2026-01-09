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
    public partial class DebitCardForm : Form
    {
        public DebitCardForm()
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
            if (HNametxt.Text == "" || AccTypecomboBox.Text == "" || Monotxt.Text == "" || addresstxt.Text == "")
            {
                MessageBox.Show("Missing Information....");
            }
            else if (Monotxt.Text.Length != 10)
            {
                MessageBox.Show("Phone number should be 10 digits long.");
            }
            else
            {
                try
                {
                    Con.Open();
                    OleDbCommand cmd = new OleDbCommand("insert into CardTB ([Name], [Type], [AType], [Phoneno], [Address]) values(@nam,@bt,@AcType,@Phone,@Address)", Con);

                    cmd.Parameters.AddWithValue("@nam", HNametxt.Text);
                    cmd.Parameters.AddWithValue("@bt", "Debit Card");
                    cmd.Parameters.AddWithValue("@AcType", AccTypecomboBox.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Phone", Monotxt.Text);
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

        private void DebitCardForm_Load(object sender, EventArgs e)
        {
            acclaball.Text = MDIForm.AccountNumber;
        }
    }
}
