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
    public partial class DashboardA : Form
    {
        public DashboardA()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientCircleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLOut_Click(object sender, EventArgs e)
        {
            frmStatus fm = new frmStatus();
            this.Hide();
            fm.Show();
        }

        private void btnIssueCred_Click(object sender, EventArgs e)
        {
            frmAddCredentials frm = new frmAddCredentials();
            frm.Show();
            
        }
    }
}
