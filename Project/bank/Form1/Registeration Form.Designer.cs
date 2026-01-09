namespace Form1
{
    partial class Registeration_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registeration_Form));
            txtPhone = new TextBox();
            txtLname = new TextBox();
            label7 = new Label();
            txtIncome = new TextBox();
            label6 = new Label();
            txtAddress = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtGender = new TextBox();
            btnSave = new Button();
            txtAName = new TextBox();
            label1 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtpassword = new TextBox();
            txtedu = new TextBox();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point);
            txtPhone.Location = new Point(566, 488);
            txtPhone.MaxLength = 10;
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(217, 34);
            txtPhone.TabIndex = 36;
            txtPhone.TextChanged += txtPhone_TextChanged;
            // 
            // txtLname
            // 
            txtLname.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point);
            txtLname.Location = new Point(566, 378);
            txtLname.Name = "txtLname";
            txtLname.Size = new Size(217, 34);
            txtLname.TabIndex = 35;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 28F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(0, 0, 64);
            label7.Location = new Point(503, 116);
            label7.Name = "label7";
            label7.Size = new Size(643, 53);
            label7.TabIndex = 33;
            label7.Text = "Registeration for New Account";
            // 
            // txtIncome
            // 
            txtIncome.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point);
            txtIncome.Location = new Point(1069, 488);
            txtIncome.Name = "txtIncome";
            txtIncome.Size = new Size(217, 34);
            txtIncome.TabIndex = 32;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 17F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(889, 598);
            label6.Name = "label6";
            label6.Size = new Size(130, 32);
            label6.TabIndex = 31;
            label6.Text = "Password";
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point);
            txtAddress.Location = new Point(566, 601);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(223, 95);
            txtAddress.TabIndex = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 17F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(369, 598);
            label5.Name = "label5";
            label5.Size = new Size(112, 32);
            label5.TabIndex = 29;
            label5.Text = "Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 17F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(886, 272);
            label4.Name = "label4";
            label4.Size = new Size(106, 32);
            label4.TabIndex = 28;
            label4.Text = "Gender";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 17F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(889, 375);
            label3.Name = "label3";
            label3.Size = new Size(140, 32);
            label3.TabIndex = 27;
            label3.Text = "Education";
            // 
            // txtGender
            // 
            txtGender.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point);
            txtGender.Location = new Point(1069, 275);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(217, 34);
            txtGender.TabIndex = 26;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.DarkGray;
            btnSave.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Location = new Point(439, 761);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(242, 71);
            btnSave.TabIndex = 23;
            btnSave.Text = "Submit";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtAName
            // 
            txtAName.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point);
            txtAName.Location = new Point(566, 275);
            txtAName.Name = "txtAName";
            txtAName.Size = new Size(217, 34);
            txtAName.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 17F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(369, 272);
            label1.Name = "label1";
            label1.Size = new Size(152, 32);
            label1.TabIndex = 21;
            label1.Text = "First Name";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 17F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(369, 375);
            label8.Name = "label8";
            label8.Size = new Size(147, 32);
            label8.TabIndex = 37;
            label8.Text = "Last Name";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 17F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(369, 485);
            label9.Name = "label9";
            label9.Size = new Size(133, 32);
            label9.TabIndex = 38;
            label9.Text = "Phone No";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 17F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(889, 485);
            label10.Name = "label10";
            label10.Size = new Size(104, 32);
            label10.TabIndex = 40;
            label10.Text = "Income";
            // 
            // txtpassword
            // 
            txtpassword.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point);
            txtpassword.Location = new Point(1069, 601);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(217, 34);
            txtpassword.TabIndex = 43;
            // 
            // txtedu
            // 
            txtedu.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point);
            txtedu.Location = new Point(1069, 378);
            txtedu.Name = "txtedu";
            txtedu.Size = new Size(217, 34);
            txtedu.TabIndex = 44;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, -2);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(281, 264);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 50;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGray;
            button1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(1030, 761);
            button1.Name = "button1";
            button1.Size = new Size(242, 71);
            button1.TabIndex = 51;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkGray;
            button2.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(722, 761);
            button2.Name = "button2";
            button2.Size = new Size(242, 71);
            button2.TabIndex = 52;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Registeration_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1500, 900);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(txtedu);
            Controls.Add(txtpassword);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(txtPhone);
            Controls.Add(txtLname);
            Controls.Add(label7);
            Controls.Add(txtIncome);
            Controls.Add(label6);
            Controls.Add(txtAddress);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtGender);
            Controls.Add(btnSave);
            Controls.Add(txtAName);
            Controls.Add(label1);
            Name = "Registeration_Form";
            Text = "Registeration_Form";
            Load += Registeration_Form_Load;
            KeyPress += Registeration_Form_KeyPress;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPhone;
        private TextBox txtLname;
        private Label label7;
        private TextBox txtIncome;
        private Label label6;
        private TextBox txtAddress;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtGender;
        private Button btnSave;
        private TextBox txtAName;
        private Label label1;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txtpassword;
        private TextBox txtedu;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
    }
}