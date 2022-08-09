using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;          //Libraries required for us 
using System.Data.SqlClient;    //to use sql commands

namespace SQL_HOSTEL
{
    public partial class FrmNewCustomer : Form
    {
        public FrmNewCustomer()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-MP6HDBU;Initial Catalog=Hostel;Integrated Security=True");
        //The @ sign is placed to indicate that this is an address path.
        private void BtnRoom101_Click(object sender, EventArgs e)
        {
            TxtRoomNmbr.Text = "101";
            conn.Open();
            SqlCommand command = new SqlCommand("insert into Room101 (Name,Surname) values ('" + TxtName.Text + "', '" + TxtSrName.Text + "')", conn);
            command.ExecuteNonQuery();
            conn.Close();
        }

        private void BtnRoom102_Click(object sender, EventArgs e)
        {
            TxtRoomNmbr.Text = "102";
            conn.Open();
            SqlCommand command = new SqlCommand("insert into Room102 (Name,Surname) values ('" + TxtName.Text + "', '" + TxtSrName.Text + "')", conn);
            command.ExecuteNonQuery();
            conn.Close();
        }

        private void BtnRoom103_Click(object sender, EventArgs e)
        {
            TxtRoomNmbr.Text = "103";
            conn.Open();
            SqlCommand command = new SqlCommand("insert into Room103 (Name,Surname) values ('" + TxtName.Text + "', '" + TxtSrName.Text + "')", conn);
            command.ExecuteNonQuery();
            conn.Close();
        }

        private void BtnRoom104_Click(object sender, EventArgs e)
        {
            TxtRoomNmbr.Text = "104";
            conn.Open();
            SqlCommand command = new SqlCommand("insert into Room104 (Name,Surname) values ('" + TxtName.Text + "', '" + TxtSrName.Text + "')", conn);
            command.ExecuteNonQuery();
            conn.Close();
        }

        private void BtnRoom105_Click(object sender, EventArgs e)
        {
            TxtRoomNmbr.Text = "105";
            conn.Open();
            SqlCommand command = new SqlCommand("insert into Room105 (Name,Surname) values ('" + TxtName.Text + "', '" + TxtSrName.Text + "')", conn);
            command.ExecuteNonQuery();
            conn.Close();
        }

        private void BtnRoom106_Click(object sender, EventArgs e)
        {
            TxtRoomNmbr.Text = "106";
            conn.Open();
            SqlCommand command = new SqlCommand("insert into Room106 (Name,Surname) values ('" + TxtName.Text + "', '" + TxtSrName.Text + "')", conn);
            command.ExecuteNonQuery();
            conn.Close();
        }

        private void BtnRoom107_Click(object sender, EventArgs e)
        {
            TxtRoomNmbr.Text = "107";
            conn.Open();
            SqlCommand command = new SqlCommand("insert into Room107 (Name,Surname) values ('" + TxtName.Text + "', '" + TxtSrName.Text + "')", conn);
            command.ExecuteNonQuery();
            conn.Close();
        }

        private void BtnRoom108_Click(object sender, EventArgs e)
        {
            TxtRoomNmbr.Text = "108";
            conn.Open();
            SqlCommand command = new SqlCommand("insert into Room108 (Name,Surname) values ('" + TxtName.Text + "', '" + TxtSrName.Text + "')", conn);
            command.ExecuteNonQuery();
            conn.Close();
        }

        private void BtnRoom109_Click(object sender, EventArgs e)
        {
            TxtRoomNmbr.Text = "109";
            conn.Open();
            SqlCommand command = new SqlCommand("insert into Room109 (Name,Surname) values ('" + TxtName.Text + "', '" + TxtSrName.Text + "')", conn);
            command.ExecuteNonQuery();
            conn.Close();
        }

        private void BtnFullRoom_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Red Ones Are Full!");
        }

        private void BtnEmpRoom_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Green Ones Are Empty!");
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand command = new SqlCommand("insert into Add_New_Customer (CustomerName,CustomerSurname,Gender,Phone,Email,CustomerID,RoomNumber,Price,CheckinDate,CheckoutDate) values ('" + TxtName.Text + "', '" + TxtSrName.Text + "', '" + CmbxGndr.Text + "', '" + MtxtPhone.Text + "', '" + TxtMail.Text + "', '" + TxtId.Text + "', '" + TxtRoomNmbr.Text + "', '" + TxtPrice.Text + "', '" + DtpCheckInD.Value.ToString("yyyy-MM-dd") + "', '" + DtpCheckOutD.Value.ToString("yyyy-MM-dd") + "')", conn);
            //Associate connection with sql command
            //note: converting date to string in sql format

            command.ExecuteNonQuery();    //using for modifying the data
            conn.Close();
            MessageBox.Show("Customer is successfully saved!");
        }

        private void DtpCheckOutD_ValueChanged(object sender, EventArgs e)
        {
            //While it can be used to get information about DateTime such as day, month, year, hour, second.
            //TimeSpan it is used to represent the difference between two dates.

            int Price;
            DateTime FirstDate = Convert.ToDateTime(DtpCheckInD.Text);
            DateTime LastDate = Convert.ToDateTime(DtpCheckOutD.Text);
            TimeSpan result = LastDate - FirstDate;

            label11.Text = result.TotalDays.ToString();   //Time difference is written in days

            Price = Convert.ToInt32(label11.Text) * 50;   //The time difference determined as days is converted to int type and multiplied by the daily price.
            TxtPrice.Text = Price.ToString();             //This value is written by converting to string
        }

        private void FrmNewCustomer_Load(object sender, EventArgs e)
        {
            // Room101
            conn.Open();
            SqlCommand command = new SqlCommand("select * from Room101", conn);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                BtnRoom101.Text = reader["Name"].ToString() + " " + reader["Surname"].ToString();
            }
            conn.Close();

            if (BtnRoom101.Text != "101")
            {
                BtnRoom101.BackColor = Color.Red;
                BtnRoom101.Enabled = false;
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
                BtnRoom102.Enabled = false;
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
                BtnRoom103.Enabled = false;
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
                BtnRoom104.Enabled = false;
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
                BtnRoom105.Enabled = false;
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
                BtnRoom106.Enabled = false;
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
                BtnRoom107.Enabled = false;
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
                BtnRoom108.Enabled = false;
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
                BtnRoom109.Enabled = false;
            }
        }
    }
}

// Data Source=DESKTOP-MP6HDBU;Initial Catalog=Hostel;Integrated Security=True