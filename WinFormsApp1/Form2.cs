using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void btn_Focus_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Red_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Red;
        }

        private void btn_Green_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Green;
        }

        private void btn_Blue_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Blue;
        }

        private void btn_Pink_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Pink;
            textBox2.ForeColor = Color.Pink;
            textBox3.ForeColor = Color.Pink;
        }

        private void btn_Gold_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Gold;
            textBox2.ForeColor = Color.Gold;
            textBox3.ForeColor = Color.Gold;
        }

        private void btn_Yellow_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Yellow;
            textBox2.ForeColor = Color.Yellow;
            textBox3.ForeColor = Color.Yellow;
        }
    }
}
