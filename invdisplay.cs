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
    public partial class invdisplay : Form
    {

        salesForm salefrm = new salesForm();
        public invdisplay()
        {
            InitializeComponent();
        }

        private void invdisplay_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'g13Wst2024DataSet.PartsTable' table. You can move, or remove it, as needed.
            this.partsTableTableAdapter.Fill(this.g13Wst2024DataSet.PartsTable);

        }
        public DialogResult ShowAsMessageBox()
        {
            return MessageBox.Show(this, "Select a part to add to the invoice", "Inventory", MessageBoxButtons.OKCancel);
        }
        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                // Assuming the column indices or names in the DataGridView correspond to the source columns
                object column1Value = dataGridView1.Rows[e.RowIndex].Cells["PartNo"].Value;
                object column2Value = dataGridView1.Rows[e.RowIndex].Cells["ItemName"].Value;
                object column3Value = dataGridView1.Rows[e.RowIndex].Cells["ItemPrice"].Value;

                // Send selected columns to Form 2
                salefrm.TransferRow(column1Value, column2Value, column3Value);
            }
        }

        public object GetColumn1ValueFromForm1()
        {
            if (dataGridView1.CurrentRow != null)
            {
                return dataGridView1.CurrentRow.Cells["PartNo"].Value;
            }
            return null; // Return null if no row is selected or column value is not available
        }

        // Method to get the value of the second column from the selected row in Form 1
        public object GetColumn2ValueFromForm1()
        {
            if (dataGridView1.CurrentRow != null)
            {
                return dataGridView1.CurrentRow.Cells["ItemName"].Value;
            }
            return null; // Return null if no row is selected or column value is not available
        }

        // Method to get the value of the third column from the selected row in Form 1
        public object GetColumn3ValueFromForm1()
        {
            if (dataGridView1.CurrentRow != null)
            {
                return dataGridView1.CurrentRow.Cells["ItemPrice"].Value;
            }
            return null; // Return null if no row is selected or column value is not available
        }
    }
}
