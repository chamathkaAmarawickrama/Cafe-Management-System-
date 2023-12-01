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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string status="";
            string cs = "Data Source=AAYNIZ;Initial Catalog=CafeDeBliss;Integrated Security=True";
            SqlConnection con =  new SqlConnection(cs);
            con.Open();

            string sql = "SELECT * FROM Credentials";
            SqlCommand com = new SqlCommand(sql, con);

            SqlDataReader dr =com.ExecuteReader();
            int flag = 0;
            while (dr.Read())
            {
                if(this.txtUsername.Text == dr.GetValue(1).ToString() && this.txtPassword.Text == dr.GetValue(2).ToString())
                {
                    flag = 1;
                    status=dr.GetValue(0).ToString();
                }
            }

           

            if (flag == 1)
            {
                if ( status == "Admin" )
                {
                    DashboardA frm =new DashboardA();
                    frm.Show();
                    this.Hide();
                }
                else if ( status =="Manager" )
                {
                    DashboardM frm = new DashboardM();
                    frm.Show();
                    this.Hide();
                }
                else if ( status == "Loyalty Customer")
                {
                    DashboardLC frm = new DashboardLC();
                    frm.Show();
                    this.Hide();
                }
                
            else
            {
                MessageBox.Show("Invalid Username or Password", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();


            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
