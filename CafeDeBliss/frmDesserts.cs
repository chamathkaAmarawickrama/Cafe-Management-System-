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
    public partial class frmDesserts : Form
    {
        public frmDesserts()
        {
            InitializeComponent();
            invoiceno();
        }

        public void invoiceno()
        {
            string cs = "Data Source=AAYNIZ;Initial Catalog=CafeDeBliss;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            string sql = "SELECT TOP 1 Invoice_No FROM Invoice Order By Invoice_No DESC";
            SqlCommand com1 = new SqlCommand(sql, con);
            SqlDataReader dr = com1.ExecuteReader();
            dr.Read();
            this.txtInvoiceNo.Text = dr.GetValue(0).ToString();
            con.Close();
        }


        protected int n, Total = 0;
        private void btnCart_Click(object sender, EventArgs e)
        {
            try
            {
                string cs = "Data Source=AAYNIZ;Initial Catalog=CafeDeBliss;Integrated Security=True";
                SqlConnection con = new SqlConnection(cs);
                con.Open();

                string sql = "INSERT INTO Order1 (Invoice_id,Item_Code,Item_Name,Quantity,Price,Total) VALUES (@Invoice_id,@Item_Code,@Item_Name,@Quantity,@Price,@Total)";
                SqlCommand com1 = new SqlCommand(sql, con);

                com1.Parameters.AddWithValue("@Invoice_id", this.txtInvoiceNo.Text);
                com1.Parameters.AddWithValue("@Item_Code", this.txtCode.Text);
                com1.Parameters.AddWithValue("@Item_Name", this.guna2ComboBox1.Text);
                com1.Parameters.AddWithValue("@Quantity", this.Quantity.Value);
                com1.Parameters.AddWithValue("@Price", this.txtPrice.Text);
                com1.Parameters.AddWithValue("@Total", this.txtTotal.Text);

                com1.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            n = guna2DataGridView1.Rows.Add();
            guna2DataGridView1.Rows[n].Cells[0].Value = txtCode.Text;
            guna2DataGridView1.Rows[n].Cells[1].Value = guna2ComboBox1.Text;
            guna2DataGridView1.Rows[n].Cells[2].Value = Quantity.Value;
            guna2DataGridView1.Rows[n].Cells[3].Value = txtPrice.Text;
            guna2DataGridView1.Rows[n].Cells[4].Value = txtTotal.Text;

            Total += int.Parse(txtTotal.Text);
            labelTotal.Text = "Rs. " + Total;

        }
       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmDesserts_Load(object sender, EventArgs e)
        {
            string cs = "Data Source=AAYNIZ;Initial Catalog=CafeDeBliss;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string sql = "SELECT Item_Name FROM Items1 WHERE Item_Code LIKE 'D%'";
            SqlCommand com = new SqlCommand(sql, con);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                this.guna2ComboBox1.Items.Add(dr.GetValue(0).ToString());
            }
            con.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            this.txtCode.Clear();
            this.txtPrice.Clear();
            Quantity.ResetText();
            this.txtTotal.Clear();
        }

        private void Quantity_ValueChanged(object sender, EventArgs e)
        {
           int Q = int.Parse(Quantity.Value.ToString());
            int Price = int.Parse(txtPrice.Text);
            txtTotal.Text = (Q * Price).ToString();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void labelTotal_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            string cs = "Data Source=AAYNIZ;Initial Catalog=CafeDeBliss;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            string sql = "SELECT * FROM Items1  WHERE Item_Name = '"+this.guna2ComboBox1.Text+"'";
            SqlCommand com = new SqlCommand(sql, con);

            SqlDataAdapter dap = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            dap.Fill(ds);

            this.txtCode.Text = ds.Tables[0].Rows[0][0].ToString();
         
            this.txtPrice.Text = ds.Tables[0].Rows[0][2].ToString();

            con.Close();
        }
    }
}
