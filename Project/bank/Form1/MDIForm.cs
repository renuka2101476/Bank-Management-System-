using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class MDIForm : Form
    {
        public MDIForm()
        {
            InitializeComponent();
        }
        public static String AccountNumber;


        private void MDIForm_Load(object sender, EventArgs e)
        {
            lbnAccNum.Text = "Account Number : " + LoginForm.AccountNumber;
            AccountNumber = LoginForm.AccountNumber;

        }

        private void checkBalanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            CheckBalanceFormcs cb = new CheckBalanceFormcs();
            cb.Show();
        }

        private void depositToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DepositForm df = new DepositForm();
            df.Show();
            this.Close();
        }


        private void withdrawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WithdrawAmt wf = new WithdrawAmt();
            wf.Show();
            this.Close();
        }

        private void accountHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            AccountHistory ah = new AccountHistory();
            ah.Show();

        }

        private void forgotPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            ForgotPasswordForm fp = new ForgotPasswordForm();
            fp.Show();


        }

        private void lbnAccNum_Click(object sender, EventArgs e)
        {

        }

        private void servicesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fORMToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void fixedDepositeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            FixedDepositeForm fd = new FixedDepositeForm();
            fd.Show();
        }

        private void transferAmountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            TransferAmount tf = new TransferAmount();
            tf.Show();

        }

        private void personalLoanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            PersonalLoan pl = new PersonalLoan();
            pl.Show();
        }

        private void loansToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void homeLoanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeLoan hl = new HomeLoan();
            hl.Show();
        }

        private void contactUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ContactUsForm cu = new ContactUsForm();
            cu.Show();
        }

        private void passBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            PassBookForm pf = new PassBookForm();
            pf.Show();
        }

        private void checkBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChhechBookForm ch = new ChhechBookForm();
            ch.Show();
        }

        private void employeeManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Employee em = new Employee();
            em.Show();
        }

        private void branchManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            BankBranchForm bb = new BankBranchForm();
            bb.Show();

        }

        private void debitCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DebitCardForm db = new DebitCardForm();
            db.Show();
        }

        private void creditCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreditCardForm cb = new CreditCardForm();
            cb.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm lf = new LoginForm();
            lf.Show();
        }
    }
}
