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
        bool saledrpexp;
        bool suppdrpexp;

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
        private void saledrptimer_Tick(object sender, EventArgs e)
        {
            if (saledrpexp)
            {
                saleContainer.Height -= 10;
                if (saleContainer.Height <= saleContainer.MinimumSize.Height)
                {
                    saledrpexp = false;
                    saledrptimer.Stop();
                }
            }
            else
            {
                saleContainer.Height += 10;
                if (saleContainer.Height >= saleContainer.MaximumSize.Height)
                {
                    saledrpexp = true;
                    saledrptimer.Stop();
                }
            }
        }

        private void suppdrptimer_Tick(object sender, EventArgs e)
        {
            if (suppdrpexp)
            {
                suppContainer.Height -= 10;
                if (suppContainer.Height <= suppContainer.MinimumSize.Height)
                {
                    suppdrpexp = false;
                    suppdrptimer.Stop();
                }
            }
            else
            {
                suppContainer.Height += 10;
                if (suppContainer.Height >= suppContainer.MaximumSize.Height)
                {
                    suppdrpexp = true;
                    suppdrptimer.Stop();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            sidebartimer.Start();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit the application?", "LogOut?",
MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else if (result == DialogResult.No)
            {
                
            }
            
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

        private void viewsalesbtn_Click(object sender, EventArgs e)
        {
            viewSales viewsle = new viewSales();
            FormSetup(viewsle);
        }

        private void saledrpbtn_Click(object sender, EventArgs e)
        {
            saledrptimer.Start();
        }

        private void supplierdrpbtn_Click(object sender, EventArgs e)
        {
            suppdrptimer.Start();
        }

        private void viewsuppbtn_Click(object sender, EventArgs e)
        {
            viewsuppliersform viewsuppfrm = new viewsuppliersform();
            FormSetup(viewsuppfrm);
        }

        private void employeebtn_Click(object sender, EventArgs e)
        {
            EmployeeForm empfrm = new EmployeeForm();
            FormSetup(empfrm);
        }
    }
}