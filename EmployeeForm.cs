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
    public partial class EmployeeForm : Form
    {
        private bool isUpdating;

        public EmployeeForm()
        {
            InitializeComponent();

          

        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'g13Wst2024DataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.g13Wst2024DataSet.Employee);
            this.ControlBox = false;
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
           DialogResult result = MessageBox.Show("WARNING, this will permanantly alter your employee table. Proceed?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {

                if (dataGridView1.SelectedRows.Count > 0)
                {
                     int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
                    DataRow selectedRow = g13Wst2024DataSet.Employee.Rows[selectedRowIndex];

                    int employeeID;
                    if (!int.TryParse(empidtxt.Text, out employeeID))
                    {
                        MessageBox.Show("Invlid Employee ID. Please enter a valid number.");
                        return;
                    }

                    string employeePhoneNumber = empnumtxt.Text;

                    selectedRow["EmployeeId"] = employeeID;
                    selectedRow["EmployeeName"] = empnametxt.Text;
                    selectedRow["EmployeeSurname"] = empsurtxt.Text;
                    selectedRow["EmployeePhoneNumber"] = employeePhoneNumber;
                    selectedRow["EmployeeEmail"] = empmailtxt.Text;
                    selectedRow["EmployeePassword"] = emppasstxt.Text;

                    try
                    {
                        employeeTableAdapter.Update(g13Wst2024DataSet.Employee);

                        MessageBox.Show("Employee updated Successfully!");

                        employeeTableAdapter.Fill(g13Wst2024DataSet.Employee);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occured while updating the employee: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Please select a row to update.");
                }
            }
            else
            {
                MessageBox.Show("Update Cancelled");
            }


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
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
                    employeeTableAdapter.Insert(int.Parse(empidtxt.Text), empnametxt.Text, empsurtxt.Text, empnumtxt.Text, empmailtxt.Text, emppasstxt.Text);
                    MessageBox.Show("Employee Added");
                    employeeTableAdapter.Fill(g13Wst2024DataSet.Employee);
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

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                empidtxt.Text = selectedRow.Cells["employeeIDDataGridViewTextBoxColumn"].Value.ToString();
                empnametxt.Text = selectedRow.Cells["employeeNameDataGridViewTextBoxColumn"].Value.ToString();
                empsurtxt.Text = selectedRow.Cells["employeeSurnameDataGridViewTextBoxColumn"].Value.ToString();
                empnumtxt.Text = selectedRow.Cells["employeePhoneNumberDataGridViewTextBoxColumn"].Value.ToString();
                empmailtxt.Text = selectedRow.Cells["employeeEmailDataGridViewTextBoxColumn"].Value.ToString();
               
            }

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
