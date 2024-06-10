using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bosssystem1
{
    public partial class viewsuppliersform : Form
    {
        public viewsuppliersform()
        {
            InitializeComponent();
        }

        private void viewsuppliersform_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'g13Wst2024DataSet.Supplier' table. You can move, or remove it, as needed.
            this.supplierTableAdapter.Fill(this.g13Wst2024DataSet.Supplier);
            this.ControlBox = false;
        }

        private void suppsearchtxt_TextChanged(object sender, EventArgs e)
        {
            supplierTableAdapter.FillBySupplierName(g13Wst2024DataSet.Supplier, suppsearchtxt.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
