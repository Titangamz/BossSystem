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
    public partial class invoiceForm : Form
    {
        public invoiceForm()
        {
            InitializeComponent();
        }

        private void invoiceForm_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
    }
}
