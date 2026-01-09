namespace Form1
{
    partial class AccountHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountHistory));
            dataGridView1 = new DataGridView();
            btnBack = new Button();
            dataGridView2 = new DataGridView();
            label7 = new Label();
            label1 = new Label();
            lbnano = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(420, 201);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(753, 318);
            dataGridView1.TabIndex = 2;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.DarkGray;
            btnBack.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.Location = new Point(1270, 814);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(203, 65);
            btnBack.TabIndex = 3;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(420, 583);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(759, 296);
            dataGridView2.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(0, 0, 64);
            label7.Location = new Point(597, 143);
            label7.Name = "label7";
            label7.Size = new Size(388, 31);
            label7.TabIndex = 34;
            label7.Text = "Deposite and Withdraw History";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 0, 64);
            label1.Location = new Point(647, 539);
            label1.Name = "label1";
            label1.Size = new Size(310, 31);
            label1.TabIndex = 35;
            label1.Text = "Transfer Amount History";
            // 
            // lbnano
            // 
            lbnano.AutoSize = true;
            lbnano.Font = new Font("Times New Roman", 25F, FontStyle.Bold, GraphicsUnit.Point);
            lbnano.Location = new Point(610, 37);
            lbnano.Name = "lbnano";
            lbnano.Size = new Size(356, 48);
            lbnano.TabIndex = 7;
            lbnano.Text = "Bank Transactions";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(241, 212);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 51;
            pictureBox1.TabStop = false;
            // 
            // AccountHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1500, 900);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(label7);
            Controls.Add(dataGridView2);
            Controls.Add(lbnano);
            Controls.Add(btnBack);
            Controls.Add(dataGridView1);
            Name = "AccountHistory";
            Text = "AccountHistory";
            Load += AccountHistory_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnBack;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Label label7;
        private Label label1;
        private Label lbnano;
        private PictureBox pictureBox1;
    }
}