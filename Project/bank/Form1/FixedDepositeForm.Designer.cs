namespace Form1
{
    partial class FixedDepositeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FixedDepositeForm));
            button1 = new Button();
            txtAmt = new TextBox();
            lbnDate = new Label();
            lbnAmt = new Label();
            txtName = new TextBox();
            lbnName = new Label();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            lbn = new Label();
            button2 = new Button();
            lbnrate = new Label();
            lbnROI = new Label();
            label2 = new Label();
            txtDuration = new TextBox();
            label1 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGray;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(248, 653);
            button1.Name = "button1";
            button1.Size = new Size(182, 77);
            button1.TabIndex = 11;
            button1.Text = "Apply";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtAmt
            // 
            txtAmt.Font = new Font("Segoe Condensed", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtAmt.Location = new Point(490, 353);
            txtAmt.Name = "txtAmt";
            txtAmt.Size = new Size(279, 35);
            txtAmt.TabIndex = 10;
            // 
            // lbnDate
            // 
            lbnDate.AutoSize = true;
            lbnDate.BackColor = Color.Transparent;
            lbnDate.Font = new Font("Times New Roman", 17.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbnDate.Location = new Point(158, 419);
            lbnDate.Name = "lbnDate";
            lbnDate.Size = new Size(74, 35);
            lbnDate.TabIndex = 8;
            lbnDate.Text = "Date";
            // 
            // lbnAmt
            // 
            lbnAmt.AutoSize = true;
            lbnAmt.BackColor = Color.Transparent;
            lbnAmt.Font = new Font("Times New Roman", 17.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbnAmt.Location = new Point(158, 341);
            lbnAmt.Name = "lbnAmt";
            lbnAmt.Size = new Size(117, 35);
            lbnAmt.TabIndex = 7;
            lbnAmt.Text = "Amount";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe Condensed", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(490, 272);
            txtName.Name = "txtName";
            txtName.Size = new Size(279, 35);
            txtName.TabIndex = 14;
            // 
            // lbnName
            // 
            lbnName.AutoSize = true;
            lbnName.BackColor = Color.Transparent;
            lbnName.Font = new Font("Times New Roman", 17.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbnName.Location = new Point(158, 260);
            lbnName.Name = "lbnName";
            lbnName.Size = new Size(88, 35);
            lbnName.TabIndex = 13;
            lbnName.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Times New Roman", 17.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(158, 179);
            label4.Name = "label4";
            label4.Size = new Size(164, 35);
            label4.TabIndex = 12;
            label4.Text = "Account No";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe Condensed", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(490, 429);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(279, 35);
            dateTimePicker1.TabIndex = 18;
            // 
            // lbn
            // 
            lbn.AutoSize = true;
            lbn.BackColor = Color.Transparent;
            lbn.Font = new Font("Segoe Condensed", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbn.Location = new Point(572, 186);
            lbn.Name = "lbn";
            lbn.Size = new Size(63, 26);
            lbn.TabIndex = 20;
            lbn.Text = "label2";
            // 
            // button2
            // 
            button2.BackColor = Color.DarkGray;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(517, 653);
            button2.Name = "button2";
            button2.Size = new Size(182, 77);
            button2.TabIndex = 23;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // lbnrate
            // 
            lbnrate.AutoSize = true;
            lbnrate.BackColor = Color.Transparent;
            lbnrate.Font = new Font("Segoe Condensed", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbnrate.Location = new Point(565, 579);
            lbnrate.Name = "lbnrate";
            lbnrate.Size = new Size(48, 33);
            lbnrate.TabIndex = 25;
            lbnrate.Text = "3.5";
            // 
            // lbnROI
            // 
            lbnROI.AutoSize = true;
            lbnROI.BackColor = Color.Transparent;
            lbnROI.Font = new Font("Times New Roman", 17.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbnROI.Location = new Point(158, 576);
            lbnROI.Name = "lbnROI";
            lbnROI.Size = new Size(199, 35);
            lbnROI.TabIndex = 24;
            lbnROI.Text = "Rate of Intrest";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 17.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(158, 495);
            label2.Name = "label2";
            label2.Size = new Size(128, 35);
            label2.TabIndex = 26;
            label2.Text = "Duration";
            // 
            // txtDuration
            // 
            txtDuration.Font = new Font("Segoe Condensed", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtDuration.Location = new Point(490, 507);
            txtDuration.Name = "txtDuration";
            txtDuration.Size = new Size(279, 35);
            txtDuration.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe Condensed", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(610, 579);
            label1.Name = "label1";
            label1.Size = new Size(34, 33);
            label1.TabIndex = 28;
            label1.Text = "%";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial Black", 29F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(64, 0, 0);
            label3.Location = new Point(92, 46);
            label3.Name = "label3";
            label3.Size = new Size(655, 69);
            label3.TabIndex = 29;
            label3.Text = "Fixed Deposite Amount";
            // 
            // FixedDepositeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1482, 853);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txtDuration);
            Controls.Add(label2);
            Controls.Add(lbnrate);
            Controls.Add(lbnROI);
            Controls.Add(button2);
            Controls.Add(lbn);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtName);
            Controls.Add(lbnName);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(txtAmt);
            Controls.Add(lbnDate);
            Controls.Add(lbnAmt);
            Name = "FixedDepositeForm";
            Text = "FixedDepositeForm";
            Load += FixedDepositeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtAmt;
        private Label lbnDate;
        private Label lbnAmt;
        private TextBox txtName;
        private Label lbnName;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Label lbn;
        private Button button2;
        private Label lbnrate;
        private Label lbnROI;
        private Label label2;
        private TextBox txtDuration;
        private Label label1;
        private Label label3;
    }
}