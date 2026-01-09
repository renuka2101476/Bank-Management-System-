namespace Form1
{
    partial class ContactUsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactUsForm));
            lbnName = new Label();
            btnBack = new Button();
            groupBox1 = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            messtxt = new TextBox();
            contxt = new TextBox();
            nametxt = new TextBox();
            lbnMessage = new Label();
            lbndate = new Label();
            lbncontactno = new Label();
            btnSubmit = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lbnName
            // 
            lbnName.AutoSize = true;
            lbnName.Font = new Font("Times New Roman", 17.5F, FontStyle.Bold, GraphicsUnit.Point);
            lbnName.ForeColor = SystemColors.ButtonHighlight;
            lbnName.Location = new Point(62, 110);
            lbnName.Name = "lbnName";
            lbnName.Size = new Size(88, 35);
            lbnName.TabIndex = 10;
            lbnName.Text = "Name";
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ActiveBorder;
            btnBack.Font = new Font("Bahnschrift SemiBold SemiConden", 15.5F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.Location = new Point(421, 713);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(193, 75);
            btnBack.TabIndex = 25;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(messtxt);
            groupBox1.Controls.Add(contxt);
            groupBox1.Controls.Add(nametxt);
            groupBox1.Controls.Add(lbnMessage);
            groupBox1.Controls.Add(lbndate);
            groupBox1.Controls.Add(lbncontactno);
            groupBox1.Controls.Add(lbnName);
            groupBox1.Font = new Font("Bahnschrift SemiBold SemiConden", 15.5F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.WhiteSmoke;
            groupBox1.Location = new Point(12, 71);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(751, 614);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Text = "Contact Us";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(359, 307);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(346, 39);
            dateTimePicker1.TabIndex = 18;
            // 
            // messtxt
            // 
            messtxt.Location = new Point(359, 413);
            messtxt.Multiline = true;
            messtxt.Name = "messtxt";
            messtxt.Size = new Size(346, 115);
            messtxt.TabIndex = 17;
            // 
            // contxt
            // 
            contxt.Location = new Point(359, 191);
            contxt.Name = "contxt";
            contxt.Size = new Size(346, 39);
            contxt.TabIndex = 15;
            // 
            // nametxt
            // 
            nametxt.Location = new Point(359, 100);
            nametxt.Name = "nametxt";
            nametxt.Size = new Size(346, 39);
            nametxt.TabIndex = 14;
            // 
            // lbnMessage
            // 
            lbnMessage.AutoSize = true;
            lbnMessage.Font = new Font("Times New Roman", 17.5F, FontStyle.Bold, GraphicsUnit.Point);
            lbnMessage.ForeColor = SystemColors.ButtonHighlight;
            lbnMessage.Location = new Point(62, 423);
            lbnMessage.Name = "lbnMessage";
            lbnMessage.Size = new Size(122, 35);
            lbnMessage.TabIndex = 13;
            lbnMessage.Text = "Message";
            // 
            // lbndate
            // 
            lbndate.AutoSize = true;
            lbndate.Font = new Font("Times New Roman", 17.5F, FontStyle.Bold, GraphicsUnit.Point);
            lbndate.ForeColor = SystemColors.ButtonHighlight;
            lbndate.Location = new Point(62, 313);
            lbndate.Name = "lbndate";
            lbndate.Size = new Size(74, 35);
            lbndate.TabIndex = 12;
            lbndate.Text = "Date";
            // 
            // lbncontactno
            // 
            lbncontactno.AutoSize = true;
            lbncontactno.Font = new Font("Times New Roman", 17.5F, FontStyle.Bold, GraphicsUnit.Point);
            lbncontactno.ForeColor = SystemColors.ButtonHighlight;
            lbncontactno.Location = new Point(62, 201);
            lbncontactno.Name = "lbncontactno";
            lbncontactno.Size = new Size(227, 35);
            lbncontactno.TabIndex = 11;
            lbncontactno.Text = "Contact Number";
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = SystemColors.ActiveBorder;
            btnSubmit.Font = new Font("Bahnschrift SemiBold SemiConden", 15.5F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubmit.Location = new Point(120, 713);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(210, 75);
            btnSubmit.TabIndex = 24;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // ContactUsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1484, 850);
            Controls.Add(btnBack);
            Controls.Add(groupBox1);
            Controls.Add(btnSubmit);
            Name = "ContactUsForm";
            Text = "ContactUsForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lbnName;
        private Button btnBack;
        private GroupBox groupBox1;
        private TextBox messtxt;
        private TextBox contxt;
        private TextBox nametxt;
        private Label lbnMessage;
        private Label lbndate;
        private Label lbncontactno;
        private Button btnSubmit;
        private DateTimePicker dateTimePicker1;
    }
}