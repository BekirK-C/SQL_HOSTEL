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
    public partial class FrmIncomeExpense : Form
    {
        public FrmIncomeExpense()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-MP6HDBU;Initial Catalog=Hostel;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            // Total Income
            conn.Open();
            SqlCommand command = new SqlCommand("select sum(price) as totalincome from Add_New_Customer",conn);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                LblIncome.Text = reader["totalincome"].ToString();
            }
            conn.Close();

            int staffSalary=7500,StaffNumber=4;
            TxtNumber.Text = StaffNumber.ToString();
            TxtSalary.Text = staffSalary.ToString();
            LblSalaries.Text = (StaffNumber * staffSalary).ToString();

            // Total Expense of Product
            conn.Open();
            SqlCommand command2 = new SqlCommand("select sum(Food+Material) as totalexpenseP from [Expense of Products]", conn);
            SqlDataReader reader2 = command2.ExecuteReader();

            while (reader2.Read())
            {
                LblExpense.Text = reader2["totalexpenseP"].ToString();
            }
            conn.Close();

            // Total Bills
            conn.Open();
            SqlCommand command3 = new SqlCommand("select sum(Electiricity+Water+Internet) as totalBills from Bills", conn);
            SqlDataReader reader3 = command3.ExecuteReader();

            while (reader3.Read())
            {
                LblBills.Text = reader3["totalBills"].ToString();
            }
            conn.Close();

            // Balance
            int balance;
            balance = Convert.ToInt32(LblIncome.Text) - (Convert.ToInt32(LblSalaries.Text) + Convert.ToInt32(LblBills.Text) + Convert.ToInt32(LblExpense.Text));
            LblBalance.Text = balance.ToString();
        }
    }
}
