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
    public partial class frmAddNewItems : Form
    {
        public frmAddNewItems()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string cs = "Data Source=AAYNIZ;Initial Catalog=CafeDeBliss;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            string sql = "INSERT INTO Items1(Item_Code,Item_Name,Item_Price) VALUES (@Item_Code,@Item_Name,@Item_Price)";
            SqlCommand com = new SqlCommand(sql, con);
            com.Parameters.AddWithValue("@Item_Code", this.txtICode.Text);
            com.Parameters.AddWithValue("@Item_Name", this.txtIName.Text);
            com.Parameters.AddWithValue("@Item_Price", this.txtPrice.Text);

            int ret = com.ExecuteNonQuery();
            MessageBox.Show("No of records inserted: " + ret, "Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            con.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.txtICode.Clear();
            this.txtIName.Clear();
            this.txtPrice.Clear();
        }
    }
}
