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
    public partial class frmAddOffers : Form
    {
        public frmAddOffers()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string cs = "Data Source=AAYNIZ;Initial Catalog=CafeDeBliss;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            string sql = "INSERT INTO Offers(Date_Issue,Date_Expire,Offer,Value) VALUES (@Date_Issue,@Date_Expire,@Offer,@Value)";
            SqlCommand com = new SqlCommand(sql, con);
            com.Parameters.AddWithValue("@Date_Issue", Convert.ToDateTime(this.IDate.Text));
            com.Parameters.AddWithValue("@Date_Expire", Convert.ToDateTime(this.EDate.Text));
            com.Parameters.AddWithValue("@Offer", this.txtOfferRate.Text);
            com.Parameters.AddWithValue("@Value",this.txtValue.Text);

            int ret = com.ExecuteNonQuery();
            MessageBox.Show("No of records inserted: " + ret, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
        }

        private void frmAddOffers_Load(object sender, EventArgs e)
        {

        }
    }
}
