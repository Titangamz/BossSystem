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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        bool sidebarExpand;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void FormSetup(Form myForm)
        {
            foreach (Form c in this.MdiChildren)
            {
                c.Close();
            }
            myForm.MdiParent = this;
            myForm.WindowState = FormWindowState.Maximized;
            myForm.Show();
        }


       
        private void invMenu_Click(object sender, EventArgs e)
        {
            invform invfrm = new invform();
            FormSetup(invfrm);
        }

        private void invContainer_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void custmenubtn_Click(object sender, EventArgs e)
        {
            custform custfrm = new custform();
            FormSetup(custfrm);
        }

        private void sidebartimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebartimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebartimer.Stop();
                }
            } 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            sidebartimer.Start();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ordersform orderfrm = new ordersform();
            FormSetup(orderfrm);
        }

        private void invoicesbtn_Click(object sender, EventArgs e)
        {
            salesForm invoicefrm = new salesForm();
            FormSetup(invoicefrm);
        }
    }
}