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
    public partial class addinvform : Form
    {
        public addinvform()
        {
            InitializeComponent();
        }

        private void addinvform_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void incertpartbtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to Confirm?", "Confirmation",
MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                partsTableTableAdapter1.Insert(int.Parse(parttxt.Text), desctxt.Text, nametxt.Text, int.Parse(quantxt.Text), Convert.ToDecimal(pricetxt.Text));
                MessageBox.Show("New Part Added");
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("New Part NOT Added");
            }
           
        }
    }
}
