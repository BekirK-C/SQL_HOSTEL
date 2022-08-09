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
    public partial class FrmCustomers : Form
    {
        public FrmCustomers()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-MP6HDBU;Initial Catalog=Hostel;Integrated Security=True");
        //The @ sign is placed to indicate that this is an address path.

        private void ShowData()
        {
            listView1.Items.Clear();
            conn.Open();
            SqlCommand command = new SqlCommand("select * from Add_New_Customer", conn);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ListViewItem add = new ListViewItem();

                add.Text = reader["ID"].ToString();
                add.SubItems.Add(reader["CustomerName"].ToString());
                add.SubItems.Add(reader["CustomerSurname"].ToString());
                add.SubItems.Add(reader["Gender"].ToString());
                add.SubItems.Add(reader["Phone"].ToString());
                add.SubItems.Add(reader["Email"].ToString());
                add.SubItems.Add(reader["CustomerID"].ToString());
                add.SubItems.Add(reader["RoomNumber"].ToString());
                add.SubItems.Add(reader["Price"].ToString());
                add.SubItems.Add(reader["CheckinDate"].ToString());
                add.SubItems.Add(reader["CheckoutDate"].ToString());

                listView1.Items.Add(add);
            }
            conn.Close();
        }
        private void FrmCustomers_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        int id = 0;
        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id=int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            TxtName.Text = listView1.SelectedItems[0].SubItems[1].Text;
            TxtSrName.Text = listView1.SelectedItems[0].SubItems[2].Text;
            CmbxGndr.Text = listView1.SelectedItems[0].SubItems[3].Text;
            MtxtPhone.Text = listView1.SelectedItems[0].SubItems[4].Text;
            TxtMail.Text = listView1.SelectedItems[0].SubItems[5].Text;
            TxtId.Text = listView1.SelectedItems[0].SubItems[6].Text;
            TxtRoomNmbr.Text = listView1.SelectedItems[0].SubItems[7].Text;
            TxtPrice.Text = listView1.SelectedItems[0].SubItems[8].Text;
            DtpCheckInD.Text = listView1.SelectedItems[0].SubItems[9].Text;
            DtpCheckOutD.Text = listView1.SelectedItems[0].SubItems[10].Text;
        }

        private void Btndelete_Click(object sender, EventArgs e)
        {
            if (TxtRoomNmbr.Text == "101")
            {
                conn.Open();
                SqlCommand command = new SqlCommand("delete from room101", conn);
                command.ExecuteNonQuery();
                conn.Close();
                ShowData();
            }
            if (TxtRoomNmbr.Text == "102")
            {
                conn.Open();
                SqlCommand command = new SqlCommand("delete from room102", conn);
                command.ExecuteNonQuery();
                conn.Close();
                ShowData();
            }
            if (TxtRoomNmbr.Text == "103")
            {
                conn.Open();
                SqlCommand command = new SqlCommand("delete from room103", conn);
                command.ExecuteNonQuery();
                conn.Close();
                ShowData();
            }
            if (TxtRoomNmbr.Text == "104")
            {
                conn.Open();
                SqlCommand command = new SqlCommand("delete from room104", conn);
                command.ExecuteNonQuery();
                conn.Close();
                ShowData();
            }
            if (TxtRoomNmbr.Text == "105")
            {
                conn.Open();
                SqlCommand command = new SqlCommand("delete from room105", conn);
                command.ExecuteNonQuery();
                conn.Close();
                ShowData();
            }
            if (TxtRoomNmbr.Text == "106")
            {
                conn.Open();
                SqlCommand command = new SqlCommand("delete from room106", conn);
                command.ExecuteNonQuery();
                conn.Close();
                ShowData();
            }
            if (TxtRoomNmbr.Text == "107")
            {
                conn.Open();
                SqlCommand command = new SqlCommand("delete from room107", conn);
                command.ExecuteNonQuery();
                conn.Close();
                ShowData();
            }
            if (TxtRoomNmbr.Text == "108")
            {
                conn.Open();
                SqlCommand command = new SqlCommand("delete from room108", conn);
                command.ExecuteNonQuery();
                conn.Close();
                ShowData();
            }
            if (TxtRoomNmbr.Text == "109")
            {
                conn.Open();
                SqlCommand command = new SqlCommand("delete from room109", conn);
                command.ExecuteNonQuery();
                conn.Close();
                ShowData();
            }

        }

        private void Btnupdate_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand command = new SqlCommand("update Add_New_Customer set CustomerName='"+ TxtName.Text +"',CustomerSurname='"+ TxtSrName.Text +"', Gender='"+ CmbxGndr.Text +"', Phone='"+ MtxtPhone.Text +"', Email='"+ TxtMail.Text +"', CustomerID='"+ TxtId.Text +"', RoomNumber='"+ TxtRoomNmbr.Text +"', Price='"+ TxtPrice.Text +"', CheckinDate='"+ DtpCheckInD.Value.ToString("yyyy-MM-dd") +"', CheckoutDate='"+ DtpCheckOutD.Value.ToString("yyyy-MM-dd") +"' where ID=" + id +"",conn);
            command.ExecuteNonQuery();
            conn.Close();
            ShowData();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Btnfind_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            conn.Open();
            SqlCommand command = new SqlCommand("select * from Add_New_Customer where CustomerName like '%" + TxtFind.Text + "%'", conn);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ListViewItem add = new ListViewItem();

                add.Text = reader["ID"].ToString();
                add.SubItems.Add(reader["CustomerName"].ToString());
                add.SubItems.Add(reader["CustomerSurname"].ToString());
                add.SubItems.Add(reader["Gender"].ToString());
                add.SubItems.Add(reader["Phone"].ToString());
                add.SubItems.Add(reader["Email"].ToString());
                add.SubItems.Add(reader["CustomerID"].ToString());
                add.SubItems.Add(reader["RoomNumber"].ToString());
                add.SubItems.Add(reader["Price"].ToString());
                add.SubItems.Add(reader["CheckinDate"].ToString());
                add.SubItems.Add(reader["CheckoutDate"].ToString());

                listView1.Items.Add(add);
            }
            conn.Close();
        }
    }
}

// Data Source=DESKTOP-MP6HDBU;Initial Catalog=Hostel;Integrated Security=True
// SqlCommand command = new SqlCommand("delete from Add_New_Customer where ID=(" + id + ")", conn);
