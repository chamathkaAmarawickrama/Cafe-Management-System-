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
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSR_Click(object sender, EventArgs e)
        {
            Sales_Report frm = new Sales_Report();
            
            frm.Show();
        }

        private void btnRR_Click(object sender, EventArgs e)
        {
            Review_Report frm = new Review_Report();
  
            frm.Show();
        }

        private void btnCReport_Click(object sender, EventArgs e)
        {

        }

        private void Reports_Load(object sender, EventArgs e)
        {

        }

        private void btnItemsReport_Click(object sender, EventArgs e)
        {
            Item_Report frm = new Item_Report();
            frm.Show();
        }
    }
}
