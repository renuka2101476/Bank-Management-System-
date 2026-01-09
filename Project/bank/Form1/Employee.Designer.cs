namespace Form1
{
    partial class Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label9 = new Label();
            txtEPhone = new TextBox();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            txtSalary = new TextBox();
            txtEName = new TextBox();
            label1 = new Label();
            btnSearach = new Button();
            insertbtn = new Button();
            txtDesignation = new TextBox();
            label2 = new Label();
            addresstxt = new TextBox();
            backbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGray;
            button1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(839, 685);
            button1.Name = "button1";
            button1.Size = new Size(169, 71);
            button1.TabIndex = 71;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2, 1);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(248, 217);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 70;
            pictureBox1.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 17F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(502, 292);
            label9.Name = "label9";
            label9.Size = new Size(133, 32);
            label9.TabIndex = 66;
            label9.Text = "Phone No";
            // 
            // txtEPhone
            // 
            txtEPhone.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point);
            txtEPhone.Location = new Point(792, 295);
            txtEPhone.MaxLength = 10;
            txtEPhone.Name = "txtEPhone";
            txtEPhone.Size = new Size(250, 34);
            txtEPhone.TabIndex = 64;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 28F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(0, 0, 64);
            label7.Location = new Point(515, 80);
            label7.Name = "label7";
            label7.Size = new Size(510, 53);
            label7.TabIndex = 62;
            label7.Text = "Employee Management ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 17F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(502, 379);
            label5.Name = "label5";
            label5.Size = new Size(160, 32);
            label5.TabIndex = 58;
            label5.Text = "Designation";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 17F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(502, 465);
            label4.Name = "label4";
            label4.Size = new Size(92, 32);
            label4.TabIndex = 57;
            label4.Text = "Salary";
            // 
            // txtSalary
            // 
            txtSalary.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point);
            txtSalary.Location = new Point(792, 468);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(250, 34);
            txtSalary.TabIndex = 55;
            // 
            // txtEName
            // 
            txtEName.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point);
            txtEName.Location = new Point(787, 203);
            txtEName.Name = "txtEName";
            txtEName.Size = new Size(250, 34);
            txtEName.TabIndex = 53;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 17F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(497, 200);
            label1.Name = "label1";
            label1.Size = new Size(214, 32);
            label1.TabIndex = 52;
            label1.Text = "Employee Name";
            // 
            // btnSearach
            // 
            btnSearach.BackColor = Color.DarkGray;
            btnSearach.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearach.Location = new Point(576, 685);
            btnSearach.Name = "btnSearach";
            btnSearach.Size = new Size(169, 71);
            btnSearach.TabIndex = 73;
            btnSearach.Text = "Search";
            btnSearach.UseVisualStyleBackColor = false;
            btnSearach.Click += btnSearach_Click;
            // 
            // insertbtn
            // 
            insertbtn.BackColor = Color.DarkGray;
            insertbtn.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            insertbtn.Location = new Point(316, 685);
            insertbtn.Name = "insertbtn";
            insertbtn.Size = new Size(169, 71);
            insertbtn.TabIndex = 72;
            insertbtn.Text = "Insert";
            insertbtn.UseVisualStyleBackColor = false;
            insertbtn.Click += button3_Click;
            // 
            // txtDesignation
            // 
            txtDesignation.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point);
            txtDesignation.Location = new Point(792, 382);
            txtDesignation.Name = "txtDesignation";
            txtDesignation.Size = new Size(250, 34);
            txtDesignation.TabIndex = 74;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 17F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(502, 553);
            label2.Name = "label2";
            label2.Size = new Size(112, 32);
            label2.TabIndex = 76;
            label2.Text = "Address";
            // 
            // addresstxt
            // 
            addresstxt.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point);
            addresstxt.Location = new Point(792, 556);
            addresstxt.Name = "addresstxt";
            addresstxt.Size = new Size(250, 34);
            addresstxt.TabIndex = 75;
            // 
            // backbtn
            // 
            backbtn.BackColor = Color.DarkGray;
            backbtn.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            backbtn.Location = new Point(1104, 685);
            backbtn.Name = "backbtn";
            backbtn.Size = new Size(169, 71);
            backbtn.TabIndex = 77;
            backbtn.Text = "Back";
            backbtn.UseVisualStyleBackColor = false;
            backbtn.Click += backbtn_Click;
            // 
            // Employee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1382, 853);
            Controls.Add(backbtn);
            Controls.Add(label2);
            Controls.Add(addresstxt);
            Controls.Add(txtDesignation);
            Controls.Add(btnSearach);
            Controls.Add(insertbtn);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(label9);
            Controls.Add(txtEPhone);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtSalary);
            Controls.Add(txtEName);
            Controls.Add(label1);
            Name = "Employee";
            Text = "Employee";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private PictureBox pictureBox1;
        private Label label9;
        private TextBox txtEPhone;
        private Label label7;
        private Label label5;
        private Label label4;
        private TextBox txtSalary;
        private TextBox txtEName;
        private Label label1;
        private Button btnSearach;
        private Button insertbtn;
        private TextBox txtDesignation;
        private Label label2;
        private TextBox addresstxt;
        private Button backbtn;
    }
}