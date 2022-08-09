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
    public partial class FrmRooms : Form
    {
        public FrmRooms()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-MP6HDBU;Initial Catalog=Hostel;Integrated Security=True");
        //The @ sign is placed to indicate that this is an address path.
        private void groupBox1_Enter(object sender, EventArgs e)
        {
            // Room101
            conn.Open();
            SqlCommand command = new SqlCommand("select * from Room101",conn);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                BtnRoom101.Text = reader["Name"].ToString() + " " + reader["Surname"].ToString();
            }
            conn.Close();

            if (BtnRoom101.Text != "101")
            {
                BtnRoom101.BackColor = Color.Red;
            }
            // Room102
            conn.Open();
            SqlCommand command2 = new SqlCommand("select * from Room102", conn);
            SqlDataReader reader2 = command2.ExecuteReader();

            while (reader2.Read())
            {
                BtnRoom102.Text = reader2["Name"].ToString() + " " + reader2["Surname"].ToString();
            }
            conn.Close();

            if (BtnRoom102.Text != "102")
            {
                BtnRoom102.BackColor = Color.Red;
            }
            // Room103
            conn.Open();
            SqlCommand command3 = new SqlCommand("select * from Room103", conn);
            SqlDataReader reader3 = command3.ExecuteReader();

            while (reader3.Read())
            {
                BtnRoom103.Text = reader3["Name"].ToString() + " " + reader3["Surname"].ToString();
            }
            conn.Close();

            if (BtnRoom103.Text != "103")
            {
                BtnRoom103.BackColor = Color.Red;
            }
            // Room104
            conn.Open();
            SqlCommand command4 = new SqlCommand("select * from Room104", conn);
            SqlDataReader reader4 = command4.ExecuteReader();

            while (reader4.Read())
            {
                BtnRoom104.Text = reader4["Name"].ToString() + " " + reader4["Surname"].ToString();
            }
            conn.Close();

            if (BtnRoom104.Text != "104")
            {
                BtnRoom104.BackColor = Color.Red;
            }
            // Room105
            conn.Open();
            SqlCommand command5 = new SqlCommand("select * from Room105", conn);
            SqlDataReader reader5 = command5.ExecuteReader();

            while (reader5.Read())
            {
                BtnRoom105.Text = reader5["Name"].ToString() + " " + reader5["Surname"].ToString();
            }
            conn.Close();

            if (BtnRoom105.Text != "105")
            {
                BtnRoom105.BackColor = Color.Red;
            }
            // Room106
            conn.Open();
            SqlCommand command6 = new SqlCommand("select * from Room106", conn);
            SqlDataReader reader6 = command6.ExecuteReader();

            while (reader6.Read())
            {
                BtnRoom106.Text = reader6["Name"].ToString() + " " + reader6["Surname"].ToString();
            }
            conn.Close();

            if (BtnRoom106.Text != "106")
            {
                BtnRoom106.BackColor = Color.Red;
            }
            // Room107
            conn.Open();
            SqlCommand command7 = new SqlCommand("select * from Room107", conn);
            SqlDataReader reader7 = command7.ExecuteReader();

            while (reader7.Read())
            {
                BtnRoom107.Text = reader7["Name"].ToString() + " " + reader7["Surname"].ToString();
            }
            conn.Close();

            if (BtnRoom107.Text != "107")
            {
                BtnRoom107.BackColor = Color.Red;
            }
            // Room108
            conn.Open();
            SqlCommand command8 = new SqlCommand("select * from Room108", conn);
            SqlDataReader reader8 = command8.ExecuteReader();

            while (reader8.Read())
            {
                BtnRoom108.Text = reader8["Name"].ToString() + " " + reader8["Surname"].ToString();
            }
            conn.Close();

            if (BtnRoom108.Text != "108")
            {
                BtnRoom108.BackColor = Color.Red;
            }
            // Room109
            conn.Open();
            SqlCommand command9 = new SqlCommand("select * from Room109", conn);
            SqlDataReader reader9 = command9.ExecuteReader();

            while (reader9.Read())
            {
                BtnRoom109.Text = reader9["Name"].ToString() + " " + reader9["Surname"].ToString();
            }
            conn.Close();

            if (BtnRoom109.Text != "109")
            {
                BtnRoom109.BackColor = Color.Red;
            }
        }
    }
}
