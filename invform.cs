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
    }
}
