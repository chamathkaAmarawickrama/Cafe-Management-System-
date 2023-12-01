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
    public partial class frmChangePrices : Form
    {
        public frmChangePrices()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.txtICode.Clear();
            this.txtPrice.Clear();
            this.txtIName.Clear();

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            string cs = "Data Source=AAYNIZ;Initial Catalog=CafeDeBliss;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            string sql = "UPDATE Items1 SET  Item_Name=@Item_Name, Item_Price=@Item_Price WHERE Item_Code=@Item_Code";
            SqlCommand com = new SqlCommand(sql, con);

            com.Parameters.AddWithValue("@Item_Code",this.txtICode.Text);
            com.Parameters.AddWithValue("@Item_Name", this.txtIName.Text);
            com.Parameters.AddWithValue("@Item_Price", this.txtPrice.Text);

            int ret = com.ExecuteNonQuery();
            MessageBox.Show("No of records Updated: " + ret, "Information",MessageBoxButtons.OK,MessageBoxIcon.Information);

            con.Close();
        }

        private void frmChangePrices_Load(object sender, EventArgs e)
        {

        }
    }
}
