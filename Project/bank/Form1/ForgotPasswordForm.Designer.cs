namespace Form1
{
    partial class ForgotPasswordForm
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
            label1 = new Label();
            txtNewPass = new TextBox();
            txtConfirmPass = new TextBox();
            label2 = new Label();
            btnChange = new Button();
            btnBack = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 19F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(451, 263);
            label1.Name = "label1";
            label1.Size = new Size(230, 36);
            label1.TabIndex = 0;
            label1.Text = "New Passaword";
            // 
            // txtNewPass
            // 
            txtNewPass.Location = new Point(804, 263);
            txtNewPass.Name = "txtNewPass";
            txtNewPass.Size = new Size(251, 27);
            txtNewPass.TabIndex = 1;
            // 
            // txtConfirmPass
            // 
            txtConfirmPass.Location = new Point(804, 366);
            txtConfirmPass.Name = "txtConfirmPass";
            txtConfirmPass.Size = new Size(251, 27);
            txtConfirmPass.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 19F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(451, 365);
            label2.Name = "label2";
            label2.Size = new Size(289, 36);
            label2.TabIndex = 2;
            label2.Text = "Confirm Passaword";
            // 
            // btnChange
            // 
            btnChange.BackColor = Color.LightGray;
            btnChange.Font = new Font("Times New Roman", 18.5F, FontStyle.Bold, GraphicsUnit.Point);
            btnChange.Location = new Point(518, 535);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(199, 63);
            btnChange.TabIndex = 4;
            btnChange.Text = "Change";
            btnChange.UseVisualStyleBackColor = false;
            btnChange.Click += btnChange_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.LightGray;
            btnBack.Font = new Font("Times New Roman", 18.5F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.Location = new Point(814, 535);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(199, 63);
            btnBack.TabIndex = 5;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Black", 28F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 0, 64);
            label3.Location = new Point(518, 103);
            label3.Name = "label3";
            label3.Size = new Size(458, 67);
            label3.TabIndex = 35;
            label3.Text = "Forgot Password";
            // 
            // ForgotPasswordForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1450, 743);
            Controls.Add(label3);
            Controls.Add(btnBack);
            Controls.Add(btnChange);
            Controls.Add(txtConfirmPass);
            Controls.Add(label2);
            Controls.Add(txtNewPass);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "ForgotPasswordForm";
            Text = "ForgotPasswordForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNewPass;
        private TextBox txtConfirmPass;
        private Label label2;
        private Button btnChange;
        private Button btnBack;
        private Label label3;
    }
}