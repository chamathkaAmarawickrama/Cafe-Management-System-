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
    public partial class DashboardLC : Form
    {
        public DashboardLC()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            frmCheckOrder ds = new frmCheckOrder();
            ds.Show();
            
        }

        private void btnLCExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogOutLC_Click(object sender, EventArgs e)
        {
            frmStatus fm = new frmStatus();
            this.Hide();
            fm.Show();
        }

        private void btnPlaceOrderLC_Click(object sender, EventArgs e)
        {
            frmPlaceOrder ds = new frmPlaceOrder();
            ds.Show();
            
        }

        private void btnReviewsLC_Click(object sender, EventArgs e)
        {
            frmReviews ds = new frmReviews();
            ds.Show();
            
        }
    }
}
