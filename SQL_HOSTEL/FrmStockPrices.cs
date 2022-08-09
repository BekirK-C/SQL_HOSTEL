using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace SQL_HOSTEL
{
    public partial class FrmStockPrices : Form
    {
        public FrmStockPrices()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-MP6HDBU;Initial Catalog=Hostel;Integrated Security=True");

        private void data()
        {
            listView1.Items.Clear();
            conn.Open();
            SqlCommand command = new SqlCommand("select * from [Expense of Products]", conn);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem add = new ListViewItem();
                add.Text = reader["Food"].ToString();
                add.SubItems.Add(reader["material"].ToString());
                listView1.Items.Add(add);
            }
            conn.Close();
        }

        private void data2()
        {
            listView2.Items.Clear();
            conn.Open();
            SqlCommand command2 = new SqlCommand("select * from Bills", conn);
            SqlDataReader reader2 = command2.ExecuteReader();
            while (reader2.Read())
            {
                ListViewItem add = new ListViewItem();
                add.Text = reader2["Electiricity"].ToString();
                add.SubItems.Add(reader2["Water"].ToString());
                add.SubItems.Add(reader2["Internet"].ToString());
                listView2.Items.Add(add);
            }
            conn.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand command = new SqlCommand("insert into [Expense of Products](Food,Material) values('" + TxtFood.Text + "','" + TxtMaterial.Text + "')", conn);
            command.ExecuteNonQuery();
            conn.Close();
            data();
        }

        private void FrmStockPrices_Load(object sender, EventArgs e)
        {
            data();
            data2();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand command2 = new SqlCommand("insert into Bills(Electiricity,Water,Internet) values('" + TxtElc.Text + "','" + TxtWtr.Text + "','" + TxtInt.Text + "')", conn);
            command2.ExecuteNonQuery();
            conn.Close();
            data2();
        }
    }
}
