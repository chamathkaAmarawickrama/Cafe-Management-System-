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
    public partial class frmPlaceOrder : Form
    {
        public frmPlaceOrder()
        {
            InitializeComponent();
            invoiceno();
        }

        SqlConnection con1 = new SqlConnection("Data Source=AAYNIZ;Initial Catalog=CafeDeBliss;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter ds1;
        SqlDataReader dr1;
        string sql1;
        public void invoiceno()
        {
            try
            {
                sql1 = "SELECT MAX(Invoice_No) FROM Invoice";
                cmd = new SqlCommand(sql1, con1);
                con1.Open();
                var maxid = cmd.ExecuteScalar() as string;

                if (maxid == null)
                {
                    txtInvoiceNo.Text = "E-000001";
                }
                else
                {
                    int intval = int.Parse(maxid.Substring(2, 6)); ;
                    intval++;
                    txtInvoiceNo.Text = String.Format("E-{0:000000}", intval);
                }
                con1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            saveinvoice();
        }
        public void saveinvoice()
        {
            string cs = "Data Source=AAYNIZ;Initial Catalog=CafeDeBliss;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            string sql = "INSERT INTO Invoice (Invoice_No) VALUES(@Invoice_No)";
            SqlCommand com = new SqlCommand(sql, con);

            com.Parameters.AddWithValue("@Invoice_No", this.txtInvoiceNo.Text);
            com.ExecuteNonQuery();
            con.Close();

        }
        private void frmPlaceOrder_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFasttF_Click(object sender, EventArgs e)
        {
            frmFastfood frm = new frmFastfood();
            frm.Show();
            
        }

        private void btnDesserts_Click(object sender, EventArgs e)
        {
            frmDesserts frm = new frmDesserts();
            frm.Show();
            
        }

        private void btnBeverages_Click(object sender, EventArgs e)
        {
            frmBeverages frm = new frmBeverages();
            frm.Show();
            
        }
    }
}
