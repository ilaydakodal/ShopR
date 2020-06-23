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
    public partial class Form7 : Form
    {
        Form6 f6;
        public Form7()
        {
            InitializeComponent();
            f6 = new Form6();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
           
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("your order is placed!");
        }
    }
}
