namespace Form1
{
    partial class WithdrawAmt
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
            label2 = new Label();
            btnDeposite = new Button();
            button2 = new Button();
            lbnAmtDep = new Label();
            txtwdAmt = new TextBox();
            label3 = new Label();
            lbnWithAcno = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial Black", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(825, 60);
            label2.Name = "label2";
            label2.Size = new Size(517, 70);
            label2.TabIndex = 17;
            label2.Text = "Withdraw Amount";
            // 
            // btnDeposite
            // 
            btnDeposite.BackColor = Color.DarkGray;
            btnDeposite.Font = new Font("Bahnschrift SemiBold SemiConden", 19F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeposite.Location = new Point(1150, 398);
            btnDeposite.Name = "btnDeposite";
            btnDeposite.Size = new Size(198, 73);
            btnDeposite.TabIndex = 14;
            btnDeposite.Text = "Withdraw";
            btnDeposite.UseVisualStyleBackColor = false;
            btnDeposite.Click += btnDeposite_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkGray;
            button2.Font = new Font("Bahnschrift SemiBold SemiConden", 19F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(1150, 520);
            button2.Name = "button2";
            button2.Size = new Size(198, 73);
            button2.TabIndex = 15;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // lbnAmtDep
            // 
            lbnAmtDep.AutoSize = true;
            lbnAmtDep.BackColor = Color.Transparent;
            lbnAmtDep.Font = new Font("Times New Roman", 19F, FontStyle.Bold, GraphicsUnit.Point);
            lbnAmtDep.ForeColor = Color.Black;
            lbnAmtDep.Location = new Point(880, 269);
            lbnAmtDep.Name = "lbnAmtDep";
            lbnAmtDep.Size = new Size(219, 36);
            lbnAmtDep.TabIndex = 18;
            lbnAmtDep.Text = "Enter Amount ";
            // 
            // txtwdAmt
            // 
            txtwdAmt.Font = new Font("Segoe Condensed", 16.4F, FontStyle.Bold, GraphicsUnit.Point);
            txtwdAmt.Location = new Point(1150, 266);
            txtwdAmt.Name = "txtwdAmt";
            txtwdAmt.Size = new Size(174, 39);
            txtwdAmt.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Times New Roman", 19F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(880, 170);
            label3.Name = "label3";
            label3.Size = new Size(176, 36);
            label3.TabIndex = 20;
            label3.Text = "Account No";
            // 
            // lbnWithAcno
            // 
            lbnWithAcno.AutoSize = true;
            lbnWithAcno.BackColor = Color.Transparent;
            lbnWithAcno.Font = new Font("Segoe Condensed", 16.4F, FontStyle.Bold, GraphicsUnit.Point);
            lbnWithAcno.ForeColor = Color.Black;
            lbnWithAcno.Location = new Point(1201, 170);
            lbnWithAcno.Name = "lbnWithAcno";
            lbnWithAcno.Size = new Size(56, 33);
            lbnWithAcno.TabIndex = 21;
            lbnWithAcno.Text = "Ano";
            // 
            // WithdrawAmt
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.withdraw;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1400, 800);
            Controls.Add(lbnWithAcno);
            Controls.Add(label3);
            Controls.Add(txtwdAmt);
            Controls.Add(lbnAmtDep);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(btnDeposite);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 5, 4, 5);
            Name = "WithdrawAmt";
            Text = "WithdrawAmt";
            Load += WithdrawAmt_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Button btnDeposite;
        private Button button2;
        private Label lbnAmtDep;
        private TextBox txtwdAmt;
        private Label label3;
        private Label lbnWithAcno;
    }
}