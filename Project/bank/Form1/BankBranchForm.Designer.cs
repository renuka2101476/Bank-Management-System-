namespace Form1
{
    partial class BankBranchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BankBranchForm));
            insertbtn = new Button();
            searchbtn = new Button();
            backbtn = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            bnametxt = new TextBox();
            citytxt = new TextBox();
            districttxt = new TextBox();
            pincodetxt = new TextBox();
            label7 = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // insertbtn
            // 
            insertbtn.BackColor = Color.LightGray;
            insertbtn.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            insertbtn.Location = new Point(541, 697);
            insertbtn.Name = "insertbtn";
            insertbtn.Size = new Size(232, 56);
            insertbtn.TabIndex = 0;
            insertbtn.Text = "Insert";
            insertbtn.UseVisualStyleBackColor = false;
            insertbtn.Click += insertbtn_Click;
            // 
            // searchbtn
            // 
            searchbtn.BackColor = Color.LightGray;
            searchbtn.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            searchbtn.Location = new Point(877, 697);
            searchbtn.Name = "searchbtn";
            searchbtn.Size = new Size(232, 56);
            searchbtn.TabIndex = 1;
            searchbtn.Text = "Search";
            searchbtn.UseVisualStyleBackColor = false;
            searchbtn.Click += searchbtn_Click;
            // 
            // backbtn
            // 
            backbtn.BackColor = Color.LightGray;
            backbtn.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            backbtn.Location = new Point(541, 795);
            backbtn.Name = "backbtn";
            backbtn.Size = new Size(232, 56);
            backbtn.TabIndex = 3;
            backbtn.Text = "Back";
            backbtn.UseVisualStyleBackColor = false;
            backbtn.Click += backbtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 17.5F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(474, 280);
            label2.Name = "label2";
            label2.Size = new Size(188, 35);
            label2.TabIndex = 5;
            label2.Text = "Branch Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 17.5F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(474, 373);
            label3.Name = "label3";
            label3.Size = new Size(69, 35);
            label3.TabIndex = 6;
            label3.Text = "City";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 17.5F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(474, 467);
            label4.Name = "label4";
            label4.Size = new Size(110, 35);
            label4.TabIndex = 7;
            label4.Text = "District";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 17.5F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(474, 577);
            label5.Name = "label5";
            label5.Size = new Size(133, 35);
            label5.TabIndex = 8;
            label5.Text = "Pin Code";
            // 
            // bnametxt
            // 
            bnametxt.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            bnametxt.Location = new Point(787, 280);
            bnametxt.Name = "bnametxt";
            bnametxt.Size = new Size(334, 36);
            bnametxt.TabIndex = 10;
            // 
            // citytxt
            // 
            citytxt.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            citytxt.Location = new Point(787, 376);
            citytxt.Name = "citytxt";
            citytxt.Size = new Size(334, 36);
            citytxt.TabIndex = 11;
            // 
            // districttxt
            // 
            districttxt.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            districttxt.Location = new Point(787, 467);
            districttxt.Name = "districttxt";
            districttxt.Size = new Size(334, 36);
            districttxt.TabIndex = 12;
            // 
            // pincodetxt
            // 
            pincodetxt.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            pincodetxt.Location = new Point(787, 577);
            pincodetxt.Name = "pincodetxt";
            pincodetxt.Size = new Size(334, 36);
            pincodetxt.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Black", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(528, 66);
            label7.Name = "label7";
            label7.Size = new Size(557, 67);
            label7.TabIndex = 47;
            label7.Text = "Branch Management";
            // 
            // button1
            // 
            button1.BackColor = Color.LightGray;
            button1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(877, 795);
            button1.Name = "button1";
            button1.Size = new Size(232, 56);
            button1.TabIndex = 48;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -3);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(291, 295);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 49;
            pictureBox1.TabStop = false;
            // 
            // BankBranchForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1500, 900);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(pincodetxt);
            Controls.Add(districttxt);
            Controls.Add(citytxt);
            Controls.Add(bnametxt);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(backbtn);
            Controls.Add(searchbtn);
            Controls.Add(insertbtn);
            Name = "BankBranchForm";
            Text = "BankBranchForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button insertbtn;
        private Button searchbtn;
        private Button updatebtn;
        private Button backbtn;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox bnametxt;
        private TextBox citytxt;
        private TextBox districttxt;
        private TextBox pincodetxt;
        private Label label7;
        private Button button1;
        private PictureBox pictureBox1;
    }
}