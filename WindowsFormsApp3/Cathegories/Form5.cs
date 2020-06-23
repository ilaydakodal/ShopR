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
    public partial class Form5 : Form

    {
        public SqlConnection con = new SqlConnection("Data Source = DESKTOP-RIB9PAO\\SQLEXPRESS;Initial Catalog = ShopR;Integrated Security = True");
        Form12 f12;
        public Form5()
        {
            InitializeComponent();
             f12 = new Form12();
            con.Open();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            f12.fill_itemList();
            f12.Show();
            f12.ItemType = 1;
           
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form f3 = new Form3();
            f3.Show();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            f12.fill_itemList2();
            f12.ShowDialog();
            f12.ItemType = 1;
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            f12.fill_itemList3();
            f12.ShowDialog();
            f12.ItemType = 1;
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            f12.fill_itemList4();
            f12.ItemType = 1;
            f12.ShowDialog();

        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            f12.fill_itemList5();
            f12.ShowDialog();
            f12.ItemType = 1;
        }

        private void PictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
            f12.fill_itemList6();
            f12.ShowDialog();
            f12.ItemType = 1;
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
