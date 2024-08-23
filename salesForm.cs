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


                    int? lastInvoiceNumber = overall_salesTableAdapter1.GetInvoiceNumber();
                    int newInvoiceNumber = (lastInvoiceNumber ?? 0) + 1;
                    foreach (DataGridViewRow row in saledatagrid.Rows)
                    {
                        if (row.IsNewRow) continue;


                        var PartNoValue = row.Cells[2].Value?.ToString();
                        var custIDValue = row.Cells[0].Value?.ToString();
                        var paytypeValue = row.Cells[7].Value?.ToString();
                        var rowtotalValue = row.Cells[6].Value?.ToString();
                        var quantityValue = row.Cells[5].Value?.ToString();

                        try
                        {
                            
                            overall_salesTableAdapter1.InsertByAllSale(newInvoiceNumber, int.Parse(custIDValue), Convert.ToDecimal(rowtotalValue), paytypeValue, Convert.ToString(DateTime.Now), null, null);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Error, please ensure all fields are filled in");
                        }

                    }
                    MessageBox.Show("Order has been Confirmed with Invoice No: " + newInvoiceNumber);
                }
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Sale NOT Processed");
            }
            


        }
    }
}
