namespace Form1
{
    partial class ChhechBookForm
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
            btnBcak = new Button();
            btnApply = new Button();
            addresstxt = new TextBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            acclabal = new Label();
            adharnotxt = new TextBox();
            label3 = new Label();
            Monotxt = new TextBox();
            AccTypecomboBox = new ComboBox();
            HNametxt = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Black", 26F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 0, 64);
            label1.Location = new Point(450, 31);
            label1.Name = "label1";
            label1.Size = new Size(585, 62);
            label1.TabIndex = 25;
            label1.Text = "CheckBook Application";
            // 
            // btnBcak
            // 
            btnBcak.BackColor = Color.DarkGray;
            btnBcak.Font = new Font("Bahnschrift SemiBold SemiConden", 19F, FontStyle.Bold, GraphicsUnit.Point);
            btnBcak.Location = new Point(797, 804);
            btnBcak.Name = "btnBcak";
            btnBcak.Size = new Size(196, 61);
            btnBcak.TabIndex = 24;
            btnBcak.Text = "Back";
            btnBcak.UseVisualStyleBackColor = false;
            btnBcak.Click += btnBcak_Click;
            // 
            // btnApply
            // 
            btnApply.BackColor = Color.DarkGray;
            btnApply.Font = new Font("Bahnschrift SemiBold SemiConden", 19F, FontStyle.Bold, GraphicsUnit.Point);
            btnApply.Location = new Point(514, 804);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(194, 61);
            btnApply.TabIndex = 23;
            btnApply.Text = "Apply";
            btnApply.UseVisualStyleBackColor = false;
            btnApply.Click += btnApply_Click;
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
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(acclabal);
            groupBox2.Controls.Add(addresstxt);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(adharnotxt);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(Monotxt);
            groupBox2.Controls.Add(AccTypecomboBox);
            groupBox2.Controls.Add(HNametxt);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(241, 156);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(993, 611);
            groupBox2.TabIndex = 43;
            groupBox2.TabStop = false;
            groupBox2.Enter += groupBox2_Enter;
            // 
            // acclabal
            // 
            acclabal.AutoSize = true;
            acclabal.Font = new Font("Bahnschrift SemiBold SemiConden", 17.5F, FontStyle.Bold, GraphicsUnit.Point);
            acclabal.Location = new Point(572, 67);
            acclabal.Name = "acclabal";
            acclabal.Size = new Size(88, 36);
            acclabal.TabIndex = 25;
            acclabal.Text = "AccNo";
            // 
            // adharnotxt
            // 
            adharnotxt.Location = new Point(555, 427);
            adharnotxt.Name = "adharnotxt";
            adharnotxt.Size = new Size(281, 27);
            adharnotxt.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift SemiBold SemiConden", 17.5F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(202, 417);
            label3.Name = "label3";
            label3.Size = new Size(239, 36);
            label3.TabIndex = 20;
            label3.Text = "AdharCard Number";
            // 
            // Monotxt
            // 
            Monotxt.AcceptsReturn = true;
            Monotxt.Location = new Point(555, 340);
            Monotxt.Name = "Monotxt";
            Monotxt.Size = new Size(281, 27);
            Monotxt.TabIndex = 17;
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
            // HNametxt
            // 
            HNametxt.Location = new Point(555, 160);
            HNametxt.Name = "HNametxt";
            HNametxt.Size = new Size(281, 27);
            HNametxt.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift SemiBold SemiConden", 17.5F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(202, 330);
            label4.Name = "label4";
            label4.Size = new Size(191, 36);
            label4.TabIndex = 13;
            label4.Text = "Mobile Number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift SemiBold SemiConden", 17.5F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(202, 241);
            label5.Name = "label5";
            label5.Size = new Size(168, 36);
            label5.TabIndex = 12;
            label5.Text = "Account Type";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift SemiBold SemiConden", 17.5F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(202, 150);
            label6.Name = "label6";
            label6.Size = new Size(194, 36);
            label6.TabIndex = 11;
            label6.Text = "Account Holder";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bahnschrift SemiBold SemiConden", 17.5F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(203, 56);
            label7.Name = "label7";
            label7.Size = new Size(157, 36);
            label7.TabIndex = 10;
            label7.Text = "A/C Number";
            // 
            // ChhechBookForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.CheckBook;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1500, 900);
            Controls.Add(groupBox2);
            Controls.Add(btnApply);
            Controls.Add(btnBcak);
            Controls.Add(label1);
            Name = "ChhechBookForm";
            Text = "ChhechBookForm";
            Load += ChhechBookForm_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button btnBcak;
        private Button btnApply;
        private TextBox addresstxt;
        private Label label2;
        private GroupBox groupBox2;
        private TextBox adharnotxt;
        private Label label3;
        private TextBox Monotxt;
        private ComboBox AccTypecomboBox;
        private TextBox HNametxt;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label acclabal;
    }
}