namespace Form1
{
    partial class CheckBalanceFormcs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckBalanceFormcs));
            label3 = new Label();
            lbnbal = new Label();
            lbnaccno = new Label();
            btnBack = new Button();
            lbnAvailableBalance = new Label();
            lbnAcno = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Black", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 0, 64);
            label3.Location = new Point(437, 103);
            label3.Name = "label3";
            label3.Size = new Size(578, 70);
            label3.TabIndex = 34;
            label3.Text = "Check Your Balance";
            label3.Click += label3_Click;
            // 
            // lbnbal
            // 
            lbnbal.AutoSize = true;
            lbnbal.Font = new Font("Times New Roman", 17F, FontStyle.Bold, GraphicsUnit.Point);
            lbnbal.Location = new Point(818, 419);
            lbnbal.Name = "lbnbal";
            lbnbal.Size = new Size(88, 32);
            lbnbal.TabIndex = 33;
            lbnbal.Text = "label2";
            // 
            // lbnaccno
            // 
            lbnaccno.AutoSize = true;
            lbnaccno.Font = new Font("Times New Roman", 17F, FontStyle.Bold, GraphicsUnit.Point);
            lbnaccno.Location = new Point(818, 294);
            lbnaccno.Name = "lbnaccno";
            lbnaccno.Size = new Size(88, 32);
            lbnaccno.TabIndex = 32;
            lbnaccno.Text = "label1";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.DarkGray;
            btnBack.Font = new Font("Bahnschrift SemiBold SemiConden", 20F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.Location = new Point(600, 588);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(268, 68);
            btnBack.TabIndex = 31;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // lbnAvailableBalance
            // 
            lbnAvailableBalance.AutoSize = true;
            lbnAvailableBalance.Font = new Font("Times New Roman", 17F, FontStyle.Bold, GraphicsUnit.Point);
            lbnAvailableBalance.Location = new Point(512, 417);
            lbnAvailableBalance.Name = "lbnAvailableBalance";
            lbnAvailableBalance.Size = new Size(232, 32);
            lbnAvailableBalance.TabIndex = 28;
            lbnAvailableBalance.Text = "Available Balance";
            // 
            // lbnAcno
            // 
            lbnAcno.AutoSize = true;
            lbnAcno.Font = new Font("Times New Roman", 17F, FontStyle.Bold, GraphicsUnit.Point);
            lbnAcno.Location = new Point(512, 292);
            lbnAcno.Name = "lbnAcno";
            lbnAcno.Size = new Size(172, 32);
            lbnAcno.TabIndex = 26;
            lbnAcno.Text = "A/C Number";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -1);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(260, 235);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 50;
            pictureBox1.TabStop = false;
            // 
            // CheckBalanceFormcs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1415, 810);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(lbnbal);
            Controls.Add(lbnaccno);
            Controls.Add(btnBack);
            Controls.Add(lbnAvailableBalance);
            Controls.Add(lbnAcno);
            DoubleBuffered = true;
            Name = "CheckBalanceFormcs";
            Text = "CheckBalanceFormcs";
            Load += CheckBalanceFormcs_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label lbnbal;
        private Label lbnaccno;
        private Button btnBack;
        private Label lbnAvailableBalance;
        private Label lbnAcno;
        private PictureBox pictureBox1;
    }
}