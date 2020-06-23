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
    public partial class Form8 : Form
    {
        String connectionString3 = "Data Source = DESKTOP-RIB9PAO\\SQLEXPRESS;Initial Catalog = ShopR;Integrated Security = True";
        public Form8()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnAdmnLog_Click(object sender, EventArgs e)
        {
            if (txtAdmnID.Text == "" || txtAdmnPass.Text == "")
            {
                MessageBox.Show("fill all empty spaces");

            }

            else
            {
                SqlConnection sqlc2 = new SqlConnection(connectionString3);
                SqlCommand sqlCmd2 = new SqlCommand("select AdminID,AdminPass from Table_2 where AdminID = @AdminID and AdminPass = @AdminPass", sqlc2);
                sqlCmd2.Parameters.AddWithValue("@AdminID", txtAdmnID.Text);
                sqlCmd2.Parameters.AddWithValue("@AdminPass", txtAdmnPass.Text);


                sqlc2.Open();
                SqlDataAdapter Adapt = new SqlDataAdapter(sqlCmd2);
                DataSet AdmnLogin = new DataSet();
                Adapt.Fill(AdmnLogin);
                sqlc2.Close();
                int count = AdmnLogin.Tables[0].Rows.Count;
                if (count == 1)
                {
                    MessageBox.Show("welcome!");
                    this.Hide();
                    Form f9 = new Form9();
                    f9.ShowDialog();

                }
                else
                {
                    MessageBox.Show("please check your id and password");
                }


            }
        }

        private void BtnAdmnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f1 = new Form1();
            f1.ShowDialog();
        }
    }
}



            
        
        
    
