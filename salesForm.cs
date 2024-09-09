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
using System.Diagnostics;

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
            
            DataGridViewRow invSelectedRow = invdatagrid.SelectedRows.Count > 0 ? invdatagrid.SelectedRows[0] : null;
            DataGridViewRow custSelectedRow = custdatagrid.SelectedRows.Count > 0 ? custdatagrid.SelectedRows[0] : null;

            
            if (invSelectedRow != null && custSelectedRow != null)
            {
                
                object invUniqueId = invSelectedRow.Cells[3].Value;
                object custUniqueId = custSelectedRow.Cells[1].Value;

               
                var invColumnMappings = new Dictionary<int, int>
        {
            { 0, 2 }, 
            { 2, 3 }, 
            { 4, 4 }  
        };

                var custColumnMappings = new Dictionary<int, int>
        {
            { 0, 0 }, 
            { 1, 1 }  
        };

               
                AddOrUpdateDataFromDataGridViews(invdatagrid, custdatagrid, invColumnMappings, custColumnMappings, 3, invUniqueId, 1, custUniqueId);
            }
            else
            {
                MessageBox.Show("Please select rows from both tables.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            custdatagrid.Enabled = false;
        }

        private void AddOrUpdateDataFromDataGridViews(DataGridView dataGridView1, DataGridView dataGridView2, Dictionary<int, int> columnMappings1, Dictionary<int, int> columnMappings2, int uniqueColumnIndex1, object uniqueId1, int uniqueColumnIndex2, object uniqueId2)
        {
            DataRow dr = null;

          
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

           
            if (dr == null)
            {
                dr = dataSetInvoice.saleorder.NewRow();
                dr[uniqueColumnIndex1] = uniqueId1; 
                dr[uniqueColumnIndex2] = uniqueId2;
                dataSetInvoice.saleorder.Rows.Add(dr);
            }

           
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

            if (e.RowIndex < 0 || e.ColumnIndex < 0) return; 

            
            DataGridView dataGridView = sender as DataGridView;
            if (dataGridView.Columns[e.ColumnIndex].Name == "Quantity")
            {
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];

                object unitPriceObj = row.Cells["unitPriceDataGridViewTextBoxColumn"].Value;
                object quantityObj = row.Cells["Quantity"].Value;

                
                if (unitPriceObj != null && quantityObj != null)
                {
                    decimal unitPrice, quantity;

                   
                    if (decimal.TryParse(unitPriceObj.ToString(), out unitPrice) &&
                        decimal.TryParse(quantityObj.ToString(), out quantity))
                    {                       
                        decimal rowTotal = unitPrice * quantity;                      
                        row.Cells["RowTotal"].Value = rowTotal;
                    }
                    else
                    {
                        MessageBox.Show("Please add a quantity");
                    }
                }
                else
                {
                    MessageBox.Show("Please add a quantity");
                }
            }
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            string totalColumnName = "RowTotal"; 
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
            custdatagrid.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Do you want to Confirm?", "Confirmation",
 MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (ordtotaltxt.Text == "")
                {
                    MessageBox.Show("Please get the order total before recording the order");
                }
                else
                {
                    int? lastInvoiceNumber = overallsalesTableAdapter.GetInvoiceNumber();
                    int newInvoiceNumber = (lastInvoiceNumber ?? 0) + 1;

                    // Check if there's enough stock for all items before processing the sale
                    bool hasEnoughStock = true;
                    foreach (DataGridViewRow row in saledatagrid.Rows)
                    {
                        try
                        {
                            var PartNoValue = row.Cells[2].Value.ToString().Trim();
                            var quantityValue = row.Cells[5].Value?.ToString();

                            if (string.IsNullOrEmpty(PartNoValue) || string.IsNullOrEmpty(quantityValue))
                            {
                                MessageBox.Show("PartNo or Quantity is empty.");
                                hasEnoughStock = false;
                                break;
                            }

                            int partNo = int.Parse(PartNoValue);
                            int quantity = int.Parse(quantityValue);

                            // Get the current quantity in the parts table
                            int? currentQuantity = partsTableTableAdapter.GetQuantity(partNo);

                            // Check if there's enough stock
                            if (currentQuantity < quantity)
                            {
                                MessageBox.Show($"Not enough stock for Part No: {partNo}. Available quantity: {currentQuantity}");
                                hasEnoughStock = false;
                                break;
                            }
                        }
                        catch (NullReferenceException ex)
                        {
                           
                        }
                    }

                    if (hasEnoughStock)
                    {
                        try
                        {
                            // Get values from the first row to perform the insert just once.
                            var firstRow = saledatagrid.Rows[0];
                            var custIDValue = firstRow.Cells[0].Value.ToString();
                            var paytypeValue = comboBox1.Text;
                            var custname = firstRow.Cells[1].Value.ToString();
                            decimal amtPaid = 0;

                            // Insert into the overallsalesTableAdapter once, outside of the loop.
                            overallsalesTableAdapter.InsertQuery(newInvoiceNumber, int.Parse(custIDValue), Convert.ToDecimal(ordtotaltxt.Text), paytypeValue, Convert.ToString(DateTime.Now));
                            custPaymentsTableAdapter.Insert(newInvoiceNumber, null, amtPaid, Convert.ToDecimal(ordtotaltxt.Text));

                            foreach (DataGridViewRow row in saledatagrid.Rows)
                            {
                                try
                                {
                                    var PartNoValue = row.Cells[2].Value.ToString().Trim();
                                    var rowtotalValue = row.Cells[6].Value?.ToString();
                                    var quantityValue = row.Cells[5].Value?.ToString();

                                    if (string.IsNullOrEmpty(PartNoValue) || string.IsNullOrEmpty(quantityValue))
                                    {
                                        MessageBox.Show("PartNo or Quantity is empty.");
                                        continue;
                                    }

                                    int partNo = int.Parse(PartNoValue);
                                    int quantity = int.Parse(quantityValue);

                                    // Insert into item sale table
                                    itemSaleTableAdapter1.Insert(newInvoiceNumber, partNo, quantityValue, Convert.ToDecimal(rowtotalValue));

                                    // Decrease quantity in parts table
                                    int rowsAffected = partsTableTableAdapter.UpdateQuantity(quantity, partNo);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("An error occurred: " + ex.Message);
                                }
                            }
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Error, please ensure all fields are filled in.");
                        }

                        MessageBox.Show("Order has been Confirmed with Invoice No: " + newInvoiceNumber);
                    }
                    else
                    {
                        MessageBox.Show("Sale NOT Processed due to insufficient stock.");
                    }
                }
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Sale NOT Processed");
            }



        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
