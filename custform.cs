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
    public partial class custform : Form
    {
        private bool isUpdating = false;

        public custform()
        {
            InitializeComponent();
          
        }

        private void custform_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'g13Wst2024DataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.g13Wst2024DataSet.Customer);
            this.ControlBox = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            customerTableAdapter.FillBySurname(g13Wst2024DataSet.Customer,textBox1.Text);
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
                    customerTableAdapter.Insert(int.Parse(custidtxt.Text), custfnametxt.Text, custsnametxt.Text, custphnnumtxt.Text, custaddresstxt.Text);
                    MessageBox.Show("New Customer Added");
                    customerTableAdapter.Fill(g13Wst2024DataSet.Customer);
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

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (isUpdating) return;
            
            DialogResult result = MessageBox.Show("Warning, this will permanently alter your customer table. Proceed?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                isUpdating = true;
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    

                    int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
                    DataRow selectedRow = g13Wst2024DataSet.Customer.Rows[selectedRowIndex];

                    selectedRow["CustomerID"] = int.Parse(custidtxt.Text);
                    selectedRow["CustomerName"] = custfnametxt.Text;
                    selectedRow["CustomerSurname"] = custsnametxt.Text;
                    selectedRow["CustomerPhoneNumber"] = custphnnumtxt.Text;
                    selectedRow["CustomerAddress"] = custaddresstxt.Text;

                    try
                    {
                        dataGridView1.SelectionChanged -= dataGridView1_SelectionChanged; // Disable event handler
                        customerTableAdapter.Update(g13Wst2024DataSet.Customer);
                        MessageBox.Show("Customer updated successfully!");
                        customerTableAdapter.Fill(g13Wst2024DataSet.Customer);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while updating the customer: " + ex.Message);
                    }
                    finally
                    {
                        isUpdating = false;
                    }
                }
                else
                {
                    MessageBox.Show("Please select a row to update");
                }
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Update Cancelled");
            }

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (isUpdating) return;

            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selecteRow = dataGridView1.SelectedRows[0];
                custidtxt.Text = selecteRow.Cells["CustomerIDDataGridViewTextBoxColumn"].Value.ToString();
                custfnametxt.Text = selecteRow.Cells["CustomerNameDataGridViewTextBoxColumn"].Value.ToString();
                custsnametxt.Text = selecteRow.Cells["CustomerSurnameDataGridViewTextBoxColumn"].Value.ToString();
                custphnnumtxt.Text = selecteRow.Cells["CustomerPhoneNumberDataGridViewTextBoxColumn"].Value.ToString();
                custaddresstxt.Text = selecteRow.Cells["CustomerAddressDataGridViewTextBoxColumn"].Value.ToString();
            }

        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            custidtxt.Clear();
            custaddresstxt.Clear();
            custfnametxt.Clear();
            custsnametxt.Clear();
            custphnnumtxt.Clear();

        }
    }
}
