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
    public partial class invform : Form
    {
        public invform()
        {
            InitializeComponent();
        }

        private void invform_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'g13Wst2024DataSet.PartsTable' table. You can move, or remove it, as needed.
            this.partsTableTableAdapter.Fill(this.g13Wst2024DataSet.PartsTable);
            this.ControlBox = false;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void itempricetxt_TextChanged(object sender, EventArgs e)
        {
            if(itempricetxt.Text=="")
            {

            }
            else
            {
                decimal vat = decimal.Parse(itempricetxt.Text) * 15/100;
                vattxt.Text = vat.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to Confirm?", "Confirmation",
MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                  try
                  {
                    
                    partsTableTableAdapter.Insert(int.Parse(partnotxt.Text), itemdesctxt.Text, itemnametxt.Text, int.Parse(itemquantxt.Text), Convert.ToDecimal(itempricetxt.Text), Convert.ToDateTime(daterectxt.Text), Convert.ToDecimal(vattxt.Text), int.Parse(suppidtxt.Text));
                    MessageBox.Show("Part has been added");
                    partsTableTableAdapter.Fill(g13Wst2024DataSet.PartsTable);
                  }
                  catch
                  {
                      MessageBox.Show("Input Error, please ensure details are entered correctly");
                  }
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("New Part NOT Added");
            }

        }

        private void searchBar_TextChanged(object sender, EventArgs e)
        {
            partsTableTableAdapter.FillByItemName(g13Wst2024DataSet.PartsTable, searchBar.Text);
        }

        private void updatepartbtn_Click(object sender, EventArgs e)
        {
            
                 
            DialogResult result = MessageBox.Show("WARNING, this will permanently alter your parts table. Proceed?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
                    DataRow selectedRow = g13Wst2024DataSet.PartsTable.Rows[selectedRowIndex];
                    try
                    {
                        selectedRow["partNo"] = int.Parse(partnotxt.Text);
                        selectedRow["itemName"] = itemnametxt.Text;
                        selectedRow["itemQuantity"] = int.Parse(itemquantxt.Text);
                        selectedRow["itemPrice"] = Convert.ToDecimal(itempricetxt.Text);
                        selectedRow["dateReceived"] = Convert.ToDateTime(daterectxt.Text);
                        selectedRow["itemVat"] = Convert.ToDecimal(vattxt.Text);
                        selectedRow["supplierID"] = int.Parse(suppidtxt.Text);

                        DateTime dateReceived;
                        if (DateTime.TryParse(daterectxt.Text, out dateReceived))
                        {

                           
                        }
                        selectedRow["dateReceived"] = dateReceived;

                        partsTableTableAdapter.Update(g13Wst2024DataSet.PartsTable);
                        MessageBox.Show("Parts updated");

                        partsTableTableAdapter.Fill(g13Wst2024DataSet.PartsTable);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("There was an issue updating the part" + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Please select a row to update");
                }
            }
            else
            {
                MessageBox.Show("Update Cancelled");
            }
        }
          
        
        
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                partnotxt.Text = selectedRow.Cells["partNoDataGridViewTextBoxColumn"].Value.ToString();
                itemdesctxt.Text = selectedRow.Cells["itemDescriptionDataGridViewTextBoxColumn"].Value.ToString();
                itemnametxt.Text = selectedRow.Cells["itemNameDataGridViewTextBoxColumn"].Value.ToString();
                itemquantxt.Text = selectedRow.Cells["itemQuantityDataGridViewTextBoxColumn"].Value.ToString();
                itempricetxt.Text = selectedRow.Cells["itemPriceDataGridViewTextBoxColumn"].Value.ToString();
                daterectxt.Text = selectedRow.Cells["dateReceivedDataGridViewTextBoxColumn"].Value.ToString();
                vattxt.Text = selectedRow.Cells["itemVatDataGridViewTextBoxColumn"].Value.ToString();
                suppidtxt.Text = selectedRow.Cells["supplierIDDataGridViewTextBoxColumn"].Value.ToString();
            }
                
        }

        
    }
}
