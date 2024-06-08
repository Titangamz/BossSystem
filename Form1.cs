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

        bool invExpand;
        bool custExpand;
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


        private void invDroptimer_Tick(object sender, EventArgs e)
        {
            if (invExpand)
            {
                invContainer.Height -= 10;
                if (invContainer.Height <= invContainer.MinimumSize.Height)
                {
                    invExpand = false;
                    invDroptimer.Stop();                    
                }
            }
            else
            {              
                invContainer.Height += 10;
                if (invContainer.Height >= invContainer.MaximumSize.Height)
                {
                    invExpand = true;
                    invDroptimer.Stop();
                }
            }
        }
        private void invMenu_Click(object sender, EventArgs e)
        {
            invDroptimer.Start();
        }

        private void invContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void custDroptimer_Tick(object sender, EventArgs e)
        {
            if (custExpand)
            {
                custmenucontainer.Height -= 10;
                if (custmenucontainer.Height <= custmenucontainer.MinimumSize.Height)
                {
                    custExpand = false;
                    custDroptimer.Stop();
                }
            }
            else
            {
                custmenucontainer.Height += 10;
                if (custmenucontainer.Height >= custmenucontainer.MaximumSize.Height)
                {
                    custExpand = true;
                    custDroptimer.Stop();
                }
            }
        }

        private void custmenubtn_Click(object sender, EventArgs e)
        {
            custDroptimer.Start();
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

        private void button1_Click(object sender, EventArgs e)
        {
            invform invfrm = new invform();
            FormSetup(invfrm);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            addinvform ainvfrm = new addinvform();
            FormSetup(ainvfrm);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            custform custfrm = new custform();
            FormSetup(custfrm);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            addcustform acustfrm = new addcustform();
            FormSetup(acustfrm);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ordersform orderfrm = new ordersform();
            FormSetup(orderfrm);
        }

        private void invoicesbtn_Click(object sender, EventArgs e)
        {
            invoiceForm invoicefrm = new invoiceForm();
            FormSetup(invoicefrm);
        }
    }
}