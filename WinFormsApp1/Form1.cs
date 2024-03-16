namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btn_Red_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Red;
        }

        private void btn_Blue_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Blue;
        }

        private void btn_Pink_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Pink;
        }
    }
}
