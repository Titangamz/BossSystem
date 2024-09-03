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
    public partial class viewsuppliersform : Form
    {
        private bool isUpdating;
        public viewsuppliersform()
        {
            InitializeComponent();
        }

        private void viewsuppliersform_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'g13Wst2024DataSet.Supplier' table. You can move, or remove it, as needed.
            this.supplierTableAdapter.Fill(this.g13Wst2024DataSet.Supplier);
            this.ControlBox = false;
        }

        private void suppsearchtxt_TextChanged(object sender, EventArgs e)
        {
            supplierTableAdapter.FillBySupplierName(g13Wst2024DataSet.Supplier, suppsearchtxt.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                // Assuming columns are named appropriately
                SuppIDtxt.Text = selectedRow.Cells["supplierIDDataGridViewTextBoxColumn"].Value?.ToString();
                SuppNametxt.Text = selectedRow.Cells["supplierNameDataGridViewTextBoxColumn"].Value?.ToString();
                SuppNumtxt.Text = selectedRow.Cells["supplierNumberDataGridViewTextBoxColumn"].Value?.ToString();
                SuppMailtxt.Text = selectedRow.Cells["supplierEmailDataGridViewTextBoxColumn"].Value?.ToString();
                SuppAddtxt.Text = selectedRow.Cells["supplierAddressDataGridViewTextBoxColumn"].Value?.ToString();
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isUpdating) return;

            DialogResult result = MessageBox.Show("Do you want to Confirm?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                isUpdating = true;

                try
                {
                    dataGridView1.SelectionChanged -= dataGridView1_SelectionChanged; // Disable event handler
                    supplierTableAdapter.Insert(int.Parse(SuppIDtxt.Text),SuppNametxt.Text,int.Parse(SuppNumtxt.Text),SuppMailtxt.Text,SuppAddtxt.Text);
                    MessageBox.Show("Employee Added");
                    supplierTableAdapter.Fill(g13Wst2024DataSet.Supplier);
                }
                catch
                {
                    MessageBox.Show("Input Error, please ensure details are entered correctly");
                }
                finally
                {
                    isUpdating = false;
                }
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("New Part NOT Added");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Warning, this will permanently alter the supplier record. Procceed?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
                    DataRow selectedRow = g13Wst2024DataSet.Supplier.Rows[selectedRowIndex];

                    int supplierID;
                    if (!int.TryParse(SuppIDtxt.Text, out supplierID))
                    {
                        MessageBox.Show("Invalid Supplier ID. Please enter a valid number");
                        return;
                    }

                    string supplierName = SuppNametxt.Text;
                    string supplierNumber = SuppNumtxt.Text;
                    string supplierAddress = SuppAddtxt.Text;
                    string supplierId = SuppIDtxt.Text;
                    string supplierMail = SuppMailtxt.Text;

                    selectedRow["SupplierID"] = supplierID;
                    selectedRow["SupplierName"] = supplierName;
                    selectedRow["SupplierNumber"] = supplierNumber;
                    selectedRow["SupplierAddress"] = supplierAddress;
                    selectedRow["SupplierEmail"] = supplierMail;

                    try
                    {
                        supplierTableAdapter.Update(g13Wst2024DataSet.Supplier);
                        MessageBox.Show("Supplier updated successfully!");
                        supplierTableAdapter.Fill(g13Wst2024DataSet.Supplier);
                    }

                    catch (System.Data.SqlClient.SqlException ex) when (ex.Number == 2627)
                    {
                        MessageBox.Show("A supplier with this ID already Exists. Please Enter a unique ID.");
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while updating the supplier: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Please select a supplier to update.");
                }
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Update Cancelled");
            }

        }
    }
}
