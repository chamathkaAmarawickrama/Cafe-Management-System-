using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CafeDeBliss
{
    public partial class frmCheckOrder2 : Form
    {
        protected int n, Total = 0, billvalue;
        protected Decimal bill;
        protected DateTime bdate;

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public frmCheckOrder2()
        {
            InitializeComponent();
            takeinvoice();
           
            string cs = "Data Source=AAYNIZ;Initial Catalog=CafeDeBliss;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            string sql = "SELECT * FROM Order1 WHERE Invoice_id='" + this.txtInvoiceNo.Text + "'";
            SqlCommand com = new SqlCommand(sql, con);

            SqlDataAdapter dap = new SqlDataAdapter(com);

            DataSet ds = new DataSet();
            dap.Fill(ds);


            this.guna2DataGridView1.DataSource = ds.Tables[0];

            string sql2 = "SELECT sum(Total) FROM Order1 WHERE Invoice_id='" + this.txtInvoiceNo.Text + "'";
            SqlCommand com2 = new SqlCommand(sql2, con);

            SqlDataReader dr = com2.ExecuteReader();
            dr.Read();

            this.labelDisplay.Text = dr.GetValue(0).ToString();
            
            con.Close();
        }
        public void takeinvoice()
        {
            string cs = "Data Source=AAYNIZ;Initial Catalog=CafeDeBliss;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            string sql = "SELECT TOP 1 Invoice_id FROM Order1 ORDER BY Invoice_id DESC";
            SqlCommand com = new SqlCommand(sql, con);

            SqlDataReader dr = com.ExecuteReader();
            dr.Read();

            this.txtInvoiceNo.Text = dr.GetValue(0).ToString();

            con.Close();
        }
    }

        
    
}
