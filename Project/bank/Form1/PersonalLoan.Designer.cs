namespace Form1
{
    partial class PersonalLoan
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
            label11 = new Label();
            label9 = new Label();
            addresstxt = new TextBox();
            connotxt = new TextBox();
            label8 = new Label();
            label7 = new Label();
            adharnotxt = new TextBox();
            Ldurationtxt = new TextBox();
            hnametxt = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button2 = new Button();
            button3 = new Button();
            labaccno = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(936, 154);
            label11.Name = "label11";
            label11.Size = new Size(346, 54);
            label11.TabIndex = 42;
            label11.Text = "PERSONAL LOAN";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Arial Narrow", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(57, 769);
            label9.Name = "label9";
            label9.Size = new Size(270, 29);
            label9.TabIndex = 61;
            label9.Text = "Note : Rate Of Intrest is 7%.";
            // 
            // addresstxt
            // 
            addresstxt.Location = new Point(390, 361);
            addresstxt.Multiline = true;
            addresstxt.Name = "addresstxt";
            addresstxt.Size = new Size(236, 60);
            addresstxt.TabIndex = 60;
            // 
            // connotxt
            // 
            connotxt.Location = new Point(390, 288);
            connotxt.Name = "connotxt";
            connotxt.Size = new Size(236, 27);
            connotxt.TabIndex = 59;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Bahnschrift SemiBold SemiConden", 17.5F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(85, 351);
            label8.Name = "label8";
            label8.Size = new Size(110, 36);
            label8.TabIndex = 58;
            label8.Text = "Address";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Bahnschrift SemiBold SemiConden", 17.5F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(85, 278);
            label7.Name = "label7";
            label7.Size = new Size(143, 36);
            label7.TabIndex = 57;
            label7.Text = "Contact No";
            // 
            // adharnotxt
            // 
            adharnotxt.Location = new Point(390, 544);
            adharnotxt.Name = "adharnotxt";
            adharnotxt.Size = new Size(236, 27);
            adharnotxt.TabIndex = 53;
            // 
            // Ldurationtxt
            // 
            Ldurationtxt.Location = new Point(390, 460);
            Ldurationtxt.Name = "Ldurationtxt";
            Ldurationtxt.Size = new Size(117, 27);
            Ldurationtxt.TabIndex = 52;
            // 
            // hnametxt
            // 
            hnametxt.Location = new Point(390, 206);
            hnametxt.Name = "hnametxt";
            hnametxt.Size = new Size(236, 27);
            hnametxt.TabIndex = 50;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Bahnschrift SemiBold SemiConden", 17.5F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(85, 534);
            label4.Name = "label4";
            label4.Size = new Size(178, 36);
            label4.TabIndex = 48;
            label4.Text = "AdharCard No";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Bahnschrift SemiBold SemiConden", 17.5F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(85, 450);
            label3.Name = "label3";
            label3.Size = new Size(179, 36);
            label3.TabIndex = 47;
            label3.Text = "Loan Duration";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Bahnschrift SemiBold SemiConden", 17.5F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(85, 115);
            label2.Name = "label2";
            label2.Size = new Size(103, 36);
            label2.TabIndex = 46;
            label2.Text = "A/C  No";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Bahnschrift SemiBold SemiConden", 17.5F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(85, 196);
            label1.Name = "label1";
            label1.Size = new Size(217, 36);
            label1.TabIndex = 45;
            label1.Text = "A/C Holder Name";
            // 
            // button2
            // 
            button2.BackColor = Color.DarkGray;
            button2.Font = new Font("Bahnschrift SemiBold SemiConden", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(383, 651);
            button2.Name = "button2";
            button2.Size = new Size(209, 62);
            button2.TabIndex = 44;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkGray;
            button3.Font = new Font("Bahnschrift SemiBold SemiConden", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(118, 651);
            button3.Name = "button3";
            button3.Size = new Size(209, 62);
            button3.TabIndex = 43;
            button3.Text = "Apply";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // labaccno
            // 
            labaccno.AutoSize = true;
            labaccno.BackColor = Color.Transparent;
            labaccno.Font = new Font("Bahnschrift SemiBold SemiConden", 14F, FontStyle.Bold, GraphicsUnit.Point);
            labaccno.Location = new Point(453, 122);
            labaccno.Name = "labaccno";
            labaccno.Size = new Size(84, 29);
            labaccno.TabIndex = 62;
            labaccno.Text = "A/C  No";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Bahnschrift SemiBold SemiConden", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(539, 460);
            label5.Name = "label5";
            label5.Size = new Size(53, 29);
            label5.TabIndex = 63;
            label5.Text = "Year";
            // 
            // PersonalLoan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImage = Properties.Resources.Personal_Loan;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1500, 900);
            Controls.Add(label5);
            Controls.Add(labaccno);
            Controls.Add(label9);
            Controls.Add(addresstxt);
            Controls.Add(connotxt);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(adharnotxt);
            Controls.Add(Ldurationtxt);
            Controls.Add(hnametxt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(label11);
            Name = "PersonalLoan";
            Text = "PersonalLoan";
            Load += PersonalLoan_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label11;
        private Label label9;
        private TextBox addresstxt;
        private TextBox connotxt;
        private Label label8;
        private Label label7;
        private TextBox adharnotxt;
        private TextBox Ldurationtxt;
        private TextBox hnametxt;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button2;
        private Button button3;
        private Label labaccno;
        private Label label5;
    }
}