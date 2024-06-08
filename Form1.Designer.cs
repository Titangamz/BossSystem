
namespace bosssystem1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.invMenu = new System.Windows.Forms.Button();
            this.custmenubtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.invoicesbtn = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.sidebartimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.sidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1248, 49);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "BOSS INDUSTRIAL";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.sidebar.Controls.Add(this.invMenu);
            this.sidebar.Controls.Add(this.custmenubtn);
            this.sidebar.Controls.Add(this.button2);
            this.sidebar.Controls.Add(this.invoicesbtn);
            this.sidebar.Controls.Add(this.button6);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 49);
            this.sidebar.MaximumSize = new System.Drawing.Size(200, 545);
            this.sidebar.MinimumSize = new System.Drawing.Size(58, 545);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(200, 545);
            this.sidebar.TabIndex = 1;
            // 
            // invMenu
            // 
            this.invMenu.BackColor = System.Drawing.Color.Black;
            this.invMenu.FlatAppearance.BorderSize = 0;
            this.invMenu.ForeColor = System.Drawing.Color.White;
            this.invMenu.Image = ((System.Drawing.Image)(resources.GetObject("invMenu.Image")));
            this.invMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.invMenu.Location = new System.Drawing.Point(0, 0);
            this.invMenu.Margin = new System.Windows.Forms.Padding(0);
            this.invMenu.Name = "invMenu";
            this.invMenu.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.invMenu.Size = new System.Drawing.Size(200, 50);
            this.invMenu.TabIndex = 3;
            this.invMenu.Text = "    Inventory";
            this.invMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.invMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.invMenu.UseVisualStyleBackColor = false;
            this.invMenu.Click += new System.EventHandler(this.invMenu_Click);
            // 
            // custmenubtn
            // 
            this.custmenubtn.BackColor = System.Drawing.Color.Black;
            this.custmenubtn.ForeColor = System.Drawing.Color.White;
            this.custmenubtn.Image = ((System.Drawing.Image)(resources.GetObject("custmenubtn.Image")));
            this.custmenubtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.custmenubtn.Location = new System.Drawing.Point(0, 50);
            this.custmenubtn.Margin = new System.Windows.Forms.Padding(0);
            this.custmenubtn.Name = "custmenubtn";
            this.custmenubtn.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.custmenubtn.Size = new System.Drawing.Size(200, 50);
            this.custmenubtn.TabIndex = 3;
            this.custmenubtn.Text = "    Customers";
            this.custmenubtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.custmenubtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.custmenubtn.UseVisualStyleBackColor = false;
            this.custmenubtn.Click += new System.EventHandler(this.custmenubtn_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 100);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(200, 50);
            this.button2.TabIndex = 3;
            this.button2.Text = "    Orders";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // invoicesbtn
            // 
            this.invoicesbtn.BackColor = System.Drawing.Color.Black;
            this.invoicesbtn.ForeColor = System.Drawing.Color.White;
            this.invoicesbtn.Image = ((System.Drawing.Image)(resources.GetObject("invoicesbtn.Image")));
            this.invoicesbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.invoicesbtn.Location = new System.Drawing.Point(0, 150);
            this.invoicesbtn.Margin = new System.Windows.Forms.Padding(0);
            this.invoicesbtn.Name = "invoicesbtn";
            this.invoicesbtn.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.invoicesbtn.Size = new System.Drawing.Size(200, 50);
            this.invoicesbtn.TabIndex = 3;
            this.invoicesbtn.Text = "    Sales";
            this.invoicesbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.invoicesbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.invoicesbtn.UseVisualStyleBackColor = false;
            this.invoicesbtn.Click += new System.EventHandler(this.invoicesbtn_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Black;
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(0, 200);
            this.button6.Margin = new System.Windows.Forms.Padding(0);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button6.Size = new System.Drawing.Size(200, 50);
            this.button6.TabIndex = 3;
            this.button6.Text = "    LogOut";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // sidebartimer
            // 
            this.sidebartimer.Interval = 10;
            this.sidebartimer.Tick += new System.EventHandler(this.sidebartimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1248, 594);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.sidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Button invMenu;
        private System.Windows.Forms.Button custmenubtn;
        private System.Windows.Forms.Timer sidebartimer;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button invoicesbtn;
    }
}

