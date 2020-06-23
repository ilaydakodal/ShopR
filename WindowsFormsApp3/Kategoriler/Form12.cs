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

    public partial class Form12 : Form
    {
        public SqlConnection con = new SqlConnection("Data Source = DESKTOP-RIB9PAO\\SQLEXPRESS;Initial Catalog = ShopR;Integrated Security = True");
        Form3 f3;
        Form4 f4;
        public int ItemType;
        public Form12()

        {
            InitializeComponent();
            f4 = new Form4();
            
            con.Open();
           


        }
        public void fill_itemList()
        {
            listView1.Items.Clear();


            SqlCommand cmd = new SqlCommand("Select * from Book where BType = 'SCI-FI' ", con);
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
                con.Close();
                ItemType = 1;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void fill_itemList2()
        {
            listView1.Items.Clear();


            SqlCommand cmd = new SqlCommand("Select * from Book where BType = 'FANTASTIC' ", con);
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
                con.Close();
                ItemType = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void fill_itemList3()
        {
            listView1.Items.Clear();


            SqlCommand cmd = new SqlCommand("Select * from Book where BType = 'ROMANCE' ", con);
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
                con.Close();
                ItemType = 1;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void fill_itemList4()
        {
            listView1.Items.Clear();


            SqlCommand cmd = new SqlCommand("Select * from Book where BType = 'SCIENCE' ", con);
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
                con.Close();
                ItemType = 1;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void fill_itemList5()
        {
            listView1.Items.Clear();


            SqlCommand cmd = new SqlCommand("Select * from Book where BType = 'HORROR' ", con);
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
                con.Close();
                ItemType = 1;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void fill_itemList6()
        {
            listView1.Items.Clear();


            SqlCommand cmd = new SqlCommand("Select * from Book where BType = 'ADVENTURE' ", con);
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
                con.Close();
                ItemType = 1;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void fill_itemList7()
        {
            listView1.Items.Clear();


            SqlCommand cmd = new SqlCommand("Select * from Tec where TType = 'PHONE' ", con);
            try
            {

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ListViewItem it = new ListViewItem(dr["TName"].ToString());
                    listView1.Items.Add(it);
                }
                dr.Close();
                dr.Dispose();
                con.Close();
                ItemType = 2;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void fill_itemList8()
        {
            listView1.Items.Clear();


            SqlCommand cmd = new SqlCommand("Select * from Tec where TType = 'PC' ", con);
            try
            {

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ListViewItem it = new ListViewItem(dr["TName"].ToString());
                    listView1.Items.Add(it);
                }
                dr.Close();
                dr.Dispose();
                con.Close();
                ItemType = 2;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void fill_itemList9()
        {
            listView1.Items.Clear();


            SqlCommand cmd = new SqlCommand("Select * from Tec where TType = 'TV' ", con);
            try
            {

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ListViewItem it = new ListViewItem(dr["TName"].ToString());
                    listView1.Items.Add(it);
                }
                dr.Close();
                dr.Dispose();
                con.Close();
                ItemType = 2;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void fill_itemList10() 
        {
            listView1.Items.Clear();


            SqlCommand cmd = new SqlCommand("Select * from TXTL where TXType = 'T-SHIRT' ", con);
            try
            {

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ListViewItem it = new ListViewItem(dr["TXName"].ToString());
                    listView1.Items.Add(it);
                }
                dr.Close();
                dr.Dispose();
                con.Close();
                ItemType = 3;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void fill_itemList11()
        {
            listView1.Items.Clear();


            SqlCommand cmd = new SqlCommand("Select * from TXTL where TXType = 'PANTS' ", con);
            try
            {

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ListViewItem it = new ListViewItem(dr["TXName"].ToString());
                    listView1.Items.Add(it);
                }
                dr.Close();
                dr.Dispose();
                con.Close();
                ItemType = 3;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void fill_itemList12()
        {
            listView1.Items.Clear();


            SqlCommand cmd = new SqlCommand("Select * from TXTL where TXType = 'DRESS' ", con);
            try
            {

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ListViewItem it = new ListViewItem(dr["TXname"].ToString());
                    listView1.Items.Add(it);
                }
                dr.Close();
                dr.Dispose();
                con.Close();
                ItemType = 3;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void Form12_Load(object sender, EventArgs e)
        {

        }

        private void Form12_Shown(object sender, EventArgs e)
        {

            try
            {
                //fill_itemList();
            }
            catch (SqlException ex)
            { }
        }

        private void ListView1_Click(object sender, EventArgs e)
        {

            con.Open();
            fillItemPageBook();
            fillItemImage();
            f4.ShowDialog();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            f3 = new Form3();
            f3.Show();
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
        public void fillItemPageBook()
        {

            if (ItemType == 1)
            {

                SqlCommand cmd = new SqlCommand("Select * from Book where BName=@BName", con);
                cmd.Parameters.AddWithValue("@BName", listView1.SelectedItems[0].Text);
                try
                {

                    SqlDataReader dr = cmd.ExecuteReader();
                    


                    if (dr.Read())
                    {
                        f4.richTextBox1.Text = (dr["BDSC"].ToString());
                        f4.label2.Text = (dr["BPrice"].ToString());
                        f4.label1.Text = (dr["BName"].ToString());
                        


                    }
                    dr.Close();
                    dr.Dispose();
                    con.Close();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (ItemType == 2)
            {
                SqlCommand cmd = new SqlCommand("Select * from Tec where TName=@TName", con);
                cmd.Parameters.AddWithValue("@TName", listView1.SelectedItems[0].Text);
                try
                {

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        f4.richTextBox1.Text = (dr["TDSC"].ToString());
                        f4.label2.Text = (dr["TPrice"].ToString());
                        f4.label1.Text = (dr["TName"].ToString());




                    }
                    dr.Close();
                    dr.Dispose();
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        /*public void fillItemTec()
        {
            {


                SqlCommand cmd = new SqlCommand("Select * from Tec where TName=" + listView1.Text, con);
                try
                {

                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        f4.label1.Text = (dr["TDSC"].ToString());
                        f4.label2.Text = (dr["TPrice"].ToString());



                    }
                    dr.Close();
                    dr.Dispose();
                    con.Close();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }*/
        }
        public void fillItemImage() {
            if (ItemType == 1)
            {
                SqlCommand cmd = new SqlCommand("Select * from Book where BName=@BName", con);
                cmd.Parameters.AddWithValue("@BName", listView1.SelectedItems[0].Text);
                var da = new SqlDataAdapter(cmd);
                var ds = new DataSet();
                da.Fill(ds, "Book");
                int count = ds.Tables["Book"].Rows.Count;

                if (count > 0)
                {
                    var data = (Byte[])ds.Tables["Book"].Rows[count - 1]["BImage"];
                    var stream = new MemoryStream(data);
                    f4.pictureBox1.Image = Image.FromStream(stream);
                }
            }
        }

    }
    }


