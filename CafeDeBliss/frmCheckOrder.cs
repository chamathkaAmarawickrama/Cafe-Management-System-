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
    public partial class frmCheckOrder : Form
    {
        protected int n, Total = 0, billvalue;
        protected Decimal bill;
        protected DateTime bdate;
        public frmCheckOrder()
        {
            InitializeComponent();
            takeinvoice();
            takeoffer();
            string cs = "Data Source=AAYNIZ;Initial Catalog=CafeDeBliss;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            string sql = "SELECT * FROM Order1 WHERE Invoice_id='"+this.txtInvoiceNo.Text+"'";
            SqlCommand com = new SqlCommand(sql, con);

            SqlDataAdapter dap = new SqlDataAdapter(com);
            
            DataSet ds = new DataSet();
            dap.Fill(ds);


            this.guna2DataGridView1.DataSource=ds.Tables[0];

            string sql2 = "SELECT sum(Total) FROM Order1 WHERE Invoice_id='" + this.txtInvoiceNo.Text + "'";
            SqlCommand com2 = new SqlCommand(sql2, con);

            SqlDataReader dr = com2.ExecuteReader();
            dr.Read();

            this.labelDisplay.Text = dr.GetValue(0).ToString();
            int BB = Convert.ToInt32(this.labelDisplay.Text);
            bill = Convert.ToDecimal(this.labeldiscountvale.Text);
            if (BB >= billvalue)
            {
                this.labelfinalvalue.Text = (BB -((BB*bill)/100)).ToString();
            }
            else
            {
                this.labelfinalvalue.Text = this.labelDisplay.Text;
            }
            con.Close();
        }
        public void takeoffer()

        {
            string cs = "Data Source=AAYNIZ;Initial Catalog=CafeDeBliss;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            
            
            string sql = "SELECT Offer,value FROM Offers WHERE Date_Issue<=(SELECT GETDATE()) AND Date_Expire>=(SELECT GETDATE())  ";
            SqlCommand com6 = new SqlCommand(sql, con);
            

            SqlDataReader dr1 = com6.ExecuteReader();
            dr1.Read();

            this.labeldiscountvale.Text = dr1.GetValue(0).ToString();
             billvalue= Convert.ToInt32(dr1.GetValue(1));

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
       
        public  frmCheckOrder(string code, string name,string price, string quantity,string total)
        {
            InitializeComponent();
            
        }
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void labelDisplay_Click(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmCheckOrder_Load(object sender, EventArgs e)
        {

        }

        private void txtInvoiceNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }
    }
}
