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
    public partial class frmReviews : Form
    {
        public frmReviews()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string cs = "Data Source=AAYNIZ;Initial Catalog=CafeDeBliss;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            string sql = "INSERT INTO Review1 (Username,Review) VALUES(@Username,@Review)";
            SqlCommand com = new SqlCommand(sql, con);

            com.Parameters.AddWithValue("@Username", this.txtUsername.Text);
            com.Parameters.AddWithValue("@Review", this.txtReview.Text);


            int ret = com.ExecuteNonQuery();
            MessageBox.Show("Your Feedback is saved! Thank you!: " , "Information",MessageBoxButtons.OK,MessageBoxIcon.Information);

            con.Close();
        }
    }
}
