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
    public partial class AddProducts : Form
    {
        public AddProducts()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtProductID.Text != "" && txtProductName.Text != "" && texProductPrice.Text != "" && texCategoryID.Text != "")
            {
                String pid = txtProductID.Text;

                String pname = txtProductName.Text;
                String pprice = texProductPrice.Text;
                String pcid = texCategoryID.Text;


                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-M9968TV;Initial Catalog=Pragati;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "Insert into Aproduct(Aproduct_id,Aproduct_Name,Category_id,Aprice) values(" + pid + ",'" + pname + "'," + pcid + "," + pprice + ");";
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Data Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtProductID.Clear();
                txtProductName.Clear();
                texProductPrice.Clear();
                texCategoryID.Clear();
            }
            else
            {
                MessageBox.Show("Empty Field NOT Allowed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will DELETE your unsaved DATA.", "Are You Sure?)", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)

            {
                this.Close();
            }
        }
    }
}
