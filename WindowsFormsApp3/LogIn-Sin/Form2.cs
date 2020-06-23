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
    public partial class Form2 : Form
    {
        string connectionString = ("Data Source = DESKTOP-RIB9PAO\\SQLEXPRESS;Initial Catalog = ShopR;Integrated Security = True");
        public Form2()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Form f1 = new Form1();
            f1.ShowDialog();
        }

        private void BtnSignin_Click(object sender, EventArgs e)
         {

            if (txtName.Text == "" || txtSurname.Text == "" || txtAddress.Text == "" ||
                txtCard.Text == "" || txtPass.Text == "" || txtID.Text == "")
                MessageBox.Show("please fill all blanks");
           
            else
            {
                using (SqlConnection sqlcon = new SqlConnection(connectionString))
                {
                    sqlcon.Open();
                    SqlCommand sqlc = new SqlCommand("CustomerAdd", sqlcon);
                    sqlc.CommandType = CommandType.StoredProcedure;
                    sqlc.Parameters.AddWithValue("@FirstName", txtName.Text.Trim());
                    sqlc.Parameters.AddWithValue("@LastName", txtSurname.Text.Trim());
                    sqlc.Parameters.AddWithValue("@Address", txtAddress.Text.Trim());
                    sqlc.Parameters.AddWithValue("@CardNumber", txtCard.Text.Trim());
                    sqlc.Parameters.AddWithValue("@Password", txtPass.Text.Trim());
                    sqlc.Parameters.AddWithValue("@UserName", txtID.Text.Trim());
                    sqlc.ExecuteNonQuery();
                    MessageBox.Show("Registration is successfull");
                    clear();

                    this.Hide();
                    Form f1 = new Form1();
                    f1.ShowDialog();
                }
            }


        }
        void clear()
        {
            txtName.Text = txtSurname.Text = txtAddress.Text = txtCard.Text  = txtPass.Text = txtID.Text = "";

        }

        private void TxtCCV_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f1 = new Form1();
            f1.ShowDialog();
        }

        private void TxtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
