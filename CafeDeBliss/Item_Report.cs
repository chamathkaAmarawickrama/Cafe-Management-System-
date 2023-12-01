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
    public partial class Item_Report : Form
    {
        public Item_Report()
        {
            InitializeComponent();
        }

        private void Item_Report_Load(object sender, EventArgs e)
        {
            this.crystalReportViewer1.ReportSource = @"C:\Users\User\Desktop\GAD\CafeDeBliss\CafeDeBliss\ItemCrystal.rpt";
        }
    }
}
