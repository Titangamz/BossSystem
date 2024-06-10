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
    }
}
