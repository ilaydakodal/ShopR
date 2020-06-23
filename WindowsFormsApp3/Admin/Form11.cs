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

    public partial class Form11 : Form
    {
        public SqlConnection con = new SqlConnection("Data Source = DESKTOP-RIB9PAO\\SQLEXPRESS;Initial Catalog = ShopR;Integrated Security = True");

        public Form11()
        {

            InitializeComponent();
            listView1.Items.Clear();
        }
        void fill_itemList()
        {
            listView1.Items.Clear();
            /*DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Book", con);
            da.Fill(dt);
            SqlDataAdapter da2 = new SqlDataAdapter("Select * from Tec", con);
            da2.Fill(dt);
            SqlDataAdapter da3 = new SqlDataAdapter("Select * from TXTL",con);
            da3.Fill(dt);
            checkedListBox1.Items.Clear();



            foreach (DataRow dr in dt.Rows)
            {
                checkedListBox1.Items.Add(dr["Bname"].ToString());
                checkedListBox1.Items.Add(dr["TName"].ToString());
                checkedListBox1.Items.Add(dr["TXName"].ToString());

            }
            */

            SqlCommand cmd = new SqlCommand("Select * from Book", con);
            try
            {

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ListViewItem it = new ListViewItem(dr["Bname"].ToString());
                    listView1.Items.Add(it);
                }
                dr.Close();
                dr.Dispose();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void Form11_Load(object sender, EventArgs e)
        {

        }

        private void CheckedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            fill_itemList();
        }

        private void Buttondelete_Click(object sender, EventArgs e)
        {


            SqlCommand cm = new SqlCommand("DELETE from BOOk WHERE Bname=@BName", con);
            cm.Parameters.AddWithValue("@BName", listView1.SelectedItems[0].Text);
            try
            {
                cm.ExecuteNonQuery();
                fill_itemList();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Form11_Shown(object sender, EventArgs e)
        {
            try
            {
                con.Open();
               
            }
            catch (SqlException ex)
            { }
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
