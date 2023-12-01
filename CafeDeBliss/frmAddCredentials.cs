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
    public partial class frmAddCredentials : Form
    {
        public frmAddCredentials()
        {
            InitializeComponent();
        }

        private void guna2GradientCircleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string cs = "Data Source=AAYNIZ;Initial Catalog=CafeDeBliss;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            string sql = "INSERT INTO Credentials(Username,Password) VALUES (@Username,@Password)";
            SqlCommand com = new SqlCommand(sql, con);
            
            com.Parameters.AddWithValue("@Username", this.txtUsername.Text);
            com.Parameters.AddWithValue("@Password", this.txtPassword.Text);

            int ret = com.ExecuteNonQuery();
            MessageBox.Show("No of records inserted: " + ret, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
        }

        private void frmAddCredentials_Load(object sender, EventArgs e)
        {

        }
    }
}
