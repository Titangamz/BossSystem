
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.invMenu = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.custmenubtn = new System.Windows.Forms.Button();
            this.saleContainer = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.viewsalesbtn = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.saledrpbtn = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.invoicesbtn = new System.Windows.Forms.Button();
            this.suppContainer = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.viewsuppbtn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.supplierdrpbtn = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.employeebtn = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.sidebartimer = new System.Windows.Forms.Timer(this.components);
            this.saledrptimer = new System.Windows.Forms.Timer(this.components);
            this.suppdrptimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.sidebar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.saleContainer.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel5.SuspendLayout();
            this.suppContainer.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel7.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(1248, 50);
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
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Controls.Add(this.panel3);
            this.sidebar.Controls.Add(this.saleContainer);
            this.sidebar.Controls.Add(this.suppContainer);
            this.sidebar.Controls.Add(this.panel9);
            this.sidebar.Controls.Add(this.panel7);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 50);
            this.sidebar.MaximumSize = new System.Drawing.Size(200, 545);
            this.sidebar.MinimumSize = new System.Drawing.Size(58, 545);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(200, 545);
            this.sidebar.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.invMenu);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.MaximumSize = new System.Drawing.Size(200, 50);
            this.panel2.MinimumSize = new System.Drawing.Size(200, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 50);
            this.panel2.TabIndex = 5;
            // 
            // invMenu
            // 
            this.invMenu.BackColor = System.Drawing.Color.Black;
            this.invMenu.FlatAppearance.BorderSize = 0;
            this.invMenu.ForeColor = System.Drawing.Color.White;
            this.invMenu.Image = ((System.Drawing.Image)(resources.GetObject("invMenu.Image")));
            this.invMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.invMenu.Location = new System.Drawing.Point(-12, -25);
            this.invMenu.Margin = new System.Windows.Forms.Padding(0);
            this.invMenu.Name = "invMenu";
            this.invMenu.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.invMenu.Size = new System.Drawing.Size(233, 100);
            this.invMenu.TabIndex = 3;
            this.invMenu.Text = "    Inventory";
            this.invMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.invMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.invMenu.UseVisualStyleBackColor = false;
            this.invMenu.Click += new System.EventHandler(this.invMenu_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.custmenubtn);
            this.panel3.Location = new System.Drawing.Point(0, 50);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.MaximumSize = new System.Drawing.Size(200, 50);
            this.panel3.MinimumSize = new System.Drawing.Size(200, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 50);
            this.panel3.TabIndex = 6;
            // 
            // custmenubtn
            // 
            this.custmenubtn.BackColor = System.Drawing.Color.Black;
            this.custmenubtn.ForeColor = System.Drawing.Color.White;
            this.custmenubtn.Image = ((System.Drawing.Image)(resources.GetObject("custmenubtn.Image")));
            this.custmenubtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.custmenubtn.Location = new System.Drawing.Point(-11, -24);
            this.custmenubtn.Margin = new System.Windows.Forms.Padding(0);
            this.custmenubtn.Name = "custmenubtn";
            this.custmenubtn.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.custmenubtn.Size = new System.Drawing.Size(251, 100);
            this.custmenubtn.TabIndex = 3;
            this.custmenubtn.Text = "    Customers";
            this.custmenubtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.custmenubtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.custmenubtn.UseVisualStyleBackColor = false;
            this.custmenubtn.Click += new System.EventHandler(this.custmenubtn_Click);
            // 
            // saleContainer
            // 
            this.saleContainer.Controls.Add(this.panel6);
            this.saleContainer.Controls.Add(this.panel8);
            this.saleContainer.Controls.Add(this.panel5);
            this.saleContainer.Location = new System.Drawing.Point(0, 100);
            this.saleContainer.Margin = new System.Windows.Forms.Padding(0);
            this.saleContainer.MaximumSize = new System.Drawing.Size(200, 150);
            this.saleContainer.MinimumSize = new System.Drawing.Size(200, 50);
            this.saleContainer.Name = "saleContainer";
            this.saleContainer.Size = new System.Drawing.Size(200, 50);
            this.saleContainer.TabIndex = 11;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.viewsalesbtn);
            this.panel6.Location = new System.Drawing.Point(0, 100);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.MaximumSize = new System.Drawing.Size(200, 50);
            this.panel6.MinimumSize = new System.Drawing.Size(200, 50);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 50);
            this.panel6.TabIndex = 9;
            // 
            // viewsalesbtn
            // 
            this.viewsalesbtn.BackColor = System.Drawing.Color.Black;
            this.viewsalesbtn.ForeColor = System.Drawing.Color.White;
            this.viewsalesbtn.Image = ((System.Drawing.Image)(resources.GetObject("viewsalesbtn.Image")));
            this.viewsalesbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.viewsalesbtn.Location = new System.Drawing.Point(-12, -21);
            this.viewsalesbtn.Margin = new System.Windows.Forms.Padding(0);
            this.viewsalesbtn.Name = "viewsalesbtn";
            this.viewsalesbtn.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.viewsalesbtn.Size = new System.Drawing.Size(242, 91);
            this.viewsalesbtn.TabIndex = 4;
            this.viewsalesbtn.Text = "    View Sales";
            this.viewsalesbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.viewsalesbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.viewsalesbtn.UseVisualStyleBackColor = false;
            this.viewsalesbtn.Click += new System.EventHandler(this.viewsalesbtn_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.saledrpbtn);
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Margin = new System.Windows.Forms.Padding(0);
            this.panel8.MaximumSize = new System.Drawing.Size(200, 50);
            this.panel8.MinimumSize = new System.Drawing.Size(200, 50);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(200, 50);
            this.panel8.TabIndex = 12;
            // 
            // saledrpbtn
            // 
            this.saledrpbtn.BackColor = System.Drawing.Color.Black;
            this.saledrpbtn.FlatAppearance.BorderSize = 0;
            this.saledrpbtn.ForeColor = System.Drawing.Color.White;
            this.saledrpbtn.Image = ((System.Drawing.Image)(resources.GetObject("saledrpbtn.Image")));
            this.saledrpbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saledrpbtn.Location = new System.Drawing.Point(-12, -25);
            this.saledrpbtn.Margin = new System.Windows.Forms.Padding(0);
            this.saledrpbtn.Name = "saledrpbtn";
            this.saledrpbtn.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.saledrpbtn.Size = new System.Drawing.Size(233, 100);
            this.saledrpbtn.TabIndex = 3;
            this.saledrpbtn.Text = "    Sales";
            this.saledrpbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saledrpbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.saledrpbtn.UseVisualStyleBackColor = false;
            this.saledrpbtn.Click += new System.EventHandler(this.saledrpbtn_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.invoicesbtn);
            this.panel5.Location = new System.Drawing.Point(0, 50);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.MaximumSize = new System.Drawing.Size(200, 50);
            this.panel5.MinimumSize = new System.Drawing.Size(200, 50);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 50);
            this.panel5.TabIndex = 8;
            // 
            // invoicesbtn
            // 
            this.invoicesbtn.BackColor = System.Drawing.Color.Black;
            this.invoicesbtn.ForeColor = System.Drawing.Color.White;
            this.invoicesbtn.Image = ((System.Drawing.Image)(resources.GetObject("invoicesbtn.Image")));
            this.invoicesbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.invoicesbtn.Location = new System.Drawing.Point(-12, -24);
            this.invoicesbtn.Margin = new System.Windows.Forms.Padding(0);
            this.invoicesbtn.Name = "invoicesbtn";
            this.invoicesbtn.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.invoicesbtn.Size = new System.Drawing.Size(230, 100);
            this.invoicesbtn.TabIndex = 3;
            this.invoicesbtn.Text = "    Process Sales";
            this.invoicesbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.invoicesbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.invoicesbtn.UseVisualStyleBackColor = false;
            this.invoicesbtn.Click += new System.EventHandler(this.invoicesbtn_Click);
            // 
            // suppContainer
            // 
            this.suppContainer.Controls.Add(this.panel11);
            this.suppContainer.Controls.Add(this.panel4);
            this.suppContainer.Controls.Add(this.panel10);
            this.suppContainer.Location = new System.Drawing.Point(0, 150);
            this.suppContainer.Margin = new System.Windows.Forms.Padding(0);
            this.suppContainer.MaximumSize = new System.Drawing.Size(200, 150);
            this.suppContainer.MinimumSize = new System.Drawing.Size(200, 50);
            this.suppContainer.Name = "suppContainer";
            this.suppContainer.Size = new System.Drawing.Size(200, 50);
            this.suppContainer.TabIndex = 8;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.viewsuppbtn);
            this.panel11.Location = new System.Drawing.Point(0, 50);
            this.panel11.Margin = new System.Windows.Forms.Padding(0);
            this.panel11.MaximumSize = new System.Drawing.Size(200, 50);
            this.panel11.MinimumSize = new System.Drawing.Size(200, 50);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(200, 50);
            this.panel11.TabIndex = 9;
            // 
            // viewsuppbtn
            // 
            this.viewsuppbtn.BackColor = System.Drawing.Color.Black;
            this.viewsuppbtn.ForeColor = System.Drawing.Color.White;
            this.viewsuppbtn.Image = ((System.Drawing.Image)(resources.GetObject("viewsuppbtn.Image")));
            this.viewsuppbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.viewsuppbtn.Location = new System.Drawing.Point(-12, -12);
            this.viewsuppbtn.Margin = new System.Windows.Forms.Padding(0);
            this.viewsuppbtn.Name = "viewsuppbtn";
            this.viewsuppbtn.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.viewsuppbtn.Size = new System.Drawing.Size(253, 78);
            this.viewsuppbtn.TabIndex = 3;
            this.viewsuppbtn.Text = "    View Suppliers";
            this.viewsuppbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.viewsuppbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.viewsuppbtn.UseVisualStyleBackColor = false;
            this.viewsuppbtn.Click += new System.EventHandler(this.viewsuppbtn_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button2);
            this.panel4.Location = new System.Drawing.Point(0, 100);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.MaximumSize = new System.Drawing.Size(200, 50);
            this.panel4.MinimumSize = new System.Drawing.Size(200, 50);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 50);
            this.panel4.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(-12, -13);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(253, 78);
            this.button2.TabIndex = 3;
            this.button2.Text = "    Orders";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.supplierdrpbtn);
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Margin = new System.Windows.Forms.Padding(0);
            this.panel10.MaximumSize = new System.Drawing.Size(200, 50);
            this.panel10.MinimumSize = new System.Drawing.Size(200, 50);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(200, 50);
            this.panel10.TabIndex = 9;
            // 
            // supplierdrpbtn
            // 
            this.supplierdrpbtn.BackColor = System.Drawing.Color.Black;
            this.supplierdrpbtn.FlatAppearance.BorderSize = 0;
            this.supplierdrpbtn.ForeColor = System.Drawing.Color.White;
            this.supplierdrpbtn.Image = ((System.Drawing.Image)(resources.GetObject("supplierdrpbtn.Image")));
            this.supplierdrpbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.supplierdrpbtn.Location = new System.Drawing.Point(-12, -25);
            this.supplierdrpbtn.Margin = new System.Windows.Forms.Padding(0);
            this.supplierdrpbtn.Name = "supplierdrpbtn";
            this.supplierdrpbtn.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.supplierdrpbtn.Size = new System.Drawing.Size(233, 100);
            this.supplierdrpbtn.TabIndex = 3;
            this.supplierdrpbtn.Text = "    Suppliers";
            this.supplierdrpbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.supplierdrpbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.supplierdrpbtn.UseVisualStyleBackColor = false;
            this.supplierdrpbtn.Click += new System.EventHandler(this.supplierdrpbtn_Click);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.employeebtn);
            this.panel9.Location = new System.Drawing.Point(0, 200);
            this.panel9.Margin = new System.Windows.Forms.Padding(0);
            this.panel9.MaximumSize = new System.Drawing.Size(200, 50);
            this.panel9.MinimumSize = new System.Drawing.Size(200, 50);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(200, 50);
            this.panel9.TabIndex = 11;
            // 
            // employeebtn
            // 
            this.employeebtn.BackColor = System.Drawing.Color.Black;
            this.employeebtn.ForeColor = System.Drawing.Color.White;
            this.employeebtn.Image = ((System.Drawing.Image)(resources.GetObject("employeebtn.Image")));
            this.employeebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.employeebtn.Location = new System.Drawing.Point(-12, -24);
            this.employeebtn.Margin = new System.Windows.Forms.Padding(0);
            this.employeebtn.Name = "employeebtn";
            this.employeebtn.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.employeebtn.Size = new System.Drawing.Size(261, 100);
            this.employeebtn.TabIndex = 3;
            this.employeebtn.Text = "    Employee";
            this.employeebtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.employeebtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.employeebtn.UseVisualStyleBackColor = false;
            this.employeebtn.Click += new System.EventHandler(this.employeebtn_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.button6);
            this.panel7.Location = new System.Drawing.Point(0, 250);
            this.panel7.Margin = new System.Windows.Forms.Padding(0);
            this.panel7.MaximumSize = new System.Drawing.Size(200, 50);
            this.panel7.MinimumSize = new System.Drawing.Size(200, 50);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(200, 50);
            this.panel7.TabIndex = 10;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Black;
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(-12, -24);
            this.button6.Margin = new System.Windows.Forms.Padding(0);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button6.Size = new System.Drawing.Size(261, 100);
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
            // saledrptimer
            // 
            this.saledrptimer.Interval = 10;
            this.saledrptimer.Tick += new System.EventHandler(this.saledrptimer_Tick);
            // 
            // suppdrptimer
            // 
            this.suppdrptimer.Interval = 10;
            this.suppdrptimer.Tick += new System.EventHandler(this.suppdrptimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1248, 594);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "BOSS INDUSTRIAL";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.sidebar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.saleContainer.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.suppContainer.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
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
        private System.Windows.Forms.Button viewsalesbtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel saleContainer;
        private System.Windows.Forms.Timer saledrptimer;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button saledrpbtn;
        private System.Windows.Forms.Panel suppContainer;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button supplierdrpbtn;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button viewsuppbtn;
        private System.Windows.Forms.Timer suppdrptimer;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button employeebtn;
    }
}

