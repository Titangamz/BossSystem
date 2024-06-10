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
            DialogResult result = MessageBox.Show("WARNING, this will permanantly alter your employee table. Proceed?", "Confirmation",
MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                employeeTableAdapter.Update(g13Wst2024DataSet.Employee);
                employeeTableAdapter.Fill(g13Wst2024DataSet.Employee);
            }
            else if (result == DialogResult.No)
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
            employeeTableAdapter.Insert(int.Parse(empidtxt.Text), empnametxt.Text, empsurtxt.Text, empnumtxt.Text, empmailtxt.Text, emppasstxt.Text);
            MessageBox.Show("Employee Added");
        }
    }
}
