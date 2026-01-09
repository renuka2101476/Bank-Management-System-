namespace Form1
{
    partial class HomeLoan
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
            label9 = new Label();
            txtaddress = new TextBox();
            txtcontno = new TextBox();
            label8 = new Label();
            label7 = new Label();
            txtadharno = new TextBox();
            txtHname = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            label10 = new Label();
            accn = new Label();
            txtLduration = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Arial Narrow", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(40, 732);
            label9.Name = "label9";
            label9.Size = new Size(270, 29);
            label9.TabIndex = 40;
            label9.Text = "Note : Rate Of Intrest is 7%.";
            // 
            // txtaddress
            // 
            txtaddress.Location = new Point(348, 334);
            txtaddress.Multiline = true;
            txtaddress.Name = "txtaddress";
            txtaddress.Size = new Size(236, 60);
            txtaddress.TabIndex = 39;
            // 
            // txtcontno
            // 
            txtcontno.Location = new Point(348, 261);
            txtcontno.Name = "txtcontno";
            txtcontno.Size = new Size(236, 27);
            txtcontno.TabIndex = 38;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Bahnschrift SemiBold SemiConden", 17.5F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(66, 325);
            label8.Name = "label8";
            label8.Size = new Size(110, 36);
            label8.TabIndex = 37;
            label8.Text = "Address";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Bahnschrift SemiBold SemiConden", 17.5F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(66, 252);
            label7.Name = "label7";
            label7.Size = new Size(143, 36);
            label7.TabIndex = 36;
            label7.Text = "Contact No";
            // 
            // txtadharno
            // 
            txtadharno.Location = new Point(348, 517);
            txtadharno.Name = "txtadharno";
            txtadharno.Size = new Size(236, 27);
            txtadharno.TabIndex = 32;
            // 
            // txtHname
            // 
            txtHname.Location = new Point(348, 177);
            txtHname.Name = "txtHname";
            txtHname.Size = new Size(236, 27);
            txtHname.TabIndex = 29;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Bahnschrift SemiBold SemiConden", 17.5F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(66, 508);
            label4.Name = "label4";
            label4.Size = new Size(178, 36);
            label4.TabIndex = 27;
            label4.Text = "AdharCard No";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Bahnschrift SemiBold SemiConden", 17.5F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(66, 424);
            label3.Name = "label3";
            label3.Size = new Size(179, 36);
            label3.TabIndex = 26;
            label3.Text = "Loan Duration";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Bahnschrift SemiBold SemiConden", 17.5F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(66, 87);
            label2.Name = "label2";
            label2.Size = new Size(103, 36);
            label2.TabIndex = 25;
            label2.Text = "A/C  No";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Bahnschrift SemiBold SemiConden", 17.5F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(66, 168);
            label1.Name = "label1";
            label1.Size = new Size(217, 36);
            label1.TabIndex = 24;
            label1.Text = "A/C Holder Name";
            // 
            // button2
            // 
            button2.BackColor = Color.DarkGray;
            button2.Font = new Font("Bahnschrift SemiBold SemiConden", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(327, 605);
            button2.Name = "button2";
            button2.Size = new Size(209, 62);
            button2.TabIndex = 23;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGray;
            button1.Font = new Font("Bahnschrift SemiBold SemiConden", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(74, 605);
            button1.Name = "button1";
            button1.Size = new Size(209, 62);
            button1.TabIndex = 22;
            button1.Text = "Apply";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(952, 9);
            label10.Name = "label10";
            label10.Size = new Size(289, 60);
            label10.TabIndex = 41;
            label10.Text = "HOME LOAN";
            // 
            // accn
            // 
            accn.AutoSize = true;
            accn.BackColor = Color.Transparent;
            accn.Font = new Font("Bahnschrift SemiBold SemiConden", 14F, FontStyle.Bold, GraphicsUnit.Point);
            accn.Location = new Point(403, 87);
            accn.Name = "accn";
            accn.Size = new Size(84, 29);
            accn.TabIndex = 42;
            accn.Text = "A/C  No";
            // 
            // txtLduration
            // 
            txtLduration.Location = new Point(348, 433);
            txtLduration.Name = "txtLduration";
            txtLduration.Size = new Size(139, 27);
            txtLduration.TabIndex = 31;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Bahnschrift SemiBold SemiConden", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(511, 433);
            label5.Name = "label5";
            label5.Size = new Size(53, 29);
            label5.TabIndex = 65;
            label5.Text = "Year";
            // 
            // HomeLoan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImage = Properties.Resources.Home_Loan;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1482, 933);
            Controls.Add(label5);
            Controls.Add(accn);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(txtaddress);
            Controls.Add(txtcontno);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtadharno);
            Controls.Add(txtLduration);
            Controls.Add(txtHname);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "HomeLoan";
            Text = "HomeLoan";
            Load += HomeLoan_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label9;
        private TextBox txtaddress;
        private TextBox txtcontno;
        private Label label8;
        private Label label7;
        private TextBox txtadharno;
        private TextBox txtHname;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button2;
        private Button button1;
        private Label label10;
        private Label accn;
        private TextBox txtLduration;
        private Label label5;
    }
}