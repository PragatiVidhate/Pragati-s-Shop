using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pragati
{
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtsearch.Clear();
            panel1.Visible = false;
        }

        private void Products_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-M9968TV;Initial Catalog=Pragati;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from Aproduct Where Aproduct_id LIKE'" + txtsearch.Text + "' ";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        int bid;

        private void DataGridViewCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());

                //MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());   

            }

            panel1.Visible = true;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-M9968TV;Initial Catalog=Pragati;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from Aproduct where Aproduct_id=" + bid + "";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            //rowid = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
            txtProductsID.Text = ds.Tables[0].Rows[0][0].ToString();
            textProductsName.Text = ds.Tables[0].Rows[0][1].ToString();
            texProductPrice.Text = ds.Tables[0].Rows[0][2].ToString();
            texCategoryId.Text = ds.Tables[0].Rows[0][3].ToString();
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data Will be Updated.Confirm?", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                String pid = txtProductsID.Text;
                String pname = textProductsName.Text;
                String ptp = texProductPrice.Text;
                String cid = texCategoryId.Text;


                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-M9968TV;Initial Catalog=Pragati;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "Update Aproduct set Aproduct_Name='" + pname + "',Aprice =" + ptp + " Where Aproduct_id=" + pid + "";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
            }
        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data Will be Deleted.Confirm?", "Conformation Dialog", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-M9968TV;Initial Catalog=Pragati;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "Delete from Aproduct where Category_id="+ texCategoryId.Text + "";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

            }
        }

        private void bCancle_Click(object sender, EventArgs e)
        {
            Form1 Form = new Form1();
            Form.Show();
        }

        private void Textchange(object sender, EventArgs e)
        {
            if (txtsearch.Text != " ")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-M9968TV;Initial Catalog=Pragati;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from Aproduct where Aproduct_Name like'" + txtsearch.Text + "%'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

            }
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-M9968TV;Initial Catalog=Pragati;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from Aproduct";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
