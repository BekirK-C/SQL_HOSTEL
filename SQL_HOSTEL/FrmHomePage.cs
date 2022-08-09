using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_HOSTEL
{
    public partial class FrmHomePage : Form
    {
        public FrmHomePage()
        {
            InitializeComponent();
        }

        private void BtnAddNewCust_Click(object sender, EventArgs e)
        {
            FrmNewCustomer fr = new FrmNewCustomer();
            fr.Show();
            //this.Hide();
        }

        private void BtnRooms_Click(object sender, EventArgs e)
        {
            FrmRooms fr = new FrmRooms();
            fr.Show();
            //this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCustomers fr = new FrmCustomers();
            fr.Show();
            //this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmIncomeExpense fr = new FrmIncomeExpense();
            fr.Show();
            //this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmStockPrices fr = new FrmStockPrices();
            fr.Show();
            //this.Hide();
        }
    }
}
