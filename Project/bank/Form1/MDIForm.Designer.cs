namespace Form1
{
    partial class MDIForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            contextMenuStrip2 = new ContextMenuStrip(components);
            contextMenuStrip3 = new ContextMenuStrip(components);
            contextMenuStrip4 = new ContextMenuStrip(components);
            menuStrip1 = new MenuStrip();
            depositToolStripMenuItem = new ToolStripMenuItem();
            withdrawToolStripMenuItem = new ToolStripMenuItem();
            checkBalanceToolStripMenuItem = new ToolStripMenuItem();
            transferAmountToolStripMenuItem = new ToolStripMenuItem();
            accountHistoryToolStripMenuItem = new ToolStripMenuItem();
            fixedDepositeToolStripMenuItem = new ToolStripMenuItem();
            servicesToolStripMenuItem = new ToolStripMenuItem();
            forgotPasswordToolStripMenuItem = new ToolStripMenuItem();
            loansToolStripMenuItem = new ToolStripMenuItem();
            personalLoanToolStripMenuItem = new ToolStripMenuItem();
            homeLoanToolStripMenuItem = new ToolStripMenuItem();
            passBookToolStripMenuItem = new ToolStripMenuItem();
            checkBookToolStripMenuItem = new ToolStripMenuItem();
            debitCardToolStripMenuItem = new ToolStripMenuItem();
            creditCardToolStripMenuItem = new ToolStripMenuItem();
            contactUsToolStripMenuItem = new ToolStripMenuItem();
            managementToolStripMenuItem = new ToolStripMenuItem();
            employeeManagementToolStripMenuItem = new ToolStripMenuItem();
            branchManagementToolStripMenuItem = new ToolStripMenuItem();
            lbnAccNum = new Label();
            button1 = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.ImageScalingSize = new Size(20, 20);
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(61, 4);
            // 
            // contextMenuStrip3
            // 
            contextMenuStrip3.ImageScalingSize = new Size(20, 20);
            contextMenuStrip3.Name = "contextMenuStrip3";
            contextMenuStrip3.Size = new Size(61, 4);
            // 
            // contextMenuStrip4
            // 
            contextMenuStrip4.ImageScalingSize = new Size(20, 20);
            contextMenuStrip4.Name = "contextMenuStrip4";
            contextMenuStrip4.Size = new Size(61, 4);
            contextMenuStrip4.Text = "Deposite";
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 14.5F, FontStyle.Bold, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { depositToolStripMenuItem, withdrawToolStripMenuItem, checkBalanceToolStripMenuItem, transferAmountToolStripMenuItem, accountHistoryToolStripMenuItem, fixedDepositeToolStripMenuItem, servicesToolStripMenuItem, managementToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1500, 43);
            menuStrip1.TabIndex = 17;
            menuStrip1.Text = "menuStrip1";
            // 
            // depositToolStripMenuItem
            // 
            depositToolStripMenuItem.Name = "depositToolStripMenuItem";
            depositToolStripMenuItem.Size = new Size(120, 39);
            depositToolStripMenuItem.Text = "Deposit";
            depositToolStripMenuItem.Click += depositToolStripMenuItem_Click;
            // 
            // withdrawToolStripMenuItem
            // 
            withdrawToolStripMenuItem.Name = "withdrawToolStripMenuItem";
            withdrawToolStripMenuItem.Size = new Size(144, 39);
            withdrawToolStripMenuItem.Text = "Withdraw";
            withdrawToolStripMenuItem.Click += withdrawToolStripMenuItem_Click;
            // 
            // checkBalanceToolStripMenuItem
            // 
            checkBalanceToolStripMenuItem.Name = "checkBalanceToolStripMenuItem";
            checkBalanceToolStripMenuItem.Size = new Size(197, 39);
            checkBalanceToolStripMenuItem.Text = "Check Balance";
            checkBalanceToolStripMenuItem.Click += checkBalanceToolStripMenuItem_Click;
            // 
            // transferAmountToolStripMenuItem
            // 
            transferAmountToolStripMenuItem.Name = "transferAmountToolStripMenuItem";
            transferAmountToolStripMenuItem.Size = new Size(228, 39);
            transferAmountToolStripMenuItem.Text = "Transfer Amount";
            transferAmountToolStripMenuItem.Click += transferAmountToolStripMenuItem_Click;
            // 
            // accountHistoryToolStripMenuItem
            // 
            accountHistoryToolStripMenuItem.Name = "accountHistoryToolStripMenuItem";
            accountHistoryToolStripMenuItem.Size = new Size(163, 39);
            accountHistoryToolStripMenuItem.Text = "Transaction";
            accountHistoryToolStripMenuItem.Click += accountHistoryToolStripMenuItem_Click;
            // 
            // fixedDepositeToolStripMenuItem
            // 
            fixedDepositeToolStripMenuItem.Name = "fixedDepositeToolStripMenuItem";
            fixedDepositeToolStripMenuItem.Size = new Size(204, 39);
            fixedDepositeToolStripMenuItem.Text = "Fixed Deposite";
            fixedDepositeToolStripMenuItem.Click += fixedDepositeToolStripMenuItem_Click;
            // 
            // servicesToolStripMenuItem
            // 
            servicesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { forgotPasswordToolStripMenuItem, loansToolStripMenuItem, passBookToolStripMenuItem, checkBookToolStripMenuItem, debitCardToolStripMenuItem, creditCardToolStripMenuItem, contactUsToolStripMenuItem });
            servicesToolStripMenuItem.Name = "servicesToolStripMenuItem";
            servicesToolStripMenuItem.Size = new Size(126, 39);
            servicesToolStripMenuItem.Text = "Services";
            servicesToolStripMenuItem.Click += servicesToolStripMenuItem_Click;
            // 
            // forgotPasswordToolStripMenuItem
            // 
            forgotPasswordToolStripMenuItem.Name = "forgotPasswordToolStripMenuItem";
            forgotPasswordToolStripMenuItem.Size = new Size(308, 40);
            forgotPasswordToolStripMenuItem.Text = "Change Password";
            forgotPasswordToolStripMenuItem.Click += forgotPasswordToolStripMenuItem_Click;
            // 
            // loansToolStripMenuItem
            // 
            loansToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { personalLoanToolStripMenuItem, homeLoanToolStripMenuItem });
            loansToolStripMenuItem.Name = "loansToolStripMenuItem";
            loansToolStripMenuItem.Size = new Size(308, 40);
            loansToolStripMenuItem.Text = "Loans ";
            loansToolStripMenuItem.Click += loansToolStripMenuItem_Click;
            // 
            // personalLoanToolStripMenuItem
            // 
            personalLoanToolStripMenuItem.Name = "personalLoanToolStripMenuItem";
            personalLoanToolStripMenuItem.Size = new Size(266, 40);
            personalLoanToolStripMenuItem.Text = "Personal Loan";
            personalLoanToolStripMenuItem.Click += personalLoanToolStripMenuItem_Click;
            // 
            // homeLoanToolStripMenuItem
            // 
            homeLoanToolStripMenuItem.Name = "homeLoanToolStripMenuItem";
            homeLoanToolStripMenuItem.Size = new Size(266, 40);
            homeLoanToolStripMenuItem.Text = "Home Loan";
            homeLoanToolStripMenuItem.Click += homeLoanToolStripMenuItem_Click;
            // 
            // passBookToolStripMenuItem
            // 
            passBookToolStripMenuItem.Name = "passBookToolStripMenuItem";
            passBookToolStripMenuItem.Size = new Size(308, 40);
            passBookToolStripMenuItem.Text = "PassBook ";
            passBookToolStripMenuItem.Click += passBookToolStripMenuItem_Click;
            // 
            // checkBookToolStripMenuItem
            // 
            checkBookToolStripMenuItem.Name = "checkBookToolStripMenuItem";
            checkBookToolStripMenuItem.Size = new Size(308, 40);
            checkBookToolStripMenuItem.Text = "CheckBook";
            checkBookToolStripMenuItem.Click += checkBookToolStripMenuItem_Click;
            // 
            // debitCardToolStripMenuItem
            // 
            debitCardToolStripMenuItem.Name = "debitCardToolStripMenuItem";
            debitCardToolStripMenuItem.Size = new Size(308, 40);
            debitCardToolStripMenuItem.Text = "Debit Card";
            debitCardToolStripMenuItem.Click += debitCardToolStripMenuItem_Click;
            // 
            // creditCardToolStripMenuItem
            // 
            creditCardToolStripMenuItem.Name = "creditCardToolStripMenuItem";
            creditCardToolStripMenuItem.Size = new Size(308, 40);
            creditCardToolStripMenuItem.Text = "Credit Card";
            creditCardToolStripMenuItem.Click += creditCardToolStripMenuItem_Click;
            // 
            // contactUsToolStripMenuItem
            // 
            contactUsToolStripMenuItem.Name = "contactUsToolStripMenuItem";
            contactUsToolStripMenuItem.Size = new Size(308, 40);
            contactUsToolStripMenuItem.Text = "Contact Us";
            contactUsToolStripMenuItem.Click += contactUsToolStripMenuItem_Click;
            // 
            // managementToolStripMenuItem
            // 
            managementToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { employeeManagementToolStripMenuItem, branchManagementToolStripMenuItem });
            managementToolStripMenuItem.Name = "managementToolStripMenuItem";
            managementToolStripMenuItem.Size = new Size(192, 39);
            managementToolStripMenuItem.Text = "Management ";
            // 
            // employeeManagementToolStripMenuItem
            // 
            employeeManagementToolStripMenuItem.Name = "employeeManagementToolStripMenuItem";
            employeeManagementToolStripMenuItem.Size = new Size(382, 40);
            employeeManagementToolStripMenuItem.Text = "Employee Management";
            employeeManagementToolStripMenuItem.Click += employeeManagementToolStripMenuItem_Click;
            // 
            // branchManagementToolStripMenuItem
            // 
            branchManagementToolStripMenuItem.Name = "branchManagementToolStripMenuItem";
            branchManagementToolStripMenuItem.Size = new Size(382, 40);
            branchManagementToolStripMenuItem.Text = "Branch Management";
            branchManagementToolStripMenuItem.Click += branchManagementToolStripMenuItem_Click;
            // 
            // lbnAccNum
            // 
            lbnAccNum.AutoSize = true;
            lbnAccNum.BackColor = Color.Transparent;
            lbnAccNum.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lbnAccNum.ForeColor = SystemColors.ControlText;
            lbnAccNum.Location = new Point(542, 255);
            lbnAccNum.Name = "lbnAccNum";
            lbnAccNum.Size = new Size(234, 37);
            lbnAccNum.TabIndex = 18;
            lbnAccNum.Text = "Account Number";
            lbnAccNum.Click += lbnAccNum_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGray;
            button1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(597, 664);
            button1.Name = "button1";
            button1.Size = new Size(234, 80);
            button1.TabIndex = 19;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // MDIForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.image1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1500, 900);
            Controls.Add(button1);
            Controls.Add(lbnAccNum);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MDIForm";
            Text = "MDIForm";
            Load += MDIForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ContextMenuStrip contextMenuStrip1;
        private ContextMenuStrip contextMenuStrip2;
        private ContextMenuStrip contextMenuStrip3;
        private ContextMenuStrip contextMenuStrip4;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem depositToolStripMenuItem;
        private ToolStripMenuItem withdrawToolStripMenuItem;
        private ToolStripMenuItem checkBalanceToolStripMenuItem;
        private ToolStripMenuItem accountHistoryToolStripMenuItem;
        private Label lbnAccNum;
        private ToolStripMenuItem servicesToolStripMenuItem;
        private ToolStripMenuItem forgotPasswordToolStripMenuItem;
        private ToolStripMenuItem fixedDepositeToolStripMenuItem;
        private ToolStripMenuItem transferAmountToolStripMenuItem;
        private ToolStripMenuItem loansToolStripMenuItem;
        private ToolStripMenuItem personalLoanToolStripMenuItem;
        private ToolStripMenuItem homeLoanToolStripMenuItem;
        private ToolStripMenuItem contactUsToolStripMenuItem;
        private ToolStripMenuItem passBookToolStripMenuItem;
        private ToolStripMenuItem checkBookToolStripMenuItem;
        private ToolStripMenuItem managementToolStripMenuItem;
        private ToolStripMenuItem employeeManagementToolStripMenuItem;
        private ToolStripMenuItem branchManagementToolStripMenuItem;
        private ToolStripMenuItem debitCardToolStripMenuItem;
        private ToolStripMenuItem creditCardToolStripMenuItem;
        private Button button1;
    }
}