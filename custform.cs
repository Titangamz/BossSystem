﻿using System;
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
    public partial class custform : Form
    {
        public custform()
        {
            InitializeComponent();
        }

        private void custform_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'g13Wst2024DataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.g13Wst2024DataSet.Customer);
            this.ControlBox = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            customerTableAdapter.FillBySurname(g13Wst2024DataSet.Customer,textBox1.Text);
        }
    }
}
