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
    public partial class salesForm : Form
    {
        public salesForm()
        {
            InitializeComponent();
        }

        private void invoiceForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetInvoice.saleorder' table. You can move, or remove it, as needed.
            this.saleorderTableAdapter.Fill(this.dataSetInvoice.saleorder);
            // TODO: This line of code loads data into the 'g13Wst2024DataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.g13Wst2024DataSet.Customer);
            // TODO: This line of code loads data into the 'g13Wst2024DataSet.PartsTable' table. You can move, or remove it, as needed.
            this.partsTableTableAdapter.Fill(this.g13Wst2024DataSet.PartsTable);
           
            this.ControlBox = false;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            // Get the selected rows from both DataGridViews
            DataGridViewRow invSelectedRow = invdatagrid.SelectedRows.Count > 0 ? invdatagrid.SelectedRows[0] : null;
            DataGridViewRow custSelectedRow = custdatagrid.SelectedRows.Count > 0 ? custdatagrid.SelectedRows[0] : null;

            // If both rows are selected, add them to the DataTable
            if (invSelectedRow != null && custSelectedRow != null)
            {
                // Assuming the unique identifiers are in specific columns
                object invUniqueId = invSelectedRow.Cells[3].Value;
                object custUniqueId = custSelectedRow.Cells[1].Value;

                // Define column mappings for both DataGridViews
                var invColumnMappings = new Dictionary<int, int>
        {
            { 0, 3 }, // PartNo column in DataGridView (index 0) to PartNo column in DataTable (index 3)
            { 2, 4 }, // ItemName column in DataGridView (index 2) to ItemName column in DataTable (index 4)
            { 4, 5 }  // ItemPrice column in DataGridView (index 4) to UnitPrice column in DataTable (index 5)
        };

                var custColumnMappings = new Dictionary<int, int>
        {
            { 0, 1 }, // CustomerID column in DataGridView (index 0) to CustomerID column in DataTable (index 1)
            { 1, 2 }  // CustomerName column in DataGridView (index 1) to CustomerName column in DataTable (index 2)
        };

                // Add or update data in the DataTable
                AddOrUpdateDataFromDataGridViews(invdatagrid, custdatagrid, invColumnMappings, custColumnMappings, 3, invUniqueId, 1, custUniqueId);
            }
            else
            {
                MessageBox.Show("Please select rows from both tables.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AddOrUpdateDataFromDataGridViews(DataGridView dataGridView1, DataGridView dataGridView2, Dictionary<int, int> columnMappings1, Dictionary<int, int> columnMappings2, int uniqueColumnIndex1, object uniqueId1, int uniqueColumnIndex2, object uniqueId2)
        {
            DataRow dr = null;

            // Check if the row already exists
            foreach (DataRow row in dataSetInvoice.saleorder.Rows)
            {
                if (row.RowState == DataRowState.Deleted)
                    continue;

                if (row[uniqueColumnIndex1].Equals(uniqueId1) && row[uniqueColumnIndex2].Equals(uniqueId2))
                {
                    dr = row;
                    break;
                }
            }

            // If the row does not exist, create a new one
            if (dr == null)
            {
                dr = dataSetInvoice.saleorder.NewRow();
                dr[uniqueColumnIndex1] = uniqueId1; // Set the unique identifier
                dr[uniqueColumnIndex2] = uniqueId2; // Set the unique identifier
                dataSetInvoice.saleorder.Rows.Add(dr);
            }

            // Update the row with values from the specified columns
            foreach (var mapping in columnMappings1)
            {
                int dataGridViewColumnIndex = mapping.Key;
                int dataTableColumnIndex = mapping.Value;
                dr[dataTableColumnIndex] = dataGridView1.CurrentRow.Cells[dataGridViewColumnIndex].Value ?? DBNull.Value;
            }

            foreach (var mapping in columnMappings2)
            {
                int dataGridViewColumnIndex = mapping.Key;
                int dataTableColumnIndex = mapping.Value;
                dr[dataTableColumnIndex] = dataGridView2.CurrentRow.Cells[dataGridViewColumnIndex].Value ?? DBNull.Value;
            }
        }

        private void custdatagrid_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e) { }
        private void invdatagrid_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e) { }
    }
}
