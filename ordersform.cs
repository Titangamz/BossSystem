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
    public partial class ordersform : Form
    {
        public ordersform()
        {
            InitializeComponent();
        }

        private void ordersform_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'g13Wst2024DataSet1.ItemOrder' table. You can move, or remove it, as needed.
            this.itemOrderTableAdapter.Fill(this.g13Wst2024DataSet1.ItemOrder);
            // TODO: This line of code loads data into the 'g13Wst2024DataSet1.ItemOrder' table. You can move, or remove it, as needed.
            this.itemOrderTableAdapter.Fill(this.g13Wst2024DataSet1.ItemOrder);
            // TODO: This line of code loads data into the 'dataSetInvoice.TemPurchasesInv' table. You can move, or remove it, as needed.
            this.temPurchasesInvTableAdapter.Fill(this.dataSetInvoice.TemPurchasesInv);

            // TODO: This line of code loads data into the 'dataSetInvoice.PurchasesInv' table. You can move, or remove it, as needed.           
            this.itemOrderTableAdapter.Fill(this.g13Wst2024DataSet.ItemOrder);
            // TODO: This line of code loads data into the 'g13Wst2024DataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.g13Wst2024DataSet.Orders);

            this.ControlBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to Confirm?", "Confirmation",
 MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                int? lastOrderid = ordersTableAdapter.GetOrderId();
                int newOrderid = (lastOrderid ?? 0) + 1;

                string totalColumnName = "lineTotalDataGridViewTextBoxColumn";
                decimal total = 0;

                foreach (DataGridViewRow row in dataGridView3.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        if (decimal.TryParse(row.Cells[totalColumnName].Value?.ToString(), out decimal value))
                        {
                            total += value;
                        }
                    }
                }

                try
                {
                    var row = dataGridView3.Rows[0];
                    var SupName = row.Cells[3].Value.ToString();
                    var EMPID = row.Cells[4].Value.ToString();
                    var PARTNO = row.Cells[0].Value.ToString();
                    var QUANTITY = row.Cells[1].Value.ToString();
                    var UNITPRICE = row.Cells[2].Value.ToString();
                    var LINETOTAL = row.Cells[5].Value.ToString();

                    ordersTableAdapter.Insert(newOrderid, int.Parse(EMPID), Convert.ToDateTime(DateTime.Now), total, SupName);
                    ordersTableAdapter.Fill(g13Wst2024DataSet.Orders);
                }
                catch
                {

                }

                foreach (DataGridViewRow row in dataGridView3.Rows)
                {
                    // Check that all necessary cells are not null
                    if (row.Cells[0].Value != null &&
                        row.Cells[1].Value != null &&
                        row.Cells[2].Value != null &&
                        row.Cells[3].Value != null &&
                        row.Cells[4].Value != null &&
                        row.Cells[5].Value != null)
                    {
                        // Get the values
                        string SupName = row.Cells[3].Value.ToString();
                        string EMPID = row.Cells[4].Value.ToString();
                        string PARTNO = row.Cells[0].Value.ToString();
                        string QUANTITY = row.Cells[1].Value.ToString();
                        string UNITPRICE = row.Cells[2].Value.ToString();
                        string LINETOTAL = row.Cells[5].Value.ToString();

                        // Parse values
                        int parsedPartNo;
                        int parsedQuantity;
                        decimal parsedUnitPrice;
                        decimal parsedLineTotal;

                        bool isPartNoValid = int.TryParse(PARTNO, out parsedPartNo);
                        bool isQuantityValid = int.TryParse(QUANTITY, out parsedQuantity);
                        bool isUnitPriceValid = decimal.TryParse(UNITPRICE, out parsedUnitPrice);
                        bool isLineTotalValid = decimal.TryParse(LINETOTAL, out parsedLineTotal);

                        // Only insert if all parsing succeeded
                        if (isPartNoValid && isQuantityValid && isUnitPriceValid && isLineTotalValid)
                        {
                            itemOrderTableAdapter.Insert(newOrderid, parsedPartNo, parsedQuantity, parsedUnitPrice, parsedLineTotal);
                        }
                        else
                        {
                            MessageBox.Show("Invalid data in row. Please check the values.");
                        }
                    }
                }

                // After processing all rows, confirm order and clear fields
                itemOrderTableAdapter.Fill(g13Wst2024DataSet.ItemOrder);
                MessageBox.Show("Order Confirmed with Order Number: " + newOrderid);

                // Clear input fields
                suppNametxt.Text = "";
                empidtxt.Text = "";
                partnotxt.Text = "";
                quantitytxt.Text = "";
                unitPricetxt.Text = "";

                // Refill DataGridView
                temPurchasesInvTableAdapter.Fill(dataSetInvoice.TemPurchasesInv);


            }
            else
            {

            }
        }
           
        private void button2_Click(object sender, EventArgs e)
        {

            decimal linesum = Convert.ToDecimal(unitPricetxt.Text) * Convert.ToDecimal(quantitytxt.Text);
            DataRow row = dataSetInvoice.TemPurchasesInv.NewRow();
            row["SupplierName"] = suppNametxt.Text;
            row["EmployeeID"] = empidtxt.Text;
            row["PartNo"] = partnotxt.Text;
            row["Quantity"] = quantitytxt.Text;
            row["UnitPrice"] = unitPricetxt.Text;
            row["LineTotal"] = linesum;

            dataSetInvoice.TemPurchasesInv.Rows.Add(row);

           
            partnotxt.Text = "";
            quantitytxt.Text = "";
            unitPricetxt.Text = "";
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int OrderID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);

            itemOrderTableAdapter.FillByOrderID(g13Wst2024DataSet.ItemOrder, OrderID);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            suppNametxt.Text = "";
            empidtxt.Text = "";
            partnotxt.Text = "";
            quantitytxt.Text = "";
            unitPricetxt.Text = "";
            temPurchasesInvTableAdapter.Fill(dataSetInvoice.TemPurchasesInv);
        }
    }
}
