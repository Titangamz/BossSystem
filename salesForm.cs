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

        /* private void FillDataTableFromDataGridView(DataGridView dataGridView, DataTable dataTable, int[] columnIndexesToCopy)
         {
             // Find the unique identifier of the current row (assuming the first column is unique)
             object uniqueId = dataGridView.CurrentRow.Cells[0].Value;
             DataRow dr = dataSetInvoice.saleorder.Rows.Find(uniqueId);

             if (dr == null)
             {
                 // If the row does not exist, create a new one
                 dr = dataSetInvoice.saleorder.NewRow();
                 dr[0] = uniqueId; // Set the unique identifier
                 for (int i = 0; i < dataSetInvoice.saleorder.Columns.Count; i++)
                 {
                     if (Array.IndexOf(columnIndexesToCopy, i) == -1)
                     {
                         dr[i] = DBNull.Value; // Initialize non-copied columns to DBNull
                     }
                 }
                 dataSetInvoice.saleorder.Rows.Add(dr);
             }

             // Update the row with values from the specified columns
             foreach (int columnIndex in columnIndexesToCopy)
             {
                 dr[columnIndex] = dataGridView.CurrentRow.Cells[columnIndex].Value;
             }
         }*/



        private void invdatagrid_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var columnMappings = new Dictionary<int, int>
    {
        { 0, 3 }, // PartNo column in DataGridView (index 0) to PartNo column in DataTable (index 3)
        { 2, 4 }, // ItemName column in DataGridView (index 2) to ItemName column in DataTable (index 4)
        { 4, 5 }  // ItemPrice column in DataGridView (index 4) to UnitPrice column in DataTable (index 5)
    };
            AddOrUpdateDataFromDataGridView(invdatagrid, columnMappings, 3, e.RowIndex);
        }

        private void custdatagrid_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var columnMappings = new Dictionary<int, int>
    {
        { 0, 1 }, // CustomerID column in DataGridView (index 0) to CustomerID column in DataTable (index 1)
        { 1, 2 }  // CustomerName column in DataGridView (index 1) to CustomerName column in DataTable (index 2)
    };
            AddOrUpdateDataFromDataGridView(custdatagrid, columnMappings, 1, e.RowIndex);
        }

        private void AddOrUpdateDataFromDataGridView(DataGridView dataGridView, Dictionary<int, int> columnMappings, int uniqueColumnIndex, int rowIndex)
        {
            // Find the unique identifier of the current row
            object uniqueId = dataGridView.Rows[rowIndex].Cells[uniqueColumnIndex].Value;
            DataRow dr = null;

            // Check if the row already exists
            foreach (DataRow row in dataSetInvoice.saleorder.Rows)
            {
                if (row[uniqueColumnIndex].Equals(uniqueId))
                {
                    dr = row;
                    break;
                }
            }

            // If the row does not exist, create a new one
            if (dr == null)
            {
                dr = dataSetInvoice.saleorder.NewRow();
                dr[uniqueColumnIndex] = uniqueId; // Set the unique identifier
                dataSetInvoice.saleorder.Rows.Add(dr);
            }

            // Update the row with values from the specified columns
            foreach (var mapping in columnMappings)
            {
                int dataGridViewColumnIndex = mapping.Key;
                int dataTableColumnIndex = mapping.Value;
                dr[dataTableColumnIndex] = dataGridView.Rows[rowIndex].Cells[dataGridViewColumnIndex].Value ?? DBNull.Value;
            }
        }


    }
}
