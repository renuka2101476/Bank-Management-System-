namespace Form1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            label2 = new Label();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiBold SemiConden", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(-92, -170);
            label1.Name = "label1";
            label1.Size = new Size(619, 45);
            label1.TabIndex = 8;
            label1.Text = "WELCOME TO BANK OF MODERN COLLEGE ";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 15;
            timer1.Tick += timer1_Tick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiBold SemiConden", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(78, -49);
            label2.Name = "label2";
            label2.Size = new Size(619, 45);
            label2.TabIndex = 11;
            label2.Text = "WELCOME TO BANK OF MODERN COLLEGE ";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Bank_Image;
            pictureBox2.Location = new Point(169, 145);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1156, 609);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift SemiBold SemiConden", 35F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 0, 64);
            label3.Location = new Point(263, 49);
            label3.Name = "label3";
            label3.Size = new Size(986, 71);
            label3.TabIndex = 12;
            label3.Text = "WELCOME TO BANK OF MODERN COLLEGE ";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(1, 787);
            panel1.Name = "panel1";
            panel1.Size = new Size(1483, 66);
            panel1.TabIndex = 13;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Chartreuse;
            panel2.Location = new Point(-8, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(75, 93);
            panel2.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1482, 853);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private Label label2;
        private PictureBox pictureBox2;
        private Label label3;
        private Panel panel1;
        private Panel panel2;
    }
}