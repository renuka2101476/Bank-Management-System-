namespace Form1
{
    partial class DepositForm
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
            btnBack = new Button();
            btnDeposite = new Button();
            txtDepAmt = new TextBox();
            lbnAmtDep = new Label();
            label1 = new Label();
            lbnacno = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial Black", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 0, 64);
            label2.Location = new Point(699, 96);
            label2.Name = "label2";
            label2.Size = new Size(498, 70);
            label2.TabIndex = 11;
            label2.Text = "Deposite Amount";
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ActiveBorder;
            btnBack.Font = new Font("Bahnschrift SemiBold SemiConden", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.Location = new Point(1183, 562);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(205, 72);
            btnBack.TabIndex = 10;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnDeposite
            // 
            btnDeposite.BackColor = SystemColors.ActiveBorder;
            btnDeposite.Font = new Font("Bahnschrift SemiBold SemiConden", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeposite.Location = new Point(1183, 450);
            btnDeposite.Name = "btnDeposite";
            btnDeposite.Size = new Size(205, 72);
            btnDeposite.TabIndex = 9;
            btnDeposite.Text = "Deposite";
            btnDeposite.UseVisualStyleBackColor = false;
            btnDeposite.Click += btnDeposite_Click;
            // 
            // txtDepAmt
            // 
            txtDepAmt.Location = new Point(1023, 355);
            txtDepAmt.Name = "txtDepAmt";
            txtDepAmt.Size = new Size(214, 27);
            txtDepAmt.TabIndex = 8;
            txtDepAmt.TextChanged += txtDepAmt_TextChanged;
            // 
            // lbnAmtDep
            // 
            lbnAmtDep.AutoSize = true;
            lbnAmtDep.BackColor = Color.Transparent;
            lbnAmtDep.Font = new Font("Bahnschrift SemiBold SemiConden", 17.5F, FontStyle.Bold, GraphicsUnit.Point);
            lbnAmtDep.ForeColor = Color.Black;
            lbnAmtDep.Location = new Point(745, 345);
            lbnAmtDep.Name = "lbnAmtDep";
            lbnAmtDep.Size = new Size(183, 36);
            lbnAmtDep.TabIndex = 7;
            lbnAmtDep.Text = "Enter Amount ";
            lbnAmtDep.Click += lbnAmtDep_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Bahnschrift SemiBold SemiConden", 17.5F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(745, 239);
            label1.Name = "label1";
            label1.Size = new Size(147, 36);
            label1.TabIndex = 12;
            label1.Text = "Account No";
            label1.Click += label1_Click;
            // 
            // lbnacno
            // 
            lbnacno.AutoSize = true;
            lbnacno.BackColor = Color.Transparent;
            lbnacno.Font = new Font("Bahnschrift SemiBold SemiConden", 17.5F, FontStyle.Bold, GraphicsUnit.Point);
            lbnacno.ForeColor = Color.Black;
            lbnacno.Location = new Point(1069, 245);
            lbnacno.Name = "lbnacno";
            lbnacno.Size = new Size(71, 36);
            lbnacno.TabIndex = 15;
            lbnacno.Text = "acno";
            lbnacno.Click += lbnacno_Click;
            // 
            // DepositForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.deposit;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1500, 900);
            Controls.Add(lbnacno);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(btnBack);
            Controls.Add(btnDeposite);
            Controls.Add(txtDepAmt);
            Controls.Add(lbnAmtDep);
            Name = "DepositForm";
            Text = "DepositForm";
            Load += DepositForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtAccNo;
        private Label label2;
        private Button btnBack;
        private Button btnDeposite;
        private TextBox txtDepAmt;
        private Label lbnAmtDep;
        private Label label1;
        private Label lbnacno;
    }
}