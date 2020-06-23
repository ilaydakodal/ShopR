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
    public partial class Form6 : Form
    {
        Form4 f44;

        public Form6()
        {
            InitializeComponent();
        }

        private void CheckedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            f44 = new Form4();
          
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f3 = new Form3();
            f3.ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f7 = new Form7();
            f7.ShowDialog();
        }
    }
}
