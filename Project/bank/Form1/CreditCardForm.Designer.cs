namespace Form1
{
    partial class CreditCardForm
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
            btnBcak = new Button();
            btnApply = new Button();
            groupBox2 = new GroupBox();
            acclabal = new Label();
            addresstxt = new TextBox();
            label2 = new Label();
            Monotxt = new TextBox();
            AccTypecomboBox = new ComboBox();
            HNametxt = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label1 = new Label();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnBcak
            // 
            btnBcak.BackColor = Color.DarkGray;
            btnBcak.Font = new Font("Bahnschrift SemiBold SemiConden", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnBcak.Location = new Point(1022, 714);
            btnBcak.Name = "btnBcak";
            btnBcak.Size = new Size(155, 61);
            btnBcak.TabIndex = 49;
            btnBcak.Text = "Back";
            btnBcak.UseVisualStyleBackColor = false;
            btnBcak.Click += btnBcak_Click;
            // 
            // btnApply
            // 
            btnApply.BackColor = Color.DarkGray;
            btnApply.Font = new Font("Bahnschrift SemiBold SemiConden", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnApply.Location = new Point(747, 714);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(155, 61);
            btnApply.TabIndex = 48;
            btnApply.Text = "Apply";
            btnApply.UseVisualStyleBackColor = false;
            btnApply.Click += btnApply_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(acclabal);
            groupBox2.Controls.Add(addresstxt);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(Monotxt);
            groupBox2.Controls.Add(AccTypecomboBox);
            groupBox2.Controls.Add(HNametxt);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(536, 89);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(811, 571);
            groupBox2.TabIndex = 47;
            groupBox2.TabStop = false;
            // 
            // acclabal
            // 
            acclabal.AutoSize = true;
            acclabal.Font = new Font("Bahnschrift SemiBold SemiConden", 17.5F, FontStyle.Bold, GraphicsUnit.Point);
            acclabal.Location = new Point(531, 58);
            acclabal.Name = "acclabal";
            acclabal.Size = new Size(88, 36);
            acclabal.TabIndex = 25;
            acclabal.Text = "AccNo";
            // 
            // addresstxt
            // 
            addresstxt.Location = new Point(439, 429);
            addresstxt.Multiline = true;
            addresstxt.Name = "addresstxt";
            addresstxt.Size = new Size(281, 74);
            addresstxt.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiBold SemiConden", 17.5F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(86, 419);
            label2.Name = "label2";
            label2.Size = new Size(110, 36);
            label2.TabIndex = 23;
            label2.Text = "Address";
            // 
            // Monotxt
            // 
            Monotxt.AcceptsReturn = true;
            Monotxt.Location = new Point(439, 342);
            Monotxt.Name = "Monotxt";
            Monotxt.Size = new Size(281, 27);
            Monotxt.TabIndex = 17;
            // 
            // AccTypecomboBox
            // 
            AccTypecomboBox.FormattingEnabled = true;
            AccTypecomboBox.Items.AddRange(new object[] { "Saving Account", "Current Account" });
            AccTypecomboBox.Location = new Point(439, 253);
            AccTypecomboBox.Name = "AccTypecomboBox";
            AccTypecomboBox.Size = new Size(281, 28);
            AccTypecomboBox.TabIndex = 16;
            // 
            // HNametxt
            // 
            HNametxt.Location = new Point(439, 162);
            HNametxt.Name = "HNametxt";
            HNametxt.Size = new Size(281, 27);
            HNametxt.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift SemiBold SemiConden", 17.5F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(86, 332);
            label4.Name = "label4";
            label4.Size = new Size(191, 36);
            label4.TabIndex = 13;
            label4.Text = "Mobile Number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift SemiBold SemiConden", 17.5F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(86, 243);
            label5.Name = "label5";
            label5.Size = new Size(168, 36);
            label5.TabIndex = 12;
            label5.Text = "Account Type";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift SemiBold SemiConden", 17.5F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(86, 152);
            label6.Name = "label6";
            label6.Size = new Size(194, 36);
            label6.TabIndex = 11;
            label6.Text = "Account Holder";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bahnschrift SemiBold SemiConden", 17.5F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(87, 58);
            label7.Name = "label7";
            label7.Size = new Size(157, 36);
            label7.TabIndex = 10;
            label7.Text = "A/C Number";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(97, 50);
            label1.Name = "label1";
            label1.Size = new Size(372, 40);
            label1.TabIndex = 50;
            label1.Text = "Apply For Credit Card";
            // 
            // CreditCardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Atm1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1382, 853);
            Controls.Add(label1);
            Controls.Add(btnBcak);
            Controls.Add(btnApply);
            Controls.Add(groupBox2);
            Name = "CreditCardForm";
            Text = "CreditCardForm";
            Load += CreditCardForm_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBcak;
        private Button btnApply;
        private GroupBox groupBox2;
        private Label acclabal;
        private TextBox addresstxt;
        private Label label2;
        private TextBox Monotxt;
        private ComboBox AccTypecomboBox;
        private TextBox HNametxt;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label1;
    }
}