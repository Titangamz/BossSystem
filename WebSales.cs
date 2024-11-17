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
    public partial class WebSales : Form
    {
        public WebSales()
        {
            InitializeComponent();
        }

        private void WebSales_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'g13Wst2024DataSet.CustomerOrderItem' table. You can move, or remove it, as needed.
            this.customerOrderItemTableAdapter.Fill(this.g13Wst2024DataSet.CustomerOrderItem);
            // TODO: This line of code loads data into the 'g13Wst2024DataSet.CustomerOrder' table. You can move, or remove it, as needed.
            this.customerOrderTableAdapter.Fill(this.g13Wst2024DataSet.CustomerOrder);

        }
    }
}
