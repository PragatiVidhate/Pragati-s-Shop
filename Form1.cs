using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pragati
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addNewCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            AddCategory AC = new AddCategory();
            AC.Show();
        }

        private void viewCategoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewC viewC = new ViewC();
            viewC.Show();
        }

        private void addNewProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProducts addProducts = new AddProducts();
            addProducts.Show();
        }

        private void viewProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Products viewProducts = new Products();
            viewProducts.Show();
        }
    }
}
