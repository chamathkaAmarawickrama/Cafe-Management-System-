using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeDeBliss
{
    public partial class DashboardM : Form
    {
        public DashboardM()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientCircleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogOutM_Click(object sender, EventArgs e)
        {
            frmStatus fm = new frmStatus();
            this.Hide();
            fm.Show();
        }

        private void btnAddItemM_Click(object sender, EventArgs e)
        {
            frmAddNewItems ds = new frmAddNewItems();
            ds.Show();
            
        }

        private void btnAddOffersM_Click(object sender, EventArgs e)
        {
            frmAddOffers ds = new frmAddOffers();
            ds.Show();
            
        }

        private void ChangePricesM_Click(object sender, EventArgs e)
        {
            frmChangePrices ds = new frmChangePrices();
            ds.Show();
            
        }

        private void brnGReportsM_Click(object sender, EventArgs e)
        {
            Reports ds = new Reports();
            ds.Show();
        }
    }
}
