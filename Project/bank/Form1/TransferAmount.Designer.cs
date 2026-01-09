namespace Form1
{
    partial class TransferAmount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransferAmount));
            dateTimePicker1 = new DateTimePicker();
            txtFromAno = new TextBox();
            txtToAno = new TextBox();
            label1 = new Label();
            lbnWithAcno = new Label();
            label3 = new Label();
            txtAmtt = new TextBox();
            lbnAmtDep = new Label();
            button2 = new Button();
            btnTransfer = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(701, 409);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(317, 34);
            dateTimePicker1.TabIndex = 29;
            // 
            // txtFromAno
            // 
            txtFromAno.Font = new Font("Segoe Condensed", 16.4F, FontStyle.Bold, GraphicsUnit.Point);
            txtFromAno.Location = new Point(698, 222);
            txtFromAno.Name = "txtFromAno";
            txtFromAno.Size = new Size(320, 39);
            txtFromAno.TabIndex = 28;
            // 
            // txtToAno
            // 
            txtToAno.Font = new Font("Segoe Condensed", 16.4F, FontStyle.Bold, GraphicsUnit.Point);
            txtToAno.Location = new Point(698, 309);
            txtToAno.Name = "txtToAno";
            txtToAno.Size = new Size(320, 39);
            txtToAno.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe Condensed", 19F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(464, 495);
            label1.Name = "label1";
            label1.Size = new Size(112, 38);
            label1.TabIndex = 26;
            label1.Text = "Amount";
            // 
            // lbnWithAcno
            // 
            lbnWithAcno.AutoSize = true;
            lbnWithAcno.BackColor = Color.Transparent;
            lbnWithAcno.Font = new Font("Segoe Condensed", 19F, FontStyle.Bold, GraphicsUnit.Point);
            lbnWithAcno.ForeColor = Color.Black;
            lbnWithAcno.Location = new Point(464, 222);
            lbnWithAcno.Name = "lbnWithAcno";
            lbnWithAcno.Size = new Size(164, 38);
            lbnWithAcno.TabIndex = 25;
            lbnWithAcno.Text = "From_AccNo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe Condensed", 19F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(464, 309);
            label3.Name = "label3";
            label3.Size = new Size(132, 38);
            label3.TabIndex = 24;
            label3.Text = "To_AccNo";
            // 
            // txtAmtt
            // 
            txtAmtt.Font = new Font("Segoe Condensed", 16.4F, FontStyle.Bold, GraphicsUnit.Point);
            txtAmtt.Location = new Point(698, 495);
            txtAmtt.Name = "txtAmtt";
            txtAmtt.Size = new Size(320, 39);
            txtAmtt.TabIndex = 23;
            // 
            // lbnAmtDep
            // 
            lbnAmtDep.AutoSize = true;
            lbnAmtDep.BackColor = Color.Transparent;
            lbnAmtDep.Font = new Font("Segoe Condensed", 19F, FontStyle.Bold, GraphicsUnit.Point);
            lbnAmtDep.ForeColor = Color.Black;
            lbnAmtDep.Location = new Point(464, 398);
            lbnAmtDep.Name = "lbnAmtDep";
            lbnAmtDep.Size = new Size(72, 38);
            lbnAmtDep.TabIndex = 22;
            lbnAmtDep.Text = "Date";
            // 
            // button2
            // 
            button2.BackColor = Color.DarkGray;
            button2.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(790, 659);
            button2.Name = "button2";
            button2.Size = new Size(185, 75);
            button2.TabIndex = 31;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btnTransfer
            // 
            btnTransfer.BackColor = Color.DarkGray;
            btnTransfer.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnTransfer.Location = new Point(498, 659);
            btnTransfer.Name = "btnTransfer";
            btnTransfer.Size = new Size(185, 75);
            btnTransfer.TabIndex = 30;
            btnTransfer.Text = "Transfer";
            btnTransfer.UseVisualStyleBackColor = false;
            btnTransfer.Click += btnTransfer_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial Narrow", 33F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 0, 64);
            label2.Location = new Point(545, 58);
            label2.Name = "label2";
            label2.Size = new Size(395, 65);
            label2.TabIndex = 30;
            label2.Text = "Transfer Amount";
            // 
            // TransferAmount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1500, 900);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(txtFromAno);
            Controls.Add(btnTransfer);
            Controls.Add(txtToAno);
            Controls.Add(txtAmtt);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(lbnWithAcno);
            Controls.Add(label3);
            Controls.Add(lbnAmtDep);
            Name = "TransferAmount";
            Text = "TransferAmount";
            Load += TransferAmount_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DateTimePicker dateTimePicker1;
        private TextBox txtFromAno;
        private TextBox txtToAno;
        private Label label1;
        private Label lbnWithAcno;
        private Label label3;
        private TextBox txtAmtt;
        private Label lbnAmtDep;
        private Button button2;
        private Button btnTransfer;
        private Label label2;
    }
}