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
    public partial class Form1 : Form
    {
        string connectionString2 = ("Data Source = DESKTOP-RIB9PAO\\SQLEXPRESS;Initial Catalog = ShopR;Integrated Security = True");
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f2 = new Form2();
            f2.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (ID.Text == "" || PW.Text == "")
            {
                MessageBox.Show("fill all empty spaces");

            }

            else
            {
                SqlConnection sqlc2 = new SqlConnection(connectionString2);
                SqlCommand sqlCmd2 = new SqlCommand("select UserName,Password from Table_1 where UserName = @UserName and Password = @Password", sqlc2);
                sqlCmd2.Parameters.AddWithValue("@UserName", ID.Text);
                sqlCmd2.Parameters.AddWithValue("@Password", PW.Text);


                sqlc2.Open();
                SqlDataAdapter Adapt = new SqlDataAdapter(sqlCmd2);
                DataSet login = new DataSet();
                Adapt.Fill(login);
                sqlc2.Close();
                int count = login.Tables[0].Rows.Count;
                if (count == 1)
                {
                    MessageBox.Show("logged in");
                    this.Hide();
                    Form f3 = new Form3();
                    f3.ShowDialog();

                }
                else
                {
                    MessageBox.Show("please check your id and password");
                }
           

            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f8 = new Form8();
            f8.ShowDialog();
        }
    }
}