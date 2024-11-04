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
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }
       
      private void LogInForm_Load(object sender, EventArgs e)
        {
          
        }

      
    private void loginbtn_Click(object sender, EventArgs e)
        {
           
           
            string name = textBox1.Text;
            string password = textBox2.Text;

            if (CheckCredentials(name, password))
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Form1 frm1 = new Form1(textBox1.Text);
                frm1.ShowDialog();
                this.Close();

               
            }
            else
            {
                MessageBox.Show("Invalid credentials. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool CheckCredentials(string name,string password)
        {
            var result = employeeTableAdapter1.GetDataByNameAndPassword(name, password);
            return result.Rows.Count > 0;
        }
    }
}
