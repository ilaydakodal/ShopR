using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f5 = new Form5();
            f5.ShowDialog();
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form f15 = new Form15();
            f15.Show();

        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f14 = new Form14();
            f14.ShowDialog();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
