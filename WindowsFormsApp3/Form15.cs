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
    public partial class Form15 : Form
    {
        Form12 f122;
        public Form15()
        {
            InitializeComponent();
            f122 = new Form12();
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            f122.fill_itemList9();
            f122.Show();

        }

        private void Button1_Click(object sender, EventArgs e)
        {

            this.Hide();

            Form f3 = new Form3();
            f3.ShowDialog();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            f122.fill_itemList7();
            f122.Show();

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            f122.fill_itemList8();
            f122.Show();
        }
    }
}
