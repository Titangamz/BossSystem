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
    public partial class viewSales : Form
    {
        public viewSales()
        {
            InitializeComponent();
        }

        private void viewSales_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'g13Wst2024DataSet.ItemSale' table. You can move, or remove it, as needed.
            this.itemSaleTableAdapter.Fill(this.g13Wst2024DataSet.ItemSale);
            // TODO: This line of code loads data into the 'g13Wst2024DataSet.Overallsales' table. You can move, or remove it, as needed.
            this.overallsalesTableAdapter.Fill(this.g13Wst2024DataSet.Overallsales);


            this.ControlBox = false;
        }

      private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            overallsalesTableAdapter.FillByDateOfSale(g13Wst2024DataSet.Overallsales, dateTimePicker1.Value.ToShortDateString());
        }

        private void dgvsalesview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          /*  DialogResult result = MessageBox.Show("WARNING, this will permanantly alter your sales table. Proceed?", "Confirmation",
MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                salebkTableAdapter.Update(g13Wst2024DataSet.Salebk);
                salebkTableAdapter.Fill(g13Wst2024DataSet.Salebk);
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Update Cancelled");
            }*/
        }

        private void dataGridView2_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Assuming the InvoiceNumber is in the first column (index 0) of the selected row
            int invoiceNumber = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);

            // Now call FillByInvNo with the retrieved invoice number
            itemSaleTableAdapter.FillByInvNo(g13Wst2024DataSet.ItemSale, invoiceNumber);
        }
    }
}
