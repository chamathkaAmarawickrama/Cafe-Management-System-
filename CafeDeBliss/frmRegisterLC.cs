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
    public partial class frmRegisterLC : Form
    {
        public frmRegisterLC()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.txtCName.Clear();
            this.txtUsername.Clear();
            this.txtPassword.Clear();
            this.txtNo.Clear();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string cs = "Data Source=AAYNIZ;Initial Catalog=CafeDeBliss;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            string sql = "INSERT INTO LCustomer(Name,Username,Password,Telephone_No) VALUES (@Name,@Username,@Password,@Telephone_No)";
            SqlCommand com = new SqlCommand(sql, con);
            com.Parameters.AddWithValue("@Name", this.txtCName.Text);
            com.Parameters.AddWithValue("@Username", this.txtUsername.Text);
            com.Parameters.AddWithValue("@Password", this.txtPassword.Text);
            com.Parameters.AddWithValue("@Telephone_No", this.txtNo.Text);

            int ret = com.ExecuteNonQuery();
            MessageBox.Show("No of records inserted: " + ret, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
            con.Open();
            string sql1 = "INSERT INTO Credentials(Status,Username,Password) VALUES (@Status,@Username,@Password)";
            SqlCommand com1 = new SqlCommand(sql1, con);
            string status="Loyalty_Customer";
            com1.Parameters.AddWithValue("@Status",status);
            com1.Parameters.AddWithValue("@Username", this.txtUsername.Text);
            com1.Parameters.AddWithValue("@Password", this.txtPassword.Text);
           

            com1.ExecuteNonQuery();
            
            con.Close();

        }
    }
    }

