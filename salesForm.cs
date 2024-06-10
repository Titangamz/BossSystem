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
            // TODO: This line of code loads data into the 'dataSetInvoice.saleorder' table. You can move, or remove it, as needed.
            this.saleorderTableAdapter.Fill(this.dataSetInvoice.saleorder);
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
            { 0, 2 }, // PartNo column in DataGridView (index 0) to PartNo column in DataTable (index 3)
            { 2, 3 }, // ItemName column in DataGridView (index 2) to ItemName column in DataTable (index 4)
            { 4, 4 }  // ItemPrice column in DataGridView (index 4) to UnitPrice column in DataTable (index 5)
        };

                var custColumnMappings = new Dictionary<int, int>
        {
            { 0, 0 }, // CustomerID column in DataGridView (index 0) to CustomerID column in DataTable (index 1)
            { 1, 1 }  // CustomerName column in DataGridView (index 1) to CustomerName column in DataTable (index 2)
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

        private void saledatagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void saledatagrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0 || e.ColumnIndex < 0) return; // Check for valid row and column indices

            // Check if the changed cell is in the Quantity column
            DataGridView dataGridView = sender as DataGridView;
            if (dataGridView.Columns[e.ColumnIndex].Name == "Quantity")
            {
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];

                object unitPriceObj = row.Cells["unitPriceDataGridViewTextBoxColumn"].Value;
                object quantityObj = row.Cells["Quantity"].Value;

                // Check for null values
                if (unitPriceObj != null && quantityObj != null)
                {
                    decimal unitPrice, quantity;

                    // Try parsing cell values to decimal
                    if (decimal.TryParse(unitPriceObj.ToString(), out unitPrice) &&
                        decimal.TryParse(quantityObj.ToString(), out quantity))
                    {
                        // Calculate the RowTotal
                        decimal rowTotal = unitPrice * quantity;

                        // Update the RowTotal cell
                        row.Cells["RowTotal"].Value = rowTotal;
                    }
                    else
                    {
                        // Handle parsing errors
                    }
                }
                else
                {
                    // Handle null values
                }
            }
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            string totalColumnName = "RowTotal"; // Name of the column to sum
            decimal total = 0;

            foreach (DataGridViewRow row in saledatagrid.Rows)
            {
                if (!row.IsNewRow)
                {
                    if (decimal.TryParse(row.Cells[totalColumnName].Value?.ToString(), out decimal value))
                    {
                        total += value;
                    }
                }
            }

            ordtotaltxt.Text = total.ToString();
        }

        private void deleterowsbtn_Click(object sender, EventArgs e)
        {
            dataSetInvoice.Clear();
            ordtotaltxt.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {

            int? lastInvoiceNumber = salebkTableAdapter1.GetLastInvoiceNumber();
            int newInvoiceNumber = (lastInvoiceNumber ?? 0) + 1;
            foreach (DataGridViewRow row in saledatagrid.Rows)
            {
                if (row.IsNewRow) continue;

                // Extract values from the row
                var PartNoValue = row.Cells[2].Value?.ToString();
                var custIDValue = row.Cells[0].Value?.ToString();
                var paytypeValue = row.Cells[7].Value?.ToString();
                // Add more columns as needed
                try
                {
                    // Insert the row into the database using the TableAdapter
                    salebkTableAdapter1.Insert(newInvoiceNumber,int.Parse(PartNoValue), int.Parse(custIDValue), DateTime.Now, paytypeValue, Convert.ToDecimal(ordtotaltxt.Text), null, null);
                   
                  
                }
                catch (Exception)
                {

                    MessageBox.Show("Error, please ensure all fields are filled in");
                }
                MessageBox.Show("Order has been Confirmed with Order No: " + newInvoiceNumber);
            }

            // Optionally refresh the DataGridView
            
        }
    }
}
