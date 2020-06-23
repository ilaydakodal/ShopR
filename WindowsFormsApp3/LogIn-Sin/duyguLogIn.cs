//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using System.Data.SqlClient;

//namespace WindowsFormsApp3.LogIn_Sin
//{
//    public partial class duyguLogIn : Form
//    {
//        string connectionString2 = ("Data Source = DESKTOP-RIB9PAO\\SQLEXPRESS;Initial Catalog = ShopR;Integrated Security = True");
//        public duyguLogIn()
//        {
//            InitializeComponent();
//        }

//        private void BtnS_Click(object sender, EventArgs e)
//        {

//        }

//        private void BtnL_Click(object sender, EventArgs e)
//        {
//            if(radioButton1.Checked == true)
//            {
//                SqlConnection s = new SqlConnection(connectionString2);
//                SqlCommand sqlCmd2 = new SqlCommand("select UserName,Password from Table_1 where UserName = @UserName and Password = @Password", s);
//                sqlCmd2.Parameters.AddWithValue("@UserName", ID.Text);
//                sqlCmd2.Parameters.AddWithValue("@Password", PW.Text);

//            }
//            else if(radioButton2.Checked == true)
//            {
//                SqlConnection s = new SqlConnection(connectionString2);
//                SqlCommand sqlCmd2 = new SqlCommand("select AdminID,AdminPass from Table_2 where AdminID = 'admn' and AdminPass = '1234'", s);
//                sqlCmd2.Parameters.AddWithValue("@UserName", ID.Text);
//                sqlCmd2.Parameters.AddWithValue("@Password", PW.Text);
//            }
//            else
//            {
//                MessageBox.Show("check your pass or id");
//        //    }
//        //    s.Open();
//        //    SqlDataAdapter Adapt = new SqlDataAdapter(sqlCmd2);
//        //    DataSet login = new DataSet();
//        //    Adapt.Fill(login);
//        //    sqlc2.Close();
//        //    int count = login.Tables[0].Rows.Count;
//        //}

//        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
//        {
          
//        }
//    }
//}
