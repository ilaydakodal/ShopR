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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form f11 = new Form11();
            f11.ShowDialog();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form f10 = new Form10();
            f10.ShowDialog();

        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }
    }
}
