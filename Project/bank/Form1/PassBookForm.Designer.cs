namespace Form1
{
    partial class PassBookForm
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
            label1 = new Label();
            btnApply = new Button();
            btnBcak = new Button();
            groupBox1 = new GroupBox();
            accno = new Label();
            addresstxt = new TextBox();
            label2 = new Label();
            PanNotxt = new TextBox();
            lbnPanNo = new Label();
            MoNotxt = new TextBox();
            AccTypecomboBox = new ComboBox();
            AccHNametxt = new TextBox();
            lbnMobileNO = new Label();
            lbnACtype = new Label();
            lbnHOlder = new Label();
            lbnAcno = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Black", 28F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 0, 64);
            label1.Location = new Point(463, 34);
            label1.Name = "label1";
            label1.Size = new Size(599, 67);
            label1.TabIndex = 41;
            label1.Text = "Passbook  Application";
            label1.Click += label1_Click;
            // 
            // btnApply
            // 
            btnApply.BackColor = Color.DarkGray;
            btnApply.Font = new Font("Bahnschrift SemiBold SemiConden", 19F, FontStyle.Bold, GraphicsUnit.Point);
            btnApply.Location = new Point(491, 789);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(194, 61);
            btnApply.TabIndex = 43;
            btnApply.Text = "Apply";
            btnApply.UseVisualStyleBackColor = false;
            btnApply.Click += btnApply_Click;
            // 
            // btnBcak
            // 
            btnBcak.BackColor = Color.DarkGray;
            btnBcak.Font = new Font("Bahnschrift SemiBold SemiConden", 19F, FontStyle.Bold, GraphicsUnit.Point);
            btnBcak.Location = new Point(825, 789);
            btnBcak.Name = "btnBcak";
            btnBcak.Size = new Size(196, 61);
            btnBcak.TabIndex = 44;
            btnBcak.Text = "Back";
            btnBcak.UseVisualStyleBackColor = false;
            btnBcak.Click += btnBcak_Click_1;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(accno);
            groupBox1.Controls.Add(addresstxt);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(PanNotxt);
            groupBox1.Controls.Add(lbnPanNo);
            groupBox1.Controls.Add(MoNotxt);
            groupBox1.Controls.Add(AccTypecomboBox);
            groupBox1.Controls.Add(AccHNametxt);
            groupBox1.Controls.Add(lbnMobileNO);
            groupBox1.Controls.Add(lbnACtype);
            groupBox1.Controls.Add(lbnHOlder);
            groupBox1.Controls.Add(lbnAcno);
            groupBox1.Location = new Point(238, 122);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1019, 619);
            groupBox1.TabIndex = 42;
            groupBox1.TabStop = false;
            // 
            // accno
            // 
            accno.AutoSize = true;
            accno.Font = new Font("Bahnschrift SemiBold SemiConden", 17.5F, FontStyle.Bold, GraphicsUnit.Point);
            accno.Location = new Point(587, 56);
            accno.Name = "accno";
            accno.Size = new Size(90, 36);
            accno.TabIndex = 25;
            accno.Text = "AccNO";
            // 
            // addresstxt
            // 
            addresstxt.Location = new Point(556, 501);
            addresstxt.Multiline = true;
            addresstxt.Name = "addresstxt";
            addresstxt.Size = new Size(281, 74);
            addresstxt.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiBold SemiConden", 17.5F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(203, 491);
            label2.Name = "label2";
            label2.Size = new Size(110, 36);
            label2.TabIndex = 23;
            label2.Text = "Address";
            // 
            // PanNotxt
            // 
            PanNotxt.Location = new Point(555, 427);
            PanNotxt.Name = "PanNotxt";
            PanNotxt.Size = new Size(281, 27);
            PanNotxt.TabIndex = 22;
            // 
            // lbnPanNo
            // 
            lbnPanNo.AutoSize = true;
            lbnPanNo.Font = new Font("Bahnschrift SemiBold SemiConden", 17.5F, FontStyle.Bold, GraphicsUnit.Point);
            lbnPanNo.Location = new Point(202, 417);
            lbnPanNo.Name = "lbnPanNo";
            lbnPanNo.Size = new Size(236, 36);
            lbnPanNo.TabIndex = 20;
            lbnPanNo.Text = "Adharcard Number";
            // 
            // MoNotxt
            // 
            MoNotxt.Location = new Point(555, 340);
            MoNotxt.Name = "MoNotxt";
            MoNotxt.Size = new Size(281, 27);
            MoNotxt.TabIndex = 17;
            // 
            // AccTypecomboBox
            // 
            AccTypecomboBox.FormattingEnabled = true;
            AccTypecomboBox.Items.AddRange(new object[] { "Saving Account", "Current Account" });
            AccTypecomboBox.Location = new Point(555, 251);
            AccTypecomboBox.Name = "AccTypecomboBox";
            AccTypecomboBox.Size = new Size(281, 28);
            AccTypecomboBox.TabIndex = 16;
            // 
            // AccHNametxt
            // 
            AccHNametxt.Location = new Point(555, 160);
            AccHNametxt.Name = "AccHNametxt";
            AccHNametxt.Size = new Size(281, 27);
            AccHNametxt.TabIndex = 15;
            // 
            // lbnMobileNO
            // 
            lbnMobileNO.AutoSize = true;
            lbnMobileNO.Font = new Font("Bahnschrift SemiBold SemiConden", 17.5F, FontStyle.Bold, GraphicsUnit.Point);
            lbnMobileNO.Location = new Point(202, 330);
            lbnMobileNO.Name = "lbnMobileNO";
            lbnMobileNO.Size = new Size(191, 36);
            lbnMobileNO.TabIndex = 13;
            lbnMobileNO.Text = "Mobile Number";
            // 
            // lbnACtype
            // 
            lbnACtype.AutoSize = true;
            lbnACtype.Font = new Font("Bahnschrift SemiBold SemiConden", 17.5F, FontStyle.Bold, GraphicsUnit.Point);
            lbnACtype.Location = new Point(202, 241);
            lbnACtype.Name = "lbnACtype";
            lbnACtype.Size = new Size(168, 36);
            lbnACtype.TabIndex = 12;
            lbnACtype.Text = "Account Type";
            // 
            // lbnHOlder
            // 
            lbnHOlder.AutoSize = true;
            lbnHOlder.Font = new Font("Bahnschrift SemiBold SemiConden", 17.5F, FontStyle.Bold, GraphicsUnit.Point);
            lbnHOlder.Location = new Point(202, 150);
            lbnHOlder.Name = "lbnHOlder";
            lbnHOlder.Size = new Size(194, 36);
            lbnHOlder.TabIndex = 11;
            lbnHOlder.Text = "Account Holder";
            // 
            // lbnAcno
            // 
            lbnAcno.AutoSize = true;
            lbnAcno.Font = new Font("Bahnschrift SemiBold SemiConden", 17.5F, FontStyle.Bold, GraphicsUnit.Point);
            lbnAcno.Location = new Point(203, 56);
            lbnAcno.Name = "lbnAcno";
            lbnAcno.Size = new Size(157, 36);
            lbnAcno.TabIndex = 10;
            lbnAcno.Text = "A/C Number";
            // 
            // PassBookForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Passbook;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1500, 900);
            Controls.Add(btnApply);
            Controls.Add(btnBcak);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "PassBookForm";
            Text = "PassBookForm";
            Load += PassBookForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button btnApply;
        private Button btnBcak;
        private GroupBox groupBox1;
        private TextBox PanNotxt;
        private Label lbnPanNo;
        private TextBox MoNotxt;
        private ComboBox AccTypecomboBox;
        private TextBox AccHNametxt;
        private Label lbnMobileNO;
        private Label lbnACtype;
        private Label lbnHOlder;
        private Label lbnAcno;
        private TextBox addresstxt;
        private Label label2;
        private Label accno;
    }
}