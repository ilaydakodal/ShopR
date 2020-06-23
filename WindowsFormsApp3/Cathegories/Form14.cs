using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace WindowsFormsApp3
{
    public partial class Form14 : Form
    {
        public SqlConnection con = new SqlConnection("Data Source = DESKTOP-RIB9PAO\\SQLEXPRESS;Initial Catalog = ShopR;Integrated Security = True");

        Form12 f12;

        public Form14()
 

        {
            InitializeComponent();
            f12 = new Form12();
        }

            private void Label3_Click(object sender, EventArgs e)
        {

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
            f12.fill_itemList11();
            f12.Show();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            f12.fill_itemList12();
            f12.Show();
        }

        private void PictureBox3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            f12.fill_itemList10();
            f12.Show();
        }
    }
}
