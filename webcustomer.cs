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
    public partial class webcustomer : Form
    {
        public webcustomer()
        {
            InitializeComponent();
        }

        private void webcustomer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'g13Wst2024DataSet.CustomerDB' table. You can move, or remove it, as needed.
            this.customerDBTableAdapter.Fill(this.g13Wst2024DataSet.CustomerDB);

        }
    }
}
