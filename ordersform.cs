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
            // TODO: This line of code loads data into the 'g13Wst2024DataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.g13Wst2024DataSet.Orders);

            this.ControlBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ordersTableAdapter.Insert(int.Parse(orderidtxt.Text), int.Parse(empidtxt.Text), Convert.ToDateTime(datetxt.Text), int.Parse(partnotxt.Text));
                MessageBox.Show("Order added Order: " + orderidtxt.Text);
            }
            catch
            {
                MessageBox.Show("Please ensure all details are correct");
            }
            ordersTableAdapter.Fill(g13Wst2024DataSet.Orders);
        }
    }
}
