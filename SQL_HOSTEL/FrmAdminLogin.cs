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
    public partial class FrmAdminLogin : Form
    {
        public FrmAdminLogin()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-MP6HDBU;Initial Catalog=Hostel;Integrated Security=True");
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string sql = "select * from Admin_Login where User_Name = @User_Name_ and Password = @Password_";
                SqlParameter Prmtr1 = new SqlParameter("User_Name_", TxtUserName.Text.Trim());
                SqlParameter Prmtr2 = new SqlParameter("Password_", TxtPassword.Text.Trim());
                SqlCommand command = new SqlCommand(sql, conn);
                command.Parameters.Add(Prmtr1);
                command.Parameters.Add(Prmtr2);

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(command);

                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    FrmHomePage fr = new FrmHomePage();
                    fr.Show();
                    this.Hide();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Login Failed!");
            }
        }
    }
}
