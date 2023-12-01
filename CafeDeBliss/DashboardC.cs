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
    public partial class DashboardC : Form
    {
        public DashboardC()
        {
            InitializeComponent();
        }

        private void btnExitC_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogOutC_Click(object sender, EventArgs e)
        {
            frmStatus fm = new frmStatus();
            this.Hide();
            fm.Show();
        }

        private void btnPOrderC_Click(object sender, EventArgs e)
        {
            frmPlaceOrder ds = new frmPlaceOrder();
            ds.Show();
            
        }

        private void btnCOrderC_Click(object sender, EventArgs e)
        {
            frmCheckOrder2 ds = new frmCheckOrder2();
            ds.Show();
            
        }

        private void btnReviewC_Click(object sender, EventArgs e)
        {
            frmReviews ds = new frmReviews();
            ds.Show();
           
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            frmRegisterLC ds = new frmRegisterLC();
            ds.Show();
        }
    }
}
