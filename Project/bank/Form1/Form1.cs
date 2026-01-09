namespace Form1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 6;

            if (panel2.Width >= 1550)
            {
                timer1.Stop();
                this.Hide();

                LoginForm lf = new LoginForm();
                lf.Show();
                // RegisterationForm rf = new RegisterationForm();
                /// rf.Show();
                // timer1 t = new timer1();
                // t.Close();
            }
        }
    }
}