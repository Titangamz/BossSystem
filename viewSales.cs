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
            // TODO: This line of code loads data into the 'g13Wst2024DataSet.CustPayments' table. You can move, or remove it, as needed.
            this.custPaymentsTableAdapter.Fill(this.g13Wst2024DataSet.CustPayments);
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
            DialogResult result = MessageBox.Show("Are you sure you wanna add this payment. Proceed?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {

                decimal amtowed = decimal.Parse(textBox2.Text) - decimal.Parse(textBox1.Text);
                if(amtowed == 0)
                {
                    MessageBox.Show("Invoice fully paid");
                }
                else if(amtowed<0)
                {
                    MessageBox.Show("WARNING, Please ensure corrct change is given R" + (amtowed*-1));
                    amtowed = 0;
                }



                custPaymentsTableAdapter.Insert(Convert.ToInt32(textBox3.Text), Convert.ToDateTime(maskedTextBox1.Text), Convert.ToDecimal(textBox1.Text), amtowed);

                maskedTextBox1.Text = "";
                textBox2.Text = "";
                textBox1.Text = "";
                textBox3.Text = "";
            }
            else
            {
                MessageBox.Show("Payment Cancelled");
            }
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
            custPaymentsTableAdapter.FillByInvNum(g13Wst2024DataSet.CustPayments, invoiceNumber);
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView3_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridView3.SelectedRows.Count>0)
            {
                DataGridViewRow selectedrow = dataGridView3.SelectedRows[0];
                
                textBox2.Text = selectedrow.Cells["amountOutstandingDataGridViewTextBoxColumn"].Value.ToString();
                textBox3.Text = selectedrow.Cells["invoiceNumberDataGridViewTextBoxColumn2"].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "";
            textBox2.Text = "";
            textBox1.Text = "";
            textBox3.Text = "";
        }
    }
}
