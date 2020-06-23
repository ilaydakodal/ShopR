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
using System.IO;

namespace WindowsFormsApp3
{

    public partial class Form10 : Form
    {
        string connectionString5 = ("Data Source = DESKTOP-RIB9PAO\\SQLEXPRESS;Initial Catalog = ShopR;Integrated Security = True");
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        SqlParameter picture;

        public Form10()
        {
            InitializeComponent();
        }

        private void browse()
        {
            try
            {
                OpenFileDialog f = new OpenFileDialog();
                f.InitialDirectory = "C:/Picture/";
                f.Filter = "All Files|*.*|JPEGS|*.jpg|Bitmaps|*.bmp|GIFs|*.gif";
                f.FilterIndex = 2;
                if (f.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(f.FileName);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox1.BorderStyle = BorderStyle.Fixed3D;

                }


            }
            catch { }

        }
       

        private void Label1_Click(object sender, EventArgs e)
        {

        }



        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }


        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            cmbType.Items.Clear();
            String[] book = { "SCI-FI", "FANTASTIC", "ADVENTURE", "HORROR", "ROMANCE", "SCIENCE" };
            cmbType.Items.AddRange(book);
            cmbType.SelectedIndex = 0;

        }



        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            cmbType.Items.Clear();
            
            String[] tech = { "PC", "PHONE", "TV" };
            cmbType.Items.AddRange(tech);
            cmbType.SelectedIndex = 0;

        }
        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            cmbType.Items.Clear();
      
            String[] textile = { "T-SHIRT", "PANTS", "DRESS" };
            cmbType.Items.AddRange(textile);
            cmbType.SelectedIndex = 0;
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            browse();
        }

        private void BtnAddToMarket_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || richTextBox1.Text == "" || pictureBox1.Image == null
                )
            {
                MessageBox.Show("Fill all the blanks");
            }
            else {
                if (radioButton1.Checked == true)
                {

                    using (SqlConnection sqlcon = new SqlConnection(connectionString5))
                    {

                        sqlcon.Open();
                        SqlCommand sqlc = new SqlCommand("BookAdd", sqlcon);
                        sqlc.CommandType = CommandType.StoredProcedure;
                        sqlc.Parameters.AddWithValue("@BPrice", textBox2.Text.Trim());
                        sqlc.Parameters.AddWithValue("@BType", cmbType.SelectedItem.ToString());
                        sqlc.Parameters.AddWithValue("@BDSC", richTextBox1.Text.Trim());
                        sqlc.Parameters.AddWithValue("@BName", textBox1.Text.Trim());
                        MemoryStream ms = new MemoryStream();
                        pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                        byte[] a = ms.GetBuffer();
                        ms.Close();
                        sqlc.Parameters.AddWithValue("@BImage", a);
                        sqlc.ExecuteNonQuery();
                        sqlcon.Close();
                        clear();



                    }
                }
                else if (radioButton2.Checked == true)
                {
                    using (SqlConnection sqlcon = new SqlConnection(connectionString5))
                    {

                        sqlcon.Open();
                        SqlCommand sqlc = new SqlCommand("TecAdd", sqlcon);
                        sqlc.CommandType = CommandType.StoredProcedure;
                        sqlc.Parameters.AddWithValue("@TPrice", textBox2.Text.Trim());
                        sqlc.Parameters.AddWithValue("@TType", cmbType.SelectedItem.ToString());
                        sqlc.Parameters.AddWithValue("@TDSC", richTextBox1.Text.Trim());
                        sqlc.Parameters.AddWithValue("@TName", textBox1.Text.Trim());
                        MemoryStream ms = new MemoryStream();
                        pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                        byte[] a = ms.GetBuffer();
                        ms.Close();
                        sqlc.Parameters.AddWithValue("@TImage", a);
                        sqlc.ExecuteNonQuery();
                        sqlcon.Close();
                        clear();
                    }

                }

                else {
                    using (SqlConnection sqlcon = new SqlConnection(connectionString5))
                    {

                        sqlcon.Open();
                        SqlCommand sqlcmd = new SqlCommand("textileadd1", sqlcon);
                        sqlcmd.CommandType = CommandType.StoredProcedure;
                        sqlcmd.Parameters.AddWithValue("@TXPrice", textBox2.Text.Trim());
                        sqlcmd.Parameters.AddWithValue("@TXType", cmbType.SelectedItem.ToString());
                        sqlcmd.Parameters.AddWithValue("@TXDSC", richTextBox1.Text.Trim());
                        sqlcmd.Parameters.AddWithValue("@TXName", textBox1.Text.Trim());
                        MemoryStream ms = new MemoryStream();
                        pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                        byte[] a = ms.GetBuffer();
                        ms.Close();
                        sqlcmd.Parameters.AddWithValue("@TXImage", a);
                            sqlcmd.ExecuteNonQuery();
                        sqlcon.Close();
                        clear();

                    }
                }
            }
            MessageBox.Show("Item Added");
        }
        void clear()
        {
            textBox2.Text = textBox1.Text = richTextBox1.Text = "";
            cmbType.SelectedIndex = -1;
            pictureBox1.Image = null;


        }
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LstDesc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }
    }
}
