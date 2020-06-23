using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form4 : Form
    {  
        public SqlConnection con = new SqlConnection("Data Source = DESKTOP-RIB9PAO\\SQLEXPRESS;Initial Catalog = ShopR;Integrated Security = True");
        Form6 f6;
        public int value1;
        public int TTL;
        public Form4()

        {
            InitializeComponent();
            f6 = new Form6();



            con.Open();
           
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            /*Form12 fa = new Form12();
            fa.fillItemPageBook();
            

            /*if (fa.ItemType == 1)
            {
                fa.fillItemPageBook();

            }
            else if (fa.ItemType == 2)
            {
                fa.fillItemTec();

            }*/
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            
            value1 = Convert.ToInt32(this.label2.Text);
            CartItem x = new CartItem(label1.Text, value1);
            f6.checkedListBox1.Items.Add(x);
            TTL += value1;
            string myString = TTL.ToString();
            f6.label3.Text = myString;

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            f6.ShowDialog();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f7 = new Form7();
            f7.ShowDialog();
        }
    }

    }

