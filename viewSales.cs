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
            // TODO: This line of code loads data into the 'g13Wst2024DataSet1.Overall_sales' table. You can move, or remove it, as needed.
            this.overall_salesTableAdapter.Fill(this.g13Wst2024DataSet1.Overall_sales);
          


            this.ControlBox = false;
        }

      private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           // salebkTableAdapter.FillByPurchaseDate(g13Wst2024DataSet.Salebk, dateTimePicker1.Value.ToShortDateString());
        }

        private void dgvsalesview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          /*  DialogResult result = MessageBox.Show("WARNING, this will permanantly alter your sales table. Proceed?", "Confirmation",
MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                salebkTableAdapter.Update(g13Wst2024DataSet.Salebk);
                salebkTableAdapter.Fill(g13Wst2024DataSet.Salebk);
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Update Cancelled");
            }*/
        }
    }
}
