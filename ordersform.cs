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
                    var SupName = row.Cells[0].Value.ToString();
                    var EMPID = row.Cells[1].Value.ToString();
                    var PARTNO = row.Cells[2].Value.ToString();
                    var QUANTITY = row.Cells[3].Value.ToString();
                    var UNITPRICE = row.Cells[4].Value.ToString();
                    var LINETOTAL = row.Cells[5].Value.ToString();

                    ordersTableAdapter.Insert(newOrderid, int.Parse(EMPID), Convert.ToDateTime(DateTime.Now), total, SupName);
                }
                catch
                {

                }

                foreach (DataGridViewRow row in dataGridView3.Rows)
                {
                    var SupName = row.Cells[0].Value.ToString();
                    var EMPID = row.Cells[1].Value.ToString();
                    var PARTNO = row.Cells[2].Value.ToString();
                    var QUANTITY = row.Cells[3].Value.ToString();
                    var UNITPRICE = row.Cells[4].Value.ToString();
                    var LINETOTAL = row.Cells[5].Value.ToString();

                   
                    itemOrderTableAdapter.Insert(newOrderid,int.Parse(PARTNO), int.Parse(QUANTITY), decimal.Parse(UNITPRICE), decimal.Parse(LINETOTAL));
                }
            }
            else
            {

            }
        }
           
        private void button2_Click(object sender, EventArgs e)
        {

            decimal linesum = decimal.Parse(unitPricetxt.Text) * decimal.Parse(quantitytxt.Text);
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
        }
    }
}
